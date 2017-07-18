using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class UCLogedIn : MetroUserControl
    {
        public UCLogedIn()
        {
            InitializeComponent();
        }

        public void SetLoginText(string login)
        {
            Llogin.Text = login;
        }

        private void BLogOut_Click(object sender, EventArgs e)
        {
            MainForm.SwitchUserControls(Screen.Welcome, null);
        }
    }
}
