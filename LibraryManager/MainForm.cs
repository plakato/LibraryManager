using MetroFramework.Forms;
using Shaolinq;
using Shaolinq.MySql;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class WelcomeScreen : MetroForm
    {
        private DatabaseModels.MainDatabase model;
        public WelcomeScreen()
        {
            InitializeComponent();
            
            // Create database if not exists => on the first run of the application
            DatabaseModels.MainDatabase.Initicialize();
            model = DatabaseModels.MainDatabase.getInstance();

            UCWelcome welcome = new UCWelcome();
            UCLogIn logIn = new UCLogIn();

            /* using (var scope = new DataAccessScope())
             {
                 var admin = model.Users.Create();

                 admin.Name = "";
                 admin.Login = "admin";
                 admin.Password = "admin";
                 admin.Admin = true;

                 scope.Complete();
             }*/
        }

        private void BSignIn_Click(object sender, EventArgs e)
        {
        }

    }
}
