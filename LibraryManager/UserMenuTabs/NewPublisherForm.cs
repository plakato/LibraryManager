using MetroFramework.Forms;

namespace LibraryManager
{
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
