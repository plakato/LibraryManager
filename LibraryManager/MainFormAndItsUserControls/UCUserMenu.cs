using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using LibraryManager.UserMenuTabs;
using LibraryManager.DatabaseModels;

namespace LibraryManager.MainFormAndItsUserControls
{
    public partial class UCUserMenu : UserControl
    {
        internal string login;
        private const string MY_LOANS_AND_RESERVATIONS = "Moje výpožičky a rezervácie";
        public UCUserMenu(string login, bool admin)
        {
            InitializeComponent();
            this.login = login;
            if (admin)
            {
                AddAdminTabs();
            } else
            {
                AddUserTabs();
            }

        }

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

            page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Klucove slova";
            UCKeywords uck = new UCKeywords();
            uck.Dock = DockStyle.Fill;
            page.Controls.Add(uck);
            TCUserMenu.TabPages.Add(page);
        }

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
