
using Shaolinq;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class UCAddNewUser : UserControl
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
            if (isFormValid())
            {
                using (var scope = new DataAccessScope())
                {
                    var user = db.Users.Create();
                    user.Name = TBName.Text;
                    user.Login = TBLogin.Text;
                    user.Password = TBPassword.Text;
                    user.Admin = TAdminRights.Checked;

                    scope.Complete();
                }
            }
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
                if (errorProvider.GetError(control) ==  "")
                {
                    Lwarning.Text = "Niektorá z položiek je chybne vyplnená.";
                    Lwarning.Visible = true;
                    return false;
                }
                
            }

            Lwarning.Visible = false;
            return true;
        }
    }
}
