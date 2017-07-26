using Shaolinq;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Keyword : DataAccessObject
    {
        [PrimaryKey]
        [PersistedMember]
        public abstract string Word { get; set; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Keyword_Book> Keyword_Book { get; }
    }
}
