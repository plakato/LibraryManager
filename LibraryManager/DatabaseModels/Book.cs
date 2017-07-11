using Shaolinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Book : DataAccessObject
    {
        [PrimaryKey]
        [PersistedMember]
        public abstract string ISBN { get; set; }

        [PersistedMember]
        public abstract string Name { get; set; }

        [PersistedMember]
        public abstract string Author { get; set; }

        [PersistedMember]
        public abstract int NumberOfPages { get; set; }

        [PersistedMember]
        public abstract int PublicationYear { get; set; }

        [PersistedMember]
        public abstract string Publisher { get; set; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Category_Book> Category_Books { get; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Copy> Copies { get; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Keyword_Book> Keyword_Book { get; }
    }
}
