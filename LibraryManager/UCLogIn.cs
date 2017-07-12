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
    public partial class UCLogIn : UserControl
    {
        public UCLogIn()
        {
            InitializeComponent();
        }

        private void BSignIn_Click(object sender, EventArgs e)
        {
            
            String login = TBLogin.Text;
            String password = TBPassword.Text;

            DatabaseModels.MainDatabase model = DatabaseModels.MainDatabase.getInstance();

            var user = model.Users.Where(u => u.Login == login).ToList();

            // Check whether user exists.
            if (user.Count == 0)
            {
                Lwarning.Text = "Užívateľ s týmto loginom neexistuje.";
                Lwarning.Visible = true;
                return;
            }

            // Check password.
            if (user.First().Password != password)
            {
                TBPassword.Text = "";
                Lwarning.Text = "Zadali ste nesprávne heslo.";
                Lwarning.Visible = true;
                return;
            }

        }
    }
}
