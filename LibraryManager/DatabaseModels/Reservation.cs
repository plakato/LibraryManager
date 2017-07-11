using Shaolinq;
using System;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Reservation : DataAccessObject
    {
        [PrimaryKey]
        [AutoIncrement]
        [PersistedMember]
        public abstract int ID { get; set; }

        [BackReference]
        public abstract Copy Copy { get; set; }

        [PersistedMember]
        public abstract string Who { get; set; }

        [PersistedMember]
        public abstract DateTime DueDate { get; set; }

        [PersistedMember]
        public abstract bool Active { get; set; }

    }
}
