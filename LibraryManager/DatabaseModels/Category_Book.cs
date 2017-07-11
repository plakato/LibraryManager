using Shaolinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Category_Book : DataAccessObject
    {
        [BackReference]
        public abstract Category Category { get; set; }
        
        [BackReference]
        public abstract Book Book { get; set; }
    }
}
