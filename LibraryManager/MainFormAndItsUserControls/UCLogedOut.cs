using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class UCLogedOut : UserControl
    {
        DatabaseModels.MainDatabase db;
        public UCLogedOut()
        {
            InitializeComponent();
        }

        private void BSignIn_Click(object sender, EventArgs e)
        {
            String login = TBLogin.Text;
            String password = TBPassword.Text;

            db = DatabaseModels.MainDatabase.getInstance();
            var users = db.Users.Where(u => u.Login == login).ToList();

            // Check whether user exists.
            if (users.Count == 0)
            {
                Lwarning.Text = "Užívateľ s týmto loginom neexistuje.";
                Lwarning.Visible = true;
                return;
            }
            var user = users.First();
            // Check password.
            if (user.Password != password)
            {
                TBPassword.Text = "";
                Lwarning.Text = "Zadali ste nesprávne heslo.";
                Lwarning.Visible = true;
                return;
            }

            // Change screen
            if (user.Admin)
            {
                MainForm.SwitchUserControls(Screen.Admin, user.Login);
            } else
            {
                MainForm.SwitchUserControls(Screen.User,  user.Login);
            }
        }

        private void TBPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BSignIn_Click(sender, e);
            }
        }
    }
}
