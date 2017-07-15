using MetroFramework.Forms;

namespace LibraryManager
{
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

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void metroButton2_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
