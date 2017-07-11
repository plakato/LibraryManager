using Shaolinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Copy : DataAccessObject
    {
        [PrimaryKey]
        [AutoIncrement]
        [PersistedMember]
        public abstract int ID { get; set; }

        [BackReference]
        public abstract Book Book { get; set; }

        [PersistedMember]
        public abstract string Section { get; set; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Loan> Loans { get; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Reservation> Reservations { get; }
    }
}
