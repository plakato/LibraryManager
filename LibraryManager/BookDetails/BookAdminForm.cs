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
    public partial class BookAdminForm : MetroForm
    {
        DatabaseModels.MainDatabase db = DatabaseModels.MainDatabase.getInstance();
        DatabaseModels.User user;
        DatabaseModels.Book book;
        private const string LOAN = "Požičať";
        private const string RETURN = "Vrátiť";
        private const string EMPTY = "-";
        private const string EDIT = "Editovať";
        private const string SAVE = "Uložiť";
        private const string CANCEL = "Zrušiť";
        private const string DELETE = "Odstrániť";



        public BookAdminForm(DatabaseModels.User user, DatabaseModels.Book book)
        {
            InitializeComponent();
            this.user = user;
            this.book = book;
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

            UpdateLoanReturnTable();
            UpdateReservationTable();
        }

        private void UpdateLoanReturnTable()
        {
            GVLoanReturn.Rows.Clear();
            foreach (DatabaseModels.Copy copy in book.Copies)
            {
                if (DatabaseModels.Copy.LOANED == copy.GetStatus())
                {
                    DatabaseModels.Loan loan = copy.Loans.Where(l => l.Active == true).First();
                    GVLoanReturn.Rows.Add(copy.ID, copy.GetStatus(), loan.Who.Name, loan.Who.Login, loan.When, loan.UntilWhen.ToString("dd/MM/yyyy"), RETURN, loan.ID);
                }
                else
                {
                    GVLoanReturn.Rows.Add(copy.ID, copy.GetStatus(), EMPTY, EMPTY, EMPTY, EMPTY, LOAN, EMPTY);
                }
            }
        }

        private void UpdateReservationTable()
        {
            GVResevations.Rows.Clear();
            int i = 1;
            foreach (DatabaseModels.Reservation res in book.Reservations.Where(r => r.Active == true).OrderBy(r => r.WhenIssued))
            {
                GVResevations.Rows.Add(i,res.Who.Name, res.DueDate.ToString("dd/MM/yyyy"), res.ID, CANCEL);
                i++;
            }
        }

        private void BEditBookDetail_Click(object sender, EventArgs e)
        {
            if (BEditBookDetail.Text == EDIT)
            {
                BEditBookDetail.Text = SAVE;
                SetFormEditMode();
            } else
            {
                BEditBookDetail.Text = EDIT;
                SaveFormToDatabase();
            }
        }

        private void SetFormEditMode()
        {
            //TODO
        }

        private void SaveFormToDatabase()
        {
            //TODO
        }

        private void GVLoanReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GVLoanReturn.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int copyID = int.Parse(GVLoanReturn["IDColumn", e.RowIndex].Value.ToString());
                if (GVLoanReturn[e.ColumnIndex,e.RowIndex].Value.ToString() == DELETE)
                {
                    DeleteCopy(copyID);
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
                    UpdateLoanReturnTable();
                }
                
            }
        }

        private async void DeleteCopy(int copyID)
        {
            using (var scope = new DataAccessScope())
            {
                await db.Copies.Where(c => c.ID == copyID && c.Book == book).DeleteAsync();
                await scope.CompleteAsync();
            }
        }
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

        private void LoanCopy(int copyid)
        {
            DatabaseModels.Copy copy = db.Copies.GetReference(new { ID = copyid, Book = book });
            LoanCopyForm lcform = new LoanCopyForm(copy);
            lcform.ShowDialog(this);
        }

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
                UpdateReservationTable();
            }
        }
    }
}
