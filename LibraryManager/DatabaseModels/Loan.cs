using Shaolinq;
using System;


namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Loan : DataAccessObject
    {
        [PrimaryKey]
        [AutoIncrement]
        [PersistedMember]
        public abstract int ID { get; set; }

        [BackReference]
        public abstract Copy Copy { get; set; }

        [BackReference]
        public abstract User Who { get; set; }

        [PersistedMember]
        public abstract DateTime When { get; set; }

        [PersistedMember]
        public abstract DateTime UntilWhen { get; set; }

        [PersistedMember]
        public abstract bool Active { get; set; }


    }
}
