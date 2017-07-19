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
        private DatabaseModels.MainDatabase model;
        private static DatabaseModels.User user;
        public MainForm()
        {
            DatabaseModels.MainDatabase.Initialize();
            InitializeComponent();
            
            // Create database if not exists => on the first run of the application
            model = DatabaseModels.MainDatabase.getInstance();
            mainPanel = PMainPanel;
            logInLogOutPanel = PLogInLogOut;
            using (var scope = new DataAccessScope())
             {
                 var admin = model.Users.Create();
                 admin.Name = "";
                 admin.Login = "admin";
                 admin.Password = "admin";
                 admin.Admin = false;

                var book = model.Books.Create();
                book.Title = "kniha";
                book.Author = "neznamy";
                book.ISBN = "7894561261";
                book.PublicationYear = 1999;
                book.Publisher = "company";
                book.Section = "3A";
                var copy = model.Copies.Create();
                copy.Book = book;
                var cat = model.Categories.Create();
                cat.Name = "beletria";
                var cat_book = model.Category_Book.Create();
                cat_book.Book = book;
                cat_book.Category = cat;

                 scope.Complete();
             }
        }

        public static void SwitchUserControls(Screen screen, DatabaseModels.User u)
        {
            user = u;
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
                    uclogin.SetLoginText(user.Login);
                    uclogin.Location = new System.Drawing.Point(logInLogOutPanel.Width - uclogin.Width, 0);
                    uclogin.Anchor = AnchorStyles.Right;
                    logInLogOutPanel.Controls.Add(uclogin);

                    ucmain = new UCUserMenu(user);
                    ucmain.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(ucmain, 0,1);
                    mainPanel.Refresh();
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
