using LibraryManager.DatabaseModels;
using LibraryManager.UserMenuTabs;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Shaolinq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManager.BookDetails
{
    // It's display only to admin. Lets admin edit book info, 
    // loan/return/delete book copies and see/delete reservations for the book.
    public partial class BookAdminForm : MetroForm
    {
        MainDatabase db = MainDatabase.getInstance();
        string login;
        bool admin;
        Guid bookId;
        UCKeywords uck;
        // Constants used in tables and buttons.
        private const string LOAN = "Požičať";
        private const string RETURN = "Vrátiť";
        private const string EMPTY = "-";
        private const string EDIT = "Editovať";
        private const string SAVE = "Uložiť";
        private const string CANCEL = "Zrušiť";
        private const string DELETE = "Odstrániť";
        private const string NEW_CATEGORY = "Nová kategória";



        public BookAdminForm(string login, Guid bookId)
        {
            InitializeComponent();
            this.login = login;
            admin = db.Users.GetReference(login).Admin;
            this.bookId = bookId;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        // Loads book detailed info, its loans and reservations.
        private void BookAdminForm_Load(object sender, EventArgs e)
        {
            Book book = db.Books.GetReference(bookId);
            LTitle.Text = book.Title;
            LAuthor.Text = book.Author;
            LISBN.Text = book.ISBN;
            LPublicationYear.Text = book.PublicationYear.ToString();
            LPublisher.Text = book.Publisher;
            LPageCount.Text = book.NumberOfPages.ToString();
            LCategory.Text = string.Join(", ", book.Category_Books.Select(cb => cb.Category.Name));
            LSection.Text = book.Section;
            LCopyCount.Text = book.Copies.Count().ToString();
            LKeywords.Text = string.Join(", ", book.GetKeywords());

            UpdateLoanReturnTable(book);
            UpdateReservationTable(book);
        }

        // Updates table with copies, showing which copy is loaned/free
        // and provides button to loan/return/delete the copy.
        private void UpdateLoanReturnTable(Book book)
        {
            GVLoanReturn.Rows.Clear();
            foreach (Copy copy in book.Copies)
            {
                if (Copy.LOANED == copy.GetStatus())
                {
                    Loan loan = copy.Loans.Where(l => l.Active == true).First();
                    GVLoanReturn.Rows.Add(copy.Id, 
                                          copy.GetStatus(), 
                                          loan.Who.Name, 
                                          loan.Who.Login, 
                                          loan.When.ToString("dd/MM/yyyy"), 
                                          loan.UntilWhen.ToString("dd/MM/yyyy"), 
                                          RETURN, 
                                          loan.Id, 
                                          DELETE);
                }
                else
                {
                    GVLoanReturn.Rows.Add(copy.Id, 
                                          copy.GetStatus(), 
                                          EMPTY, 
                                          EMPTY, 
                                          EMPTY, 
                                          EMPTY, 
                                          LOAN, 
                                          EMPTY, 
                                          DELETE);
                }
            }
        }

        // Updates information in table with reservations. They are ordered by the time
        // they were issued.
        private void UpdateReservationTable(Book book)
        {
            GVResevations.Rows.Clear();
            int i = 1;
            foreach (Reservation res in book.Reservations.Where(r => r.Active == true).OrderBy(r => r.WhenIssued))
            {
                GVResevations.Rows.Add(i,res.Who.Name, res.DueDate.ToString("dd/MM/yyyy"), res.Count, res.ID, CANCEL);
                i++;
            }
        }

        // Switches between edit mode and display mode of book info.
        private void BEditBookDetail_Click(object sender, EventArgs e)
        {
            if (BEditBookDetail.Text == EDIT)
            {
                BEditBookDetail.Text = SAVE;
                SetFormEditMode();
            } else
            {
                SaveFormToDatabase();
            }
        }

        // Opens dialog to create new category and saves it to database.
        private void NewCategorySelected(ComboBox cb) 
        {
            if (cb.SelectedItem.ToString() == NEW_CATEGORY)
            {
                NewCategoryForm f = new NewCategoryForm();
                DialogResult result = f.ShowDialog(this);
                switch (result)
                {
                    case DialogResult.OK:
                        string cat = f.getText();
                        cb.Items.Add(cat);
                        cb.SelectedItem = cat;
                        using (var scope = new DataAccessScope())
                        {
                            var category = db.Categories.Create();
                            category.Name = cat;
                            scope.Complete();
                        }
                        break;                   
                    default:
                        cb.SelectedItem = null;
                        break;
                }
            }
        }

        // Replaces labels with textboxes to edit book info.
        private void SetFormEditMode()
        {
            int rows = TLPDetail.RowCount - 1;
            for (int i = 0; i < rows; i++)
            {
                var original = TLPDetail.GetControlFromPosition(1, i);
                var text = original.Text;
                TLPDetail.Controls.Remove(original);
                if (i == 6)
                {
                    ComboBox cb = GetCategoryComboBox();
                    TLPDetail.Controls.Add(cb, 1, i);
                    cb.SelectedItem = text;
                    cb.Margin = new Padding(5,5,5,5);
                    cb.SelectionChangeCommitted += (sender, e) => NewCategorySelected(cb);
                } else if (i == 9)
                {
                    uck = new UCKeywords(bookId, admin);
                    TLPDetail.Controls.Add(uck, 1, 9);
                    uck.Dock = DockStyle.Fill;
                } else
                {
                    MetroTextBox tb = new MetroTextBox();
                    tb.Size = new Size(120, 20);
                    tb.Theme = MetroFramework.MetroThemeStyle.Dark;
                    tb.Style = MetroFramework.MetroColorStyle.Red;
                    tb.Text = text;
                    TLPDetail.Controls.Add(tb, 1, i);
                }                    
            }            
        }

        // Replaces textboxes with labels with entered book info
        // and saves it to database.
        private async void SaveFormToDatabase()
        {
            if (EmptyBookInfo())
            {
                return;
            }

            string title =         TLPDetail.GetControlFromPosition(1, 0).Text;
            string author =        TLPDetail.GetControlFromPosition(1, 1).Text;
            string isbn =          TLPDetail.GetControlFromPosition(1, 2).Text;
            string pubYear =       TLPDetail.GetControlFromPosition(1, 3).Text;
            string publisher =     TLPDetail.GetControlFromPosition(1, 4).Text;
            string numberOfPages = TLPDetail.GetControlFromPosition(1, 5).Text;
            string category =      TLPDetail.GetControlFromPosition(1, 6).Text;
            string section =       TLPDetail.GetControlFromPosition(1, 7).Text;
            string copyCount =     TLPDetail.GetControlFromPosition(1, 8).Text;
            int rows = TLPDetail.RowCount - 1;

            if (!long.TryParse(isbn, out long m) || (isbn.Length != 10 && isbn.Length != 13))
            {
                MetroFramework.MetroMessageBox.Show(this, "Chybne zadané ISBN.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(pubYear, out int d) || pubYear.Length != 4)
            {
                MetroFramework.MetroMessageBox.Show(this, "Chybne zadaný rok vydania.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(numberOfPages, out int o))
            {
                MetroFramework.MetroMessageBox.Show(this, "Počet strán musí byť číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(copyCount, out int z) || z < db.Books.GetReference(bookId).Copies.Count())
            {
                MetroFramework.MetroMessageBox.Show(this, "Počet kópií musí byť číslo väčšie/rovné ako aktuálny počet kópií.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var scope = new DataAccessScope())
            {
                var book = db.Books.GetReference(bookId);
                book.Title = title;
                book.Author = author;
                book.ISBN = isbn;
                book.PublicationYear = int.Parse(pubYear);
                book.Publisher = publisher;
                book.NumberOfPages = int.Parse(numberOfPages);
                book.Section = section;
                for (int j = 0; j < int.Parse(copyCount) - book.Copies.Count(); j++)
                {
                    var copy = db.Copies.Create();
                    copy.Book = book;
                }
                await book.Category_Books.DeleteAsync();
                var cat = db.Categories.GetReference(category);
                var cat_book = db.Category_Book.Create();
                cat_book.Book = book;
                cat_book.Category = cat;
                await db.Books.GetReference(bookId).Keyword_Books.DeleteAsync();
                foreach (string word in uck.GetSelected())
                {
                    var keyword = db.Keywords.GetReference(word);
                    var keyw_book = db.Keyword_Book.Create();
                    keyw_book.Book = book;
                    keyw_book.Keyword = keyword;
                }
                UpdateLoanReturnTable(book);
                await scope.CompleteAsync();
            }
            for (int b = 0; b < rows; b++)
            {
               TLPDetail.Controls.Remove(TLPDetail.GetControlFromPosition(1, b));
            }
            MetroLabel t = new MetroLabel();
            MetroLabel a = new MetroLabel();
            MetroLabel i = new MetroLabel();
            MetroLabel y = new MetroLabel();
            MetroLabel p = new MetroLabel();
            MetroLabel n = new MetroLabel();
            MetroLabel c = new MetroLabel();
            MetroLabel s = new MetroLabel();
            MetroLabel cc = new MetroLabel();
            MetroLabel k = new MetroLabel();
            t.Text = title;
            a.Text = author;
            i.Text = isbn;
            y.Text = pubYear;
            p.Text = publisher;
            n.Text = numberOfPages;
            c.Text = category;
            s.Text = section;
            cc.Text = copyCount;
            k.Text = string.Join(", ", uck.GetSelected());
            List<MetroLabel> controlsToAdd = new List<MetroLabel>();
            controlsToAdd.Add(t);
            controlsToAdd.Add(a);
            controlsToAdd.Add(i);
            controlsToAdd.Add(y);
            controlsToAdd.Add(p);
            controlsToAdd.Add(n);
            controlsToAdd.Add(c);
            controlsToAdd.Add(s);
            controlsToAdd.Add(cc);
            controlsToAdd.Add(k);
            for (int j = 0; j < rows; j++)
            {
                controlsToAdd[j].Theme = MetroFramework.MetroThemeStyle.Dark;
                controlsToAdd[j].Style = MetroFramework.MetroColorStyle.Red;
                controlsToAdd[j].AutoSize = true;
                TLPDetail.Controls.Add(controlsToAdd[j], 1, j);
            }

            BEditBookDetail.Text = EDIT;
        }

        // Returnes combobox with all categories available in the database.
        private ComboBox GetCategoryComboBox()
        {
            MetroComboBox cb = new MetroComboBox();
            cb.Theme = MetroFramework.MetroThemeStyle.Dark;
            cb.Style = MetroFramework.MetroColorStyle.Red;
            cb.Margin = new Padding(5, 5, 5, 5);
            foreach (var cat in db.Categories.Select(c => c.Name).OrderBy(x => x))
            {
                cb.Items.Add(cat);
            }
            cb.Items.Add(NEW_CATEGORY);
            return cb;
        }

        // Checks wheter the book info entered by is empty.
        private bool EmptyBookInfo()
        {
            int rows = TLPDetail.RowCount - 1;
            // rows -1 => because the last one is keywords textbox - doesn't need to be filled.
            for (int i = 0; i < rows-1; i++)
            {
                var control = TLPDetail.GetControlFromPosition(1, i);
                if (control.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Musíte vyplniť všetky údaje!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }

        // Loans, deletes or returnes the book depending on where on the grid did user click.
        private void GVLoanReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GVLoanReturn.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int copyID = int.Parse(GVLoanReturn["IDColumn", e.RowIndex].Value.ToString());
                if (GVLoanReturn[e.ColumnIndex,e.RowIndex].Value.ToString() == DELETE)
                {
                    DeleteCopyAsync(copyID);
                } else
                {
                    if (GVLoanReturn[e.ColumnIndex,e.RowIndex].Value.ToString() == RETURN)
                    {
                        int loanID = int.Parse(GVLoanReturn["LoanIDColumn", e.RowIndex].Value.ToString());
                        ReturnCopy(copyID, loanID);
                    }
                    else if (GVLoanReturn[e.ColumnIndex, e.RowIndex].Value.ToString() == LOAN)
                    {
                        LoanCopy(copyID);
                    }
                    UpdateLoanReturnTable(db.Books.GetReference(bookId));
                }
                
            }
        }

        // Deletes the copy (or entire book if it's the very last copy)
        private async void DeleteCopyAsync(int copyID)
        {
            if (DialogResult.Yes != MessageBox.Show(this,"Naozaj chcete vymazať túto knižku/výtlačok?", "",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                return;
            }
            using (var scope = new DataAccessScope())
            {
                await db.Copies.Where(c => c.Id == copyID && c.Book.Id == bookId).DeleteAsync();
                //if it's the last copy - delete the book - else update
                Book book = db.Books.GetReference(bookId);
                if (book.Copies.Count() == 0)
                {
                    await db.Books.Where(b => b.Id == bookId).DeleteAsync();
                    Close();
                } else
                {
                    UpdateLoanReturnTable(book);
                }
                
                await scope.CompleteAsync();
            }
        }
        
        // Marks copy as returned
        private async void ReturnCopy(int copyID, int loanID)
        {
            try
            {
                using (var scope = new DataAccessScope())
                {
                    var loan = db.Loans.GetReference(loanID);
                    loan.Active = false; 
                    await scope.CompleteAsync();
                }
                MetroFramework.MetroMessageBox.Show(this, "Kniha bola úspešne vrátená.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Vyskytla sa chyba, knihu sa nepodario vrátiť.", "Uups", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Shows dialog to loan the copy
        private void LoanCopy(int copyid)
        {
            LoanCopyForm lcform = new LoanCopyForm(copyid, bookId); ;
            lcform.ShowDialog(this);
        }

        // If user clicked delete on grid - deletes the reservation
        private async void GVResevations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GVResevations.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int resID = int.Parse(GVResevations["ReservationIDColumn", e.RowIndex].Value.ToString());
                using (var scope = new DataAccessScope())
                {
                    var res = db.Reservations.GetReference(resID);
                    res.Active = false;
                    await scope.CompleteAsync();
                }
                UpdateReservationTable(db.Books.GetReference(bookId));
            }
        }
    }
}
