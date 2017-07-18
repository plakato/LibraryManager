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

namespace LibraryManager.MainFormAndItsUserControls
{
    public partial class UCUserMenu : UserControl
    {
        internal DatabaseModels.User user;
        public UCUserMenu(DatabaseModels.User user)
        {
            InitializeComponent();
            this.user = user;
            AddUserTabs();

        }

        private void AddUserTabs()
        {
            MetroTabPage page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Nová kniha";
            UCAddNewBook uc = new UCAddNewBook();
            uc.Dock = DockStyle.Fill;
            page.Controls.Add(uc);
            TCUserMenu.TabPages.Add(page);

            page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Nový užívateľ";
            UCAddNewUser ucUser = new UCAddNewUser();
            ucUser.Dock = DockStyle.Fill;
            page.Controls.Add(ucUser);
            TCUserMenu.TabPages.Add(page);

            page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Nájdi knižku";
            UCSearchBooks ucSearchBooks = new UCSearchBooks(); 
            ucSearchBooks.Dock = DockStyle.Fill;
            page.Controls.Add(ucSearchBooks);
            TCUserMenu.TabPages.Add(page);
        }
    }
}
