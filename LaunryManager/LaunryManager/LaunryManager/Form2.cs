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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            createMenuBar();
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
            throw new NotImplementedException();
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
    }
}
