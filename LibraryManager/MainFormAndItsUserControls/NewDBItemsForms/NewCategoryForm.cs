using MetroFramework.Forms;
using System.Windows.Forms;

namespace LibraryManager
{
    // Form to enter new category name.
    public partial class NewCategoryForm : MetroForm
    {
        public NewCategoryForm()
        {
            InitializeComponent();
        }

        public string getText()
        {
            return TBCategoryName.Text;
        }

        private void BCreate_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void TBCategoryName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BCreate_Click(sender, e);
            }
        }
    }
}
