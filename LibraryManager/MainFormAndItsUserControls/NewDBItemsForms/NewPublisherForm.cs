using MetroFramework.Forms;
using System.Windows.Forms;

namespace LibraryManager
{
    // Forms to create new publisher.
    public partial class NewPublisherForm : MetroForm
    {
        public NewPublisherForm()
        {
            InitializeComponent();
        }

        public string getPublisherName()
        {
            return TBPublisherName.Text;
        }

        private void BAdd_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void TBPublisherName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BAdd_Click(sender, e);
            }
        }
    }
}
