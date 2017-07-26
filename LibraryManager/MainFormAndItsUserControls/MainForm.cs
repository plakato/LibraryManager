using LibraryManager.DatabaseModels;
using LibraryManager.MainFormAndItsUserControls;
using MetroFramework.Forms;
using Shaolinq;
using System;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class MainForm : MetroForm
    {
        private static TableLayoutPanel mainPanel;
        private static Panel logInLogOutPanel;
        private DatabaseModels.MainDatabase db;
        private static string userLogin;
        public MainForm()
        {
            // Create database if not exists => on the first run of the application
            MainDatabase.Initialize();
            InitializeComponent();
            db = MainDatabase.getInstance();
            mainPanel = PMainPanel;
            logInLogOutPanel = PLogInLogOut;
            RemoveExpiredReservations();
        }

        // All revervations with duedate pass today are inactivated in the database.
        private async void RemoveExpiredReservations()
        {
            using(var scope = new DataAccessScope())
            {
                foreach (Reservation res in db.Reservations)
                {
                    if (res.Active && 0 >= DateTime.Compare(res.DueDate, DateTime.Now))
                    {
                        res.Active = false;
                    }
                }
                await scope.CompleteAsync();
            }
        }

        // Switches controls depending on screen requested. Admin and user are the same so far,
        // but can be differentiated if necessary (for future purposes).
        public static void SwitchUserControls(Screen screen, string login)
        {
            userLogin = login;
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
                case Screen.Admin:
                case Screen.User:
                    UCLogedIn uclogin = new UCLogedIn();
                    uclogin.SetLoginText(userLogin);
                    uclogin.Location = new System.Drawing.Point(logInLogOutPanel.Width - uclogin.Width, 0);
                    uclogin.Anchor = AnchorStyles.Right;
                    logInLogOutPanel.Controls.Add(uclogin);

                    bool admin = DatabaseModels.MainDatabase.getInstance().Users.GetReference(login).Admin;
                    ucmain = new UCUserMenu(userLogin, admin);
                    ucmain.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(ucmain, 0,1);
                    mainPanel.Refresh();
                    break;
            }
        }  
    }
}
