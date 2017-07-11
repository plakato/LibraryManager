using Shaolinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Category : DataAccessObject
    {
        [PrimaryKey]
        [PersistedMember]
        public abstract string Name { get; set; }

        [RelatedDataAccessObjects]
        public abstract RelatedDataAccessObjects<Category_Book> Category_Books { get; }


       

    }
}
