﻿
using MetroFramework.Controls;
using Shaolinq;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class UCAddNewUser : MetroUserControl
    {
        DatabaseModels.MainDatabase db = DatabaseModels.MainDatabase.getInstance();

        public UCAddNewUser()
        {
            InitializeComponent();
        }

        private void TBLogin_Validating(object sender, CancelEventArgs e)
        {
            var sameLogin = from user in db.Users
                            where user.Login == TBLogin.Text select TBLogin;
            if (sameLogin.Count() != 0)
            {
                errorProvider.SetError(TBLogin, "Užívateľ s týmto loginom už existuje.");
                return;
            } else
            {
                errorProvider.SetError(TBLogin, null);
            }
        }

        private void TBPasswordCheck_Validating(object sender, CancelEventArgs e)
        {
            if (TBPassword.Text != TBPasswordCheck.Text)
            {
                errorProvider.SetError(TBPasswordCheck, "Zadané heslá sa nezhodujú!");
            } else
            {
                errorProvider.SetError(TBPasswordCheck, null);
            }
        }

        private void BAddUser_Click(object sender, System.EventArgs e)
        {
            if (!isFormValid())
            {
                return;
            }

            using (var scope = new DataAccessScope())
            {
                var user = db.Users.Create();
                user.Name = TBName.Text;
                user.Login = TBLogin.Text;
                user.Password = TBPassword.Text;
                user.Admin = TAdminRights.Checked;

                scope.Complete();
            }
            MetroFramework.MetroMessageBox.Show(this, "Užívateľ " + TBName.Text + " bol úspešne pridaný.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateUsersList();
        }

        private bool isFormValid()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox && ((TextBox)control).Text == "")
                {
                    Lwarning.Text = "Všetky položky musia byť vyplnené.";
                    Lwarning.Visible = true;
                    return false;
                }
                else if (errorProvider.GetError(control) !=  "")
                {
                    Lwarning.Text = "Niektorá z položiek je chybne vyplnená.";
                    Lwarning.Visible = true;
                    return false;
                }
                
            }

            Lwarning.Visible = false;
            return true;
        }

        private void UCAddNewUser_Load(object sender, System.EventArgs e)
        {
            
            UpdateUsersList();
        }

        private void UpdateUsersList()
        {
            var users = db.Users;
            // Clear columns
            GVUsers.Rows.Clear();
            foreach (DatabaseModels.User user in users)
            {                
                GVUsers.Rows.Add(user.Name, user.Login, user.Admin);
            }
        }

        private async void DeleteUserAsync(string login)
        {
            using (var scope = new DataAccessScope())
            {
                await db.Users.Where(u => u.Login == login).DeleteAsync();
                scope.Complete();
            }
            UpdateUsersList();
            ClearNewUserForm();
        }

        private void GVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GVUsers.Columns[e.ColumnIndex].Name == "DeleteUser")
            {
                string loginToDelete = GVUsers["Login", e.RowIndex].Value.ToString();
                DeleteUserAsync(loginToDelete);
            }
        }

        private void ClearNewUserForm()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }
    }
}
