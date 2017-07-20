using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shaolinq;
using MetroFramework.Controls;

namespace LibraryManager.UserMenuTabs
{
    public partial class UCMyLoans : MetroUserControl
    {
        DatabaseModels.User user;
        DatabaseModels.MainDatabase db = DatabaseModels.MainDatabase.getInstance();
        private const string CANCEL = "Zrušiť";
        public UCMyLoans(DatabaseModels.User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void UCMyLoans_Load(object sender, EventArgs e)
        {
            foreach (DatabaseModels.Loan loan in user.Loans.Where(l => l.Active == true))
            {
                var copy = loan.Copy;
                GVLoans.Rows.Add(copy.Book.Title, copy.Book.Author, loan.UntilWhen.ToString("dd/MM/yyyy"));
            }
            UpdateReservationTable();
        }
        
        internal void UpdateReservationTable()
        {
            GVReservations.Rows.Clear();
            foreach (DatabaseModels.Reservation res in user.Reservations.Where(r => r.Active == true))
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
                UpdateReservationTable();
            }
        }
    }
}
