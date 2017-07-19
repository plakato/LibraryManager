using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.BookDetails
{
    public partial class BookAdminForm : MetroForm
    {
        DatabaseModels.User user;
        DatabaseModels.Book book;

        public BookAdminForm(DatabaseModels.User user, DatabaseModels.Book book)
        {
            InitializeComponent();
        }

        private void BookAdminForm_Load(object sender, EventArgs e)
        {
            LTitle.Text = book.Title;
            LAuthor.Text = book.Author;
            LISBN.Text = book.ISBN;
            LPublicationYear.Text = book.PublicationYear.ToString();
            LPublisher.Text = book.Publisher;
            LPageCount.Text = book.NumberOfPages.ToString();
            LCategory.Text = string.Join(",", book.Category_Books.Select(cb => cb.Category.Name));
            LSection.Text = book.Section;
            LStatus.Text = book.GetStatus();
        }

        private void BEditBookDetail_Click(object sender, EventArgs e)
        {
            if (BEditBookDetail.Text == "Editovať")
            {
                BEditBookDetail.Text = "Uložiť";
                SetFormEditMode();
            } else
            {
                BEditBookDetail.Text = "Editovať";
                SaveFormToDatabase();
            }
        }

        private void SetFormEditMode()
        {

        }

        private void SaveFormToDatabase()
        {

        }
    }
}
