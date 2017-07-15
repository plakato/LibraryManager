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

        public void ChangeLoginText(String newLogin)
        {
            Llogin.Text = newLogin;
        }
    }
}
