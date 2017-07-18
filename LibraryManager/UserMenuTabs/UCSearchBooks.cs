﻿using System;
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

namespace LibraryManager
{
    public partial class UCSearchBooks : MetroUserControl
    {
        const int OLDEST_YEAR = 1970;
        const int MAX_PAGE_COUNT = 5000;
        DatabaseModels.MainDatabase db = DatabaseModels.MainDatabase.getInstance();
        public UCSearchBooks()
        {
            InitializeComponent();
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

        private void BSearch_Click(object sender, EventArgs e)
        {
            LVResults.Items.Clear();

            var results = db.Books.Where(book => book.Title.Contains(TBTitle.Text));
            results = results.Where(book => book.Author.Contains(TBAuthor.Text));
            results = results.Where(book => book.ISBN.Contains(TBisbn.Text));
            results = results.Where(book => book.Section.Contains(TBSector.Text));
            results = results.Where(book => CBCategory.Text==""? true:(book.Category_Books.Where(cat_book => cat_book.Category.Name == CBCategory.Text).Any()));
            results = results.Where(book => book.Publisher == CBPublisher.Text || CBPublisher.Text =="");
            results = results.Where(book => book.PublicationYear >= int.Parse(CBPublicationYearFrom.Text));
            results = results.Where(book => book.PublicationYear <= int.Parse(CBPublicationYearTo.Text));
            results = results.Where(book => book.NumberOfPages >= int.Parse(CBPageCountFrom.Text));
            results = results.Where(book => book.NumberOfPages <= int.Parse(CBPageCountTo.Text));

            /* var results = await db.Books.Where(book => book.Title.Contains(TBTitle.Text) &&
                                                 book.Author.Contains(TBAuthor.Text) &&
                                                 book.ISBN.Contains(TBisbn.Text) &&
                                                 book.Section.Contains(TBSector.Text) &&
                                                 CBCategory.Text==""? true:(book.Category_Books.Where(cat_book => cat_book.Category.Name == CBCategory.Text).Any()) &&
                                                 (book.Publisher == CBPublisher.Text || CBPublisher.Text =="") &&
                                                 book.PublicationYear >= int.Parse(CBPublicationYearFrom.Text) && 
                                                 book.PublicationYear <= int.Parse(CBPublicationYearTo.Text) &&
                                                 book.NumberOfPages >= int.Parse(CBPageCountFrom.Text) &&
                                                 book.NumberOfPages <= int.Parse(CBPageCountTo.Text)).ToListAsync();*/
            foreach (DatabaseModels.Book book in results)
            {
                String status = GetStatus(book);
                ListViewItem item = new ListViewItem(new string[]{book.ISBN, book.Title, book.Author, status});
                LVResults.Items.Add(item);
            }
            LVResults.Visible = true;
        }

        private string GetStatus(DatabaseModels.Book book)
        {
            int onLoan = 0;
            int reserved = 0;
            int free = 0;
            int copies = book.Copies.Count();

            foreach (DatabaseModels.Copy copy in book.Copies)
            {
                if (copy.Loans.Where(loan => loan.Active == true).Any())
                {
                    onLoan++;
                } else 
                if (copy.Reservations.Where(res => res.Active == true).Any())
                {
                    reserved++;
                } else
                {
                    free++;
                }
            }

            if (onLoan >= copies)
            {
                return $"Požičaná({onLoan}/{copies})";
            }
            else if (reserved >= copies)
            {
                return $"Rezervovaná({reserved}/{copies})";
            }
            else
            {
                return $"Voľná({free}/{copies})";
            }
            
        }

        private void LVResults_ItemAdded(MetroListView obj)
        {
            for (int i = 0; i < LVResults.Columns.Count; i++)
            {
                LVResults.Columns[i].Width = -2;
            }
        }

        private void LVResults_Resize(object sender, EventArgs e)
        {
            LVResults.Columns[LVResults.Columns.Count - 1].Width = -2;
        }

        private void LVResults_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = LVResults.SelectedItems[0];
            DatabaseModels.User user = ((MainFormAndItsUserControls.UCUserMenu)Parent).user;
            if (user.Admin)
            {
                string ISBN = item.SubItems["ISBNColumn"].Text;
                BookDetails.BookAdminForm form = new BookDetails.BookAdminForm(user, db.Books.GetReference(ISBN));

            }
        }
    }
}
