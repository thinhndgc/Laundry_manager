using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LaunryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            String username = txtUsername.Text.ToString();
            String password = txtPassword.Text.ToString();
            if (loginValidate())
            {
                if (checkLogin(username, password))
                {
                    Main mainForm = new Main();
                    this.Visible = false;
                    mainForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid user!");
                }
            }
        }

        private Boolean checkLogin(String username, String password)
        {
            var db = new databaseContext();
            int count = 0;
            SqlConnection conn = db.getConnection();
            String query = "select * from Staff where account = '" + username + "'and password = '" + password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                count = count + 1;
            }
            if (count==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean loginValidate()
        {
            usernameErr.Visible = false;
            passwordErr.Visible = false;
            String username = txtUsername.Text.ToString();
            String password = txtPassword.Text.ToString();
            if (password.Equals("") && username.Equals(""))
            {
                usernameErr.Visible = true;
                passwordErr.Visible = true;
                return false;
            }
            else if (username.Equals(""))
            {
                usernameErr.Visible = true;
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

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
