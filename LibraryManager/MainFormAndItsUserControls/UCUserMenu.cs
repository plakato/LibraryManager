﻿using System;
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
            if (user.Admin)
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
            UCSearchBooks ucSearchBooks = new UCSearchBooks(user);
            ucSearchBooks.Dock = DockStyle.Fill;
            page.Controls.Add(ucSearchBooks);
            TCUserMenu.TabPages.Add(page);

            //TODO: Moje vypozicky
        }

        private void AddAdminTabs()
        {
            MetroTabPage page = new MetroTabPage();
            page.Dock = DockStyle.Fill;
            page.Text = "Nájdi knižku";
            UCSearchBooks ucSearchBooks = new UCSearchBooks(user);
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
            UCAddNewUser ucUser = new UCAddNewUser(user.Login);
            ucUser.Dock = DockStyle.Fill;
            page.Controls.Add(ucUser);
            TCUserMenu.TabPages.Add(page);

        }
    }
}
