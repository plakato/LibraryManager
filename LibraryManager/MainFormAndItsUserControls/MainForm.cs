using MetroFramework.Forms;
using Shaolinq;
using Shaolinq.MySql;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class MainForm : MetroForm
    {
        static TableLayoutPanel mainPanel;
        static Panel logInLogOutPanel;
        private DatabaseModels.MainDatabase model;
        public MainForm()
        {
            InitializeComponent();
            
            // Create database if not exists => on the first run of the application
            DatabaseModels.MainDatabase.Initialize();
            model = DatabaseModels.MainDatabase.getInstance();
            mainPanel = PMainPanel;
            logInLogOutPanel = PLogInLogOut;
            using (var scope = new DataAccessScope())
             {
                 var admin = model.Users.Create();

                 admin.Name = "";
                 admin.Login = "admin";
                 admin.Password = "admin";
                 admin.Admin = true;

                 scope.Complete();
             }
        }

        public static void SwitchUserControls(Screen screen, DatabaseModels.User user)
        {
            mainPanel.Controls.Clear();
            logInLogOutPanel.Controls.Clear();
            UserControl ucmain;
            switch (screen)
            {
                case Screen.Welcome:
                    UCLogedOut ucLogedOut = new UCLogedOut();
                    ucLogedOut.Location = new System.Drawing.Point(logInLogOutPanel.Width - ucLogedOut.Width, 0);
                    ucLogedOut.Anchor = AnchorStyles.Right;
                    logInLogOutPanel.Controls.Add(ucLogedOut);

                    ucmain = new UCWelcome();
                    ucmain.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(ucmain,0,1);
                    break;
                case Screen.User:
                    UCLogedIn uclogin = new UCLogedIn();
                    uclogin.Location = new System.Drawing.Point(logInLogOutPanel.Width - uclogin.Width, 0);
                    uclogin.Anchor = AnchorStyles.Right;
                    uclogin.ChangeLoginText(user.Login);
                    logInLogOutPanel.Controls.Add(uclogin);

                    ucmain = new UCUserMenu();
                    ucmain.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(ucmain, 0,1);
                    break;
                case Screen.Admin:
                    goto case Screen.User;
            }
        }


        private void BSignIn_Click(object sender, EventArgs e)
        { 
        }

   
    }
}
