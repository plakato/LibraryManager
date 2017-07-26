using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManager
{
    // UC with option to log in.
    public partial class UCLogedOut : UserControl
    {
        DatabaseModels.MainDatabase db;
        public UCLogedOut()
        {
            InitializeComponent();
        }

        // Checks data entered and switches to appropriate screen.
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

        // Enter works as button click as well.
        private void TBPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BSignIn_Click(sender, e);
            }
        }
    }
}
