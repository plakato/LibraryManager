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
        string currLogin;
        public UCAddNewUser(string login)
        {
            InitializeComponent();
            currLogin = login;
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
            ClearNewUserForm();
            UpdateUsersList();
        }

        private bool isFormValid()
        {
            foreach (Control control in TLPNewUser.Controls)
            {
                if (control is MetroTextBox && ((MetroTextBox)control).Text == "")
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
            // Clear columns
            GVUsers.Rows.Clear();
            foreach (DatabaseModels.User user in db.Users)
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
        }

        private void GVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GVUsers.Columns[e.ColumnIndex].Name == "DeleteUser")
            {
                string loginToDelete = GVUsers["Login", e.RowIndex].Value.ToString();
                if (loginToDelete == currLogin)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Tento užívateľ je práve prihlásený. Nemôžete ho zrušiť!", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show(this, $"Naozaj chcete odstrániť užívateľa {loginToDelete}?", "Odstrániť", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    DeleteUserAsync(loginToDelete);
                }
            }
        }

        private void ClearNewUserForm()
        {
            foreach (Control control in TLPNewUser.Controls)
            {
                if (control is MetroTextBox)
                {
                    ((MetroTextBox)control).Text = "";
                }
            }
            TAdminRights.Checked = false;
        }
    }
}
