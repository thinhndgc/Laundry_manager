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
    public partial class ChangePassword : Form
    {
        String account = Global.AccountName;
        databaseContext db = new databaseContext();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            setAccountName();
        }

        private void setAccountName()
        {
            accountName.Text = account;
        }

        private void btnChangePassoword_Click(object sender, EventArgs e)
        {
            changePasswordHandler();
        }

        private void changePasswordHandler()
        {
            currentPassErr.Visible = false;
            newPassErr.Visible = false;
            confirmPassErr.Visible = false;
            String currentPass = txtCurrentPassword.Text.ToString();
            String newPass = txtNewPassword.Text.ToString();
            String confirnPass = txtConfirmNewPassword.Text.ToString();
            if (validateField(currentPass, newPass, confirnPass))
            {
                checkConfirmPass(newPass, confirnPass);
            }
        }

        private void checkConfirmPass(string newPass, string confirnPass)
        {
            if (newPass.Equals(confirnPass))
            {
                checkCurrentPassword();
            }
            else
            {
                showConfirmPasswordErr();
            }
        }

        private void checkCurrentPassword()
        {
            String query;
            String currentPass = txtCurrentPassword.Text.ToString();
            String newPass = txtNewPassword.Text.ToString();
            int count = 0;
            SqlConnection conn = db.getConnection();
            query = "select * from Staff where account = '" + account + "' and password = '" + currentPass + "'";
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
                showOldPasswordErr();
            }
            else
            {
                changePass(newPass);
            }
        }

        private void resetField()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmNewPassword.Text = "";
        }

        private void changePass(string newPass)
        {
            SqlConnection conn = db.getConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "update Staff set password = '" + newPass + "' where account = '" + account + "'";
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                ShowSuccessMess();
                resetField();
            }
            else
            {
                ShowUpdatePasswordErr();
            }
            conn.Close();
        }

        private static void ShowUpdatePasswordErr()
        {
            MessageBox.Show("Have an error when change your password!");
        }

        private static void ShowSuccessMess()
        {
            MessageBox.Show("Your password is changed!");
        }

        private static void showOldPasswordErr()
        {
            MessageBox.Show("Your old password is not match!");
        }

        private void showConfirmPasswordErr()
        {
            MessageBox.Show("Two new password is not match!");
        }

        private Boolean validateField(string currentPass, string newPass, string confirnPass)
        {
            if (currentPass.Equals("") && newPass.Equals("") && confirnPass.Equals(""))
            {
                currentPassErr.Visible = true;
                newPassErr.Visible = true;
                confirmPassErr.Visible = true;
                return false;
            }
            else if (currentPass.Equals(""))
            {
                currentPassErr.Visible = true;
                return false;
            }
            else if (newPass.Equals(""))
            {
                newPassErr.Visible = true;
                return false;
            }
            else if (confirnPass.Equals(""))
            {
                confirmPassErr.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtCurrentPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changePasswordHandler();
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changePasswordHandler();
            }
        }

        private void txtConfirmNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changePasswordHandler();
            }
        }
    }
}
