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
    public partial class AddStaff : Form
    {
        databaseContext db = new databaseContext();
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveNewStaffHandler();
        }

        private void saveNewStaffHandler()
        {
            String staffName = txtStaffName.Text.ToString();
            String account = txtAccount.Text.ToString();
            String password = txtPassword.Text.ToString();
            if (validateFields(staffName, account, password))
            {
                if (checkAccountExist(account))
                {
                    createNewStaff(staffName, account, password);
                }
                else
                {
                    showAccountError();
                }
            }
        }

        private void resetField()
        {
            txtAccount.Text = "";
            txtStaffName.Text = "";
            txtPassword.Text = "";
        }

        private void createNewStaff(string staffName, string account, string password)
        {
            try
            {
                SqlConnection conn = db.getConnection();
                String query = "INSERT INTO Staff (staffName,account,password) VALUES (@staffName,@account, @password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@staffName", SqlDbType.NVarChar).Value = staffName;
                    cmd.Parameters.Add("@account", SqlDbType.NVarChar).Value = account;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        showSuccessMessage();
                        resetField();
                    }
                    else
                    {
                        ShowAddErrorMessage();
                    }
                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private static void ShowAddErrorMessage()
        {
            MessageBox.Show("Have an error when add new staff!");
        }

        private Boolean checkAccountExist(String account)
        {
            String query;
            int count = 0;
            SqlConnection conn = db.getConnection();
            query = "select * from Staff where account = '" + account + "'";
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

        private static void showSuccessMessage()
        {
            MessageBox.Show("New staff added!");
        }

        private static void showAccountError()
        {
            MessageBox.Show("This account is exist!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStaffName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveNewStaffHandler();
            }
        }

        private void txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveNewStaffHandler();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveNewStaffHandler();
            }
        }
    }
}
