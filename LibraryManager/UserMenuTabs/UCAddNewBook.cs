using MetroFramework.Controls;
using Shaolinq;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class UCAddNewBook : MetroUserControl
    {
        DatabaseModels.MainDatabase db;
        const string NEW_CATEGORY = "Nová kategória";
        const string ADD_PUBLISHER = "Pridať vydavateľstvo";

        public UCAddNewBook()
        {
            InitializeComponent();
        }

        private void UCAddNewBook_Load(object sender, System.EventArgs e)
        {
            db = DatabaseModels.MainDatabase.getInstance();

            TBTitle.Select();

            var categories = (from c in db.Categories select c.Name).Distinct();
            foreach (var c in categories)
            {
                CBCategory.Items.Add(c);
            }
            CBCategory.Items.Add(NEW_CATEGORY);

            var publishers = (from book in db.Books select book.Publisher).Distinct().OrderBy(x => x);
            foreach (var pub in publishers)
            {
                CBPublisher.Items.Add(pub);
            }
            CBPublisher.Items.Add(ADD_PUBLISHER);

        }

        private void CBCategory_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            if (CBCategory.SelectedItem.ToString() == NEW_CATEGORY)
            {
                NewCategoryForm ncf = new NewCategoryForm();
                DialogResult result = ncf.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        string newCateg = ncf.getText();
                        CBCategory.Items.Add(newCateg);
                        CBCategory.SelectedItem = newCateg;
                        using (var scope = new DataAccessScope())
                        {
                            var category = db.Categories.Create();
                            category.Name = newCateg;
                            scope.Complete();
                        }
                        break;
                    default:
                        CBCategory.SelectedItem = null;
                        break;
                }
            }
        }

        private void CBPublisher_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            if (CBPublisher.SelectedItem.ToString() == ADD_PUBLISHER)
            {
                NewPublisherForm npf = new NewPublisherForm();
                DialogResult result = npf.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        string newPub = npf.getPublisherName();
                        CBPublisher.Items.Add(newPub);
                        CBPublisher.SelectedItem = newPub;
                        break;
                    default:
                        CBPublisher.SelectedItem = null;
                        break;
                }
            }
        }

        private void TBPublicationYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TBPublicationYear.Text == "")
            {
                errorProvider.SetError(TBPublicationYear, "Musíte zadať rok vydania!");
            }
            if (TBPublicationYear.Text.Length == 4 && int.TryParse(TBPublicationYear.Text, out int i))
            {
                errorProvider.SetError(TBPublicationYear, null);
            }
            else
            {
                errorProvider.SetError(TBPublicationYear, "Rok vydania nie je validný.");
            }
        }

        private void TBPageCount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(TBPageCount.Text, out int i))
            {
                errorProvider.SetError(TBPageCount, "Počet strán musí byť číslo!");
            }
            else
            {
                errorProvider.SetError(TBPageCount, null);
            }
        }

        private void TBisbn_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!long.TryParse(TBisbn.Text, out long i) ||
                (TBisbn.Text.Length != 10 &&
                 TBisbn.Text.Length != 13))
            {
                errorProvider.SetError(TBisbn, "Zadané ISBN nie je validné!");
            } else
            if (db.Books.Where(book => book.ISBN == TBisbn.Text).Any())
            {
                errorProvider.SetError(TBisbn, "Kniha s týmto ISBN už existuje!");
            }
            else
            {
                errorProvider.SetError(TBisbn, null);
            }
        }

        private void BAddNewBook_Click(object sender, System.EventArgs e)
        {
            if (AllValuesSetProperly())
            {
                using (var scope = new DataAccessScope())
                {
                    var book = db.Books.Create();
                    book.Title = TBTitle.Text;
                    book.Author = TBAuthor.Text;
                    book.ISBN = TBisbn.Text;
                    book.Section = TBSector.Text;
                    book.NumberOfPages = int.Parse(TBPageCount.Text);
                    book.PublicationYear = int.Parse(TBPublicationYear.Text);
                    book.Publisher = CBPublisher.SelectedText;

                    var cat_book = db.Category_Book.Create();
                    cat_book.Book = book;
                    cat_book.Category = (from cat in db.Categories
                                         where cat.Name == CBCategory.Text select cat).First();

                    int numberOfCopies = int.Parse(TBNumberOfCopies.Text);
                    for (int i = 0; i < numberOfCopies; i++)
                    {
                        var copy = db.Copies.Create();
                        copy.Book = book;
                    }
                    scope.Complete();
                }
                ClearForm();
                MetroFramework.MetroMessageBox.Show(this, "Nová kniha bola úspešne pridaná.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private bool AllValuesSetProperly()
        {
            if (TBTitle.Text == "" ||
                TBAuthor.Text == "" ||
                TBisbn.Text == "" ||
                TBSector.Text == "" ||
                CBCategory.SelectedItem == null ||
                CBPublisher.SelectedItem == null ||
                TBPublicationYear.Text == "" ||
                TBPageCount.Text == "")
            {
                Lwarning.Text = "Musíte vyplniť všetky informácie!";
                Lwarning.Visible = true;
                return false;
            }

            if (errorProvider.GetError(TBisbn) != "" ||
                errorProvider.GetError(TBPageCount) != "" ||
                errorProvider.GetError(TBPublicationYear) != "" ||
                errorProvider.GetError(TBNumberOfCopies) != "")
            {
                Lwarning.Text = "Niektorá hodnota nebola správne zadaná!";
                Lwarning.Visible = true;
                return false;
            }
            Lwarning.Visible = false;
            return true;
        }

        private void ClearForm()
        {
            TBTitle.Text = "";
            TBAuthor.Text = "";
            TBisbn.Text = "";
            TBSector.Text = "";
            CBCategory.SelectedItem = null;
            CBPublisher.SelectedItem = null;
            TBPublicationYear.Text = "";
            TBPageCount.Text = "";
        }

        private void TBNumberOfCopies_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(TBNumberOfCopies.Text, out int i))
            {
                errorProvider.SetError(TBNumberOfCopies, "Musí byť číslená hodnota.");
            }
            else
            {
                errorProvider.SetError(TBNumberOfCopies, null);
            }
        }
    }
}
