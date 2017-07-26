using LibraryManager.UserMenuTabs;
using MetroFramework.Controls;
using Shaolinq;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManager
{
    // UC for creating new book.
    public partial class UCAddNewBook : MetroUserControl
    {
        DatabaseModels.MainDatabase db;
        const string NEW_CATEGORY = "Nová kategória";
        const string ADD_PUBLISHER = "Pridať vydavateľstvo";
        UCKeywords uck;

        public UCAddNewBook()
        {
            InitializeComponent();
            uck = new UCKeywords(true);     
            TLPAddNewBook.Controls.Add(uck, 0, 5);
            TLPAddNewBook.SetColumnSpan(uck, 5);
            uck.Dock = DockStyle.Fill;
        }

        // Loads categories and publishers to comboboxes.
        private void UCAddNewBook_Load(object sender, System.EventArgs e)
        {
            db = DatabaseModels.MainDatabase.getInstance();

            var categories = (from c in db.Categories select c.Name).Distinct().OrderBy(x => x);
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

        // When user clicks NEW_CATEGORY opens dialog and saves new category to database.
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

        // When user clicks ADD_PUBLISHER opens dialog and saves new publisher.
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

        // Publication year must have 4 digits and later than 1970 - otherwise no ISBN :(
        private void TBPublicationYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TBPublicationYear.Text == "")
            {
                errorProvider.SetError(TBPublicationYear, "Musíte zadať rok vydania!");
            }
            else if (TBPublicationYear.Text.Length != 4 || !int.TryParse(TBPublicationYear.Text, out int i))
            {
                errorProvider.SetError(TBPublicationYear, "Rok musí byť 4-miestne číslo.");
            } 
            else if (i < 1970)
            {
                errorProvider.SetError(TBPublicationYear, "Rok musí byť väčší než 1970.");

            }
            else 
            {
                errorProvider.SetError(TBPublicationYear, null);
            }
        }

        // Page count must be a number.
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

        // ISBN must have 10 or 13 digits.
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

        // Adds book to database.
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
                    book.Publisher = CBPublisher.SelectedItem.ToString();

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
                    foreach (string word in uck.GetSelected())
                    {
                        var keyword = db.Keywords.GetReference(word);
                        var keyw_book = db.Keyword_Book.Create();
                        keyw_book.Book = book;
                        keyw_book.Keyword = keyword;
                        
                    }
                    scope.Complete();
                }
                ClearForm();
                MetroFramework.MetroMessageBox.Show(this, "Nová kniha bola úspešne pridaná.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        // Checks for empty or invalid entries.
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
            uck.ClearSelected();
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
