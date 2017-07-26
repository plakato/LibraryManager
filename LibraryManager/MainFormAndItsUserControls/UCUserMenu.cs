using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using LibraryManager.UserMenuTabs;
using LibraryManager.DatabaseModels;

namespace LibraryManager.MainFormAndItsUserControls
{
    // UC displaying menu depending on user.
    public partial class UCUserMenu : UserControl
    {
        internal string login;
        private bool admin;
        private const string MY_LOANS_AND_RESERVATIONS = "Moje výpožičky a rezervácie";

        // Displays user or admin menu.
        public UCUserMenu(string login, bool admin)
        {
            InitializeComponent();
            this.login = login;
            this.admin = admin;
            if (admin)
            {
                AddAdminTabs();
            }
            else
            {
                AddUserTabs();
            }
        }

        // Adds tabs for user without admin rights.
        private void AddUserTabs()
        {
            MetroTabPage page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Nájdi knižku";
            UCSearchBooks ucSearchBooks = new UCSearchBooks(login);
            ucSearchBooks.Dock = DockStyle.Fill;
            page.Controls.Add(ucSearchBooks);
            TCUserMenu.TabPages.Add(page);

            page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = MY_LOANS_AND_RESERVATIONS;
            UCMyLoans ucMyLoans = new UCMyLoans(login);
            ucMyLoans.Dock = DockStyle.Fill;
            page.Controls.Add(ucMyLoans);
            TCUserMenu.TabPages.Add(page);

            page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Zmeniť heslo";
            UCChangePassword ucChangePassword = new UCChangePassword(login);
            ucChangePassword.Dock = DockStyle.Fill;
            page.Controls.Add(ucChangePassword);
            TCUserMenu.TabPages.Add(page);
        }

        // Adds tabs for admin.
        private void AddAdminTabs()
        {
            MetroTabPage page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Nájdi knižku";
            UCSearchBooks ucSearchBooks = new UCSearchBooks(login);
            ucSearchBooks.Dock = DockStyle.Fill;
            page.Controls.Add(ucSearchBooks);
            TCUserMenu.TabPages.Add(page);

            page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Nová kniha";
            UCAddNewBook uc = new UCAddNewBook();
            uc.Dock = DockStyle.Fill;
            page.Controls.Add(uc);
            TCUserMenu.TabPages.Add(page);

            page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Spravovať užívateľov";
            UCAddNewUser ucUser = new UCAddNewUser(login);
            ucUser.Dock = DockStyle.Fill;
            page.Controls.Add(ucUser);
            TCUserMenu.TabPages.Add(page);

            page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = MY_LOANS_AND_RESERVATIONS;
            UCMyLoans ucMyLoans = new UCMyLoans(login);
            ucMyLoans.Dock = DockStyle.Fill;
            page.Controls.Add(ucMyLoans);
            TCUserMenu.TabPages.Add(page);

            page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Zmeniť heslo";
            UCChangePassword ucChangePassword = new UCChangePassword(login);
            ucChangePassword.Dock = DockStyle.Fill;
            page.Controls.Add(ucChangePassword);
            TCUserMenu.TabPages.Add(page);
        }

        // Updates reservation table - because reservations may change during one user loged in.
        private void TCUserMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TCUserMenu.SelectedTab.Text == MY_LOANS_AND_RESERVATIONS)
            {
                foreach (Control c in TCUserMenu.SelectedTab.Controls)
                {
                    if (c is UCMyLoans)
                    {
                        User user = MainDatabase.getInstance().Users.GetReference(login);
                        ((UCMyLoans)c).UpdateReservationTable(user);
                    }
                }
            }
        }

    }
}
