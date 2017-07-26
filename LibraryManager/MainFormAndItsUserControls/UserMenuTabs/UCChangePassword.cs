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
using Shaolinq;

namespace LibraryManager.UserMenuTabs
{
    // UC to change password of the current user.
    public partial class UCChangePassword : MetroUserControl
    {
        string login;
        DatabaseModels.User user;
        DatabaseModels.MainDatabase db = DatabaseModels.MainDatabase.getInstance();
        public UCChangePassword(string login)
        {
            this.login = login;
            user = db.Users.GetReference(login);
            InitializeComponent();
        }

        private void TBOriginalPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TBOriginalPassword.Text != user.Password)
            {
                errorProvider.SetError(TBOriginalPassword, "Zadané heslo sa nezhoduje s pôvodným.");
            } else
            {
                errorProvider.SetError(TBOriginalPassword, null);
            }
        }

        private void TBNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TBNewPassword.Text != TBNewPasswordCheck.Text)
            {
                errorProvider.SetError(TBNewPassword, "Nové heslo sa nezhoduje.");
            } else
            {
                errorProvider.SetError(TBNewPassword, null);
            }
        }

        private async void BChangePassword_Click(object sender, EventArgs e)
        {
            if (TBOriginalPassword.Text == "" ||
                TBNewPassword.Text == "" ||
                TBNewPasswordCheck.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Musíte vyplniť všetky polia.", "Pozor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Control c in TLPWithTextBoxes.Controls)
            {
                if (errorProvider.GetError(c) != "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Niektoré z polí nie je správne vyplnené!", "Uups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DatabaseModels.MainDatabase db = DatabaseModels.MainDatabase.getInstance();
            using (var scope = new DataAccessScope())
            {
                var u = db.Users.GetReference(user.Login);
                u.Password = TBNewPassword.Text;
                await scope.CompleteAsync();
            }
            TBOriginalPassword.Text = "";
            TBNewPassword.Text = "";
            TBNewPasswordCheck.Text = "";
            MetroFramework.MetroMessageBox.Show(this, "Vaše heslo bolo úspešne zmenené!", "Hurá", MessageBoxButtons.OK, MessageBoxIcon.Question);
            user = db.Users.GetReference(login);
        }
    }
}
