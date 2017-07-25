using LibraryManager.DatabaseModels;
using MetroFramework.Forms;
using Shaolinq;
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
    public partial class BookUserForm : MetroForm
    {
        MainDatabase db = MainDatabase.getInstance();
        string login;
        Guid bookId;

        public BookUserForm(string login, Guid bookId)
        {
            InitializeComponent();
            this.login = login;
            this.bookId = bookId;
        }

        private void BookUserForm_Load(object sender, EventArgs e)
        {
            Book book = db.Books.GetReference(bookId);
            LTitle.Text = book.Title;
            LAuthor.Text = book.Author;
            LISBN.Text = book.ISBN;
            LPublicationYear.Text = book.PublicationYear.ToString();
            LPublisher.Text = book.Publisher;
            LPageCount.Text = book.NumberOfPages.ToString();
            LCategory.Text = string.Join(",", book.Category_Books.Select(cb => cb.Category.Name));
            LSection.Text = book.Section;
            LStatus.Text = book.GetStatus();
            LKeywords.Text = string.Join(", ", book.GetKeywords());

            for (int i = 1; i <= book.Copies.Count(); i++)
            {
                CBCopiesCount.Items.Add(i);
            }
            CBCopiesCount.SelectedItem = 1;
        }

        private void BMakeReservation_Click(object sender, EventArgs e)
        {
            User user = db.Users.GetReference(login);
            Book book = db.Books.GetReference(bookId);
            if (user.Reservations.Where(res => res.Active && res.Book == book).Any())
            {
                MetroFramework.MetroMessageBox.Show(this, "Na túto knihu už máte rezerváciu. Môžete ju zrušiť v sekcii Moje výpožičky a rezervácie.", "Uups",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (0 >= DateTime.Compare(DTDueDate.Value, DateTime.Now))
            {
                MetroFramework.MetroMessageBox.Show(this, "Zadaný dátum nie je validný. Dátum musí byť v budúcnosti.", "Uups",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (var scope = new DataAccessScope())
            {
                var reservation = db.Reservations.Create();
                reservation.Book = book;
                reservation.DueDate = DTDueDate.Value;
                reservation.Active = true;
                reservation.WhenIssued = DateTime.Now;
                reservation.Who = user;
                scope.Complete();
            }

            if (DialogResult.OK == MetroFramework.MetroMessageBox.Show(this, "Rezervácia úspešne pridaná.", "Hurá!", 
                                                MessageBoxButtons.OK, MessageBoxIcon.Question))
            {
                Close();
            }
        }

    }
}
