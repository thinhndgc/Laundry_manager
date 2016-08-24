using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaunryManager;

namespace LaunryManager
{
    public partial class Main : Form
    {
        databaseContext db = new databaseContext();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            createMenuBar();
            initComboboxSearchType();

        }

        private void initComboboxSearchType()
        {
            if (cbSearchType.Items.Count == 0)
            {
                cbSearchType.Items.Insert(0, "Staff name");
                cbSearchType.Items.Insert(1, "Account");
                cbSearchType.SelectedIndex = 0;
            }
        }

        private void createMenuBar()
        {
            this.Menu = new MainMenu();
            MenuItem item = new MenuItem("Account");
            this.Menu.MenuItems.Add(item);
            if (Global.AccountType.Equals("admin"))
            {
                item.MenuItems.Add("Account manager", new EventHandler(accountManager_Click));
            }
            item.MenuItems.Add("Change password", new EventHandler(changePassword_Click));
            item.MenuItems.Add("Logout", new EventHandler(logout_Click));
            item.MenuItems.Add("Exit", new EventHandler(exit_Click));
        }

        private void accountManager_Click(object sender, EventArgs e)
        {
            initAccountManagerPanel();
        }

        private void initAccountManagerPanel()
        {
            accountManagerPanel.Visible = true;
            loadStaffAccount();
        }

        public void loadStaffAccount()
        {
            clearStaffGrid();
            try
            {
                String query = "select * from Staff where account not in ('admin')";
                SqlConnection conn = db.getConnection();
                var table = new DataTable();
                conn.Open();
                using (var da = new SqlDataAdapter(query, conn))
                {
                    da.Fill(table);
                }
                staffGrid.DataSource = table;
                setGridColStyle();
                conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            
        }

        private void setGridColStyle()
        {
            if (staffGrid != null)
            {
                staffGrid.Columns[0].Visible = false;
                staffGrid.Columns[1].HeaderText = "Staff Name";
                staffGrid.Columns[2].HeaderText = "Account";
                staffGrid.Columns[3].HeaderText = "Password";
                staffGrid.Columns[3].Name = "Password";
                staffGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "";
                btnDel.Text = "Delete";
                btnDel.Name = "btnDetele";
                staffGrid.Columns.Add(btnDel);
                btnDel.UseColumnTextForButtonValue = true;
            }
        }

        private void clearStaffGrid()
        {
            staffGrid.DataSource = null;
            staffGrid.Columns.Clear();
            staffGrid.Rows.Clear();
            staffGrid.Refresh();
        }

        private void staffGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (staffGrid.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
                {
                    staffGrid.Rows[e.RowIndex].Tag = e.Value;
                    e.Value = new String('*', e.Value.ToString().Length);
                }
            }
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            AddStaff addst = new AddStaff();
            addst.ShowDialog();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            ChangePassword cgp = new ChangePassword();
            cgp.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            Form1 loginForm = new Form1();
            this.Visible = false;
            loginForm.ShowDialog();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void exit()
        {
            this.Visible = false;
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadStaffAccount();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            int searchType = Convert.ToInt32(cbSearchType.SelectedIndex);
            searchType++;
            staffGrid.ClearSelection();
            string searchValue = txtSearch.Text;
            int flag = 0;
            staffGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in staffGrid.Rows)
                {
                    if (row.Cells[searchType].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    showSearchStaffErr();
                }

            }
            catch (Exception)
            {
                showSearchStaffErr();
            }
        }

        private static void showSearchStaffErr()
        {
            MessageBox.Show("No staff found!");
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void staffGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == staffGrid.Columns[4].Index && e.RowIndex >= 0)
            {
                if (confirmDeleteStaff())
                {
                    deleteStaff();
                }
               
            }
        }

        private void deleteStaff()
        {
            Staff stf = getSelectedStaff();
            try
            {
                SqlConnection conn = db.getConnection();
                String query = "delete from Staff where StaffID = @StaffID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@StaffID", SqlDbType.Int).Value = Convert.ToInt32(stf.id);
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        showDeleteStaffSuccessMessage();
                        loadStaffAccount();
                    }
                    else
                    {
                        ShowDeleteStaffErrorMessage();
                    }
                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void showDeleteStaffSuccessMessage()
        {
            MessageBox.Show("Deleted!");
        }

        private void ShowDeleteStaffErrorMessage()
        {
            MessageBox.Show("Delete error!");
        }

        private LaunryManager.Staff getSelectedStaff()
        {
            int id;
            String staffName, account, password;
            int rowindex = staffGrid.CurrentCell.RowIndex;
            id = Convert.ToInt32(staffGrid.Rows[rowindex].Cells[0].Value.ToString());
            staffName = staffGrid.Rows[rowindex].Cells[1].Value.ToString(); ;
            account = staffGrid.Rows[rowindex].Cells[2].Value.ToString();
            password = staffGrid.Rows[rowindex].Cells[3].Value.ToString();
            Staff stf = new Staff(id,staffName,account,password);
            return stf;
        }

        private Boolean confirmDeleteStaff()
        {
            LaunryManager.Staff stf = getSelectedStaff();
            DialogResult dr = MessageBox.Show("Are you sure to delete staff "+stf.staffName+"?", "Confirm delele", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
