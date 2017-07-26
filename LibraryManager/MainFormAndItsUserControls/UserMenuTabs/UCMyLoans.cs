using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Shaolinq;
using MetroFramework.Controls;
using LibraryManager.DatabaseModels;

namespace LibraryManager.UserMenuTabs
{
    // UC displaying current user's loans and reservations.
    public partial class UCMyLoans : MetroUserControl
    {
        string login;
        MainDatabase db = MainDatabase.getInstance();
        private const string CANCEL = "Zrušiť";
        public UCMyLoans(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        // Displays loans and reservations on load.
        private void UCMyLoans_Load(object sender, EventArgs e)
        {
            User user = db.Users.GetReference(login);
            UpdateLoanTable(user);
            UpdateReservationTable(user);
        }
        
        internal void UpdateLoanTable(User user)
        {
            GVLoans.Rows.Clear();
            foreach (Loan l in user.Loans.Where(l => l.Active == true))
            {
                var loan = db.Loans.GetReference(l.Id);
                var book = loan.Copy.Book;
                GVLoans.Rows.Add(book.Title, book.Author, loan.UntilWhen.ToString("dd/MM/yyyy"));
            }
        }
        internal void UpdateReservationTable(User user)
        {
            GVReservations.Rows.Clear();
            foreach (Reservation res in user.Reservations.Where(r => r.Active == true))
            {
                GVReservations.Rows.Add(res.ID, res.Book.Title, res.Book.Author, res.Count, res.DueDate.ToString("dd/MM/yyyy"), CANCEL);
            }
        }

        private async void GVReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GVReservations.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int resID = int.Parse(GVReservations["ReservationIDColumn", e.RowIndex].Value.ToString());
                using(var scope = new DataAccessScope())
                {
                    var res = db.Reservations.GetReference(resID);
                    res.Active = false;
                    await scope.CompleteAsync();
                }
                UpdateReservationTable(db.Users.GetReference(login));
            }
        }
    }
}
