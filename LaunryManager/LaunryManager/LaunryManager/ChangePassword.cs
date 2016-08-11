using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunryManager
{
    public partial class ChangePassword : Form
    {
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
            var account = Global.AccountName;
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
            throw new NotImplementedException();
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
