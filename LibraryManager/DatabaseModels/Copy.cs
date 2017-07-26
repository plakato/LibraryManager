using Shaolinq;
using System.Linq;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Copy : DataAccessObject<int>
    {
        internal const string FREE = "Voľná";
        internal const string LOANED = "Požičaná";

        [BackReference]
        public abstract Book Book { get; set; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Loan> Loans { get; }

        public string GetStatus()
        {
            if (Loans.Where(loan => loan.Active == true).Any())
            {
                return LOANED;
            } else
            {
                return FREE;
            }
        }
    }
}
