using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Shaolinq;
using LibraryManager.DatabaseModels;
using LibraryManager.UserMenuTabs;

namespace LibraryManager
{
    public partial class UCSearchBooks : MetroUserControl
    {
        const int OLDEST_YEAR = 1970;
        const int MAX_PAGE_COUNT = 5000;
        MainDatabase db = MainDatabase.getInstance();
        string login;
        UCKeywords uck;
        public UCSearchBooks(string login)
        {
            InitializeComponent();
            this.login = login;
            uck = new UCKeywords();
            TLPConditions.Controls.Add(uck, 0, 4);
            TLPConditions.SetColumnSpan(uck, 5);
            uck.Dock = DockStyle.Fill;
        }

        private void UCSearchBooks_Load(object sender, EventArgs e)
        {
            var categories = (from c in db.Categories select c.Name).Distinct().OrderBy(x => x);
            foreach (var c in categories)
            {
                CBCategory.Items.Add(c);
            }

            var publishers = (from book in db.Books select book.Publisher).Distinct().OrderBy(x => x);
            foreach (var pub in publishers)
            {
                CBPublisher.Items.Add(pub);
            }

            int currYear = DateTime.Now.Year;
            for (int i = OLDEST_YEAR; i <= currYear; i++)
            {
                CBPublicationYearFrom.Items.Add(i);
                CBPublicationYearTo.Items.Add(i);
            }
            CBPublicationYearFrom.SelectedItem = OLDEST_YEAR;
            CBPublicationYearTo.SelectedItem = currYear;

            for (int i = MAX_PAGE_COUNT; i >= 0; i-=10)
            {
                CBPageCountFrom.Items.Add(i);
                CBPageCountTo.Items.Add(i);
            }
            CBPageCountFrom.SelectedItem = 0;
            CBPageCountTo.SelectedItem = MAX_PAGE_COUNT;
        }

        private async void BSearch_Click(object sender, EventArgs e)
        {
            LVResults.Items.Clear();

            var resultsWithoutKeywords = await db.Books.Where(book => book.Title.Contains(TBTitle.Text) &&
                                                 book.Author.Contains(TBAuthor.Text) &&
                                                 book.ISBN.Contains(TBisbn.Text) &&
                                                 book.Section.Contains(TBSector.Text) &&
                                                 CBCategory.Text == "" ? true : (book.Category_Books.Where(cat_book => cat_book.Category.Name == CBCategory.Text).Any()) &&
                                                 (book.Publisher == CBPublisher.Text || CBPublisher.Text == "") &&
                                                 book.PublicationYear >= int.Parse(CBPublicationYearFrom.Text) &&
                                                 book.PublicationYear <= int.Parse(CBPublicationYearTo.Text) &&
                                                 book.NumberOfPages >= int.Parse(CBPageCountFrom.Text) &&
                                                 book.NumberOfPages <= int.Parse(CBPageCountTo.Text))
                                                 .ToListAsync();
            var results = resultsWithoutKeywords.Where(book => BookHasAllKeywords(book));

            foreach (Book book in results)
            {
                String status = book.GetStatus();
                ListViewItem item = new ListViewItem(new string[]{book.ISBN, book.Title, book.Author, status});
                LVResults.Items.Add(item);
            }
            LVResults.Visible = true;
            // Resize grid to fit the content
            for (int i = 0; i < LVResults.Columns.Count; i++)
            {
                LVResults.Columns[i].Width = -2;
            }
        }

        private bool BookHasAllKeywords(Book book)
        {
            return !uck.GetSelected().Except(book.GetKeywords()).Any();
        }
        public void ClearResults()
        {
            LVResults.Items.Clear();
        }

        private void LVResults_Resize(object sender, EventArgs e)
        {
            LVResults.Columns[LVResults.Columns.Count - 1].Width = -2;
        }

        private void LVResults_ItemActivate(object sender, EventArgs e)
        {
            string ISBN = LVResults.SelectedItems[0].Text;
            if (!db.Books.Where(b => b.ISBN == ISBN).Any())
            {
                MetroFramework.MetroMessageBox.Show(this, "Táto kniha bola odstránená. Pre získanie výsledkov bez ostránených kníh prosím opakujte hľadanie.", "Kniha neexistuje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool admin = db.Users.GetReference(login).Admin;
            if (admin)
            {
                BookDetails.BookAdminForm form = new BookDetails.BookAdminForm(login, ISBN);
                form.Show(this);
            } else
            {
                BookDetails.BookUserForm uform = new BookDetails.BookUserForm(login, ISBN);
                uform.Show(this);
            }
        }
    }
}
