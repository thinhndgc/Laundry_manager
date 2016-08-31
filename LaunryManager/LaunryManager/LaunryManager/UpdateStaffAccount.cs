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

namespace LaunryManager
{
    public partial class UpdateStaffAccount : Form
    {
        databaseContext db = new databaseContext();
        public UpdateStaffAccount()
        {
            InitializeComponent();
        }

        // Form load event
        private void UpdateStaffAccount_Load(object sender, EventArgs e)
        {
            setOldData();
        }

        // Set old staff data to text field
        private void setOldData()
        {
            txtAccount.Text = Global.St.account.ToString();
            txtStaffName.Text = Global.St.staffName.ToString();
            txtPassword.Text = Global.St.password.ToString();
        }

        // Update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateStaffHandler();
        }

        // Cancel button click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handle button Update click
        private void updateStaffHandler()
        {
            String staffName = txtStaffName.Text.ToString();
            String account = txtAccount.Text.ToString();
            String password = txtPassword.Text.ToString();
            int id = Global.St.id;
            if (validateFields(staffName, account, password))
            {
                if (checkAccountExist(account))
                {
                    updateStaff(id, staffName, account, password);
                }
                else
                {
                    showAccountError();
                }
            }
        }

        // Validate null value
        private Boolean validateFields(string staffName, string account, string password)
        {
            if (staffName.Equals("") && account.Equals("") && password.Equals(""))
            {
                nameErr.Visible = true;
                accountErr.Visible = true;
                passwordErr.Visible = true;
                return false;
            }
            else if (staffName.Equals(""))
            {
                nameErr.Visible = true;
                return false;
            }
            else if (account.Equals(""))
            {
                accountErr.Visible = true;
                return false;
            }
            else if (password.Equals(""))
            {
                passwordErr.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        // Check account exist
        private Boolean checkAccountExist(String account)
        {
            String query;
            int count = 0;
            String oldAccount = Global.St.account;
            SqlConnection conn = db.getConnection();
            query = "select * from Staff where account = '" + account + "' and account != '" + oldAccount + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                count = count + 1;
            }
            conn.Close();
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Update data
        private void updateStaff(int id, string staffName, string account, string password)
        {
            try
            {
                SqlConnection conn = db.getConnection();
                String query = "update Staff set staffName = @staffName,account = @account,password = @password where StaffID = @SID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@staffName", SqlDbType.NVarChar).Value = staffName;
                    cmd.Parameters.Add("@account", SqlDbType.NVarChar).Value = account;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                    cmd.Parameters.Add("@SID", SqlDbType.Int).Value = id;
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        showSuccessMessage();
                    }
                    else
                    {
                        ShowUpdateErrorMessage();
                    }
                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // add event to enter key
        private void txtStaffName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateStaffHandler();
            }
        }

        // add event to enter key
        private void txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateStaffHandler();
            }
        }

        // add event to enter key
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateStaffHandler();
            }
        }

        // Show message code start
        private void ShowUpdateErrorMessage()
        {
            MessageBox.Show("Have an error when update staff!");
        }

        private static void showSuccessMessage()
        {
            MessageBox.Show("Staff information is updated!");
        }

        private static void showAccountError()
        {
            MessageBox.Show("This account is exist!");
        }
        // Show message code end
    }
}
