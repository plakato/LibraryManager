using Shaolinq;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Category_Book : DataAccessObject
    {
        [PrimaryKey]
        [AutoIncrement]
        [PersistedMember]
        public abstract int ID { get; set; }

        [BackReference]
        public abstract Category Category { get; set; }

        [BackReference]
        public abstract Book Book { get; set; }
    }
}
