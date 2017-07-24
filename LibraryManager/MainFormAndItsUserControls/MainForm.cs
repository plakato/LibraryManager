using LibraryManager.BookDetails;
using LibraryManager.DatabaseModels;
using LibraryManager.MainFormAndItsUserControls;
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

            using (var scope = new DataAccessScope())
            {
                db = MainDatabase.getInstance();
                var book = db.Books.Create();
                var copy = db.Copies.Create();
                copy.Book = book;
                var user = db.Users.Create();
                user.Login = "meno";
                scope.Complete();

            }
            using (var scope = new DataAccessScope())
            {
                var loan = db.Loans.Create();
                loan.Copy = db.Copies.First();
                loan.Who = db.Users.First();
                scope.Complete();
            }

            User u = db.Users.GetReference("meno");
            Console.WriteLine("user.loans.first.copy.book = " + u.Loans.First().Copy.Book);
        }

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
                case Screen.Admin:
                    goto case Screen.User;
            }
        }  
    }
}
