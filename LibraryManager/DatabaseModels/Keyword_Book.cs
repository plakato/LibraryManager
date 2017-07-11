using Shaolinq;
using System;


namespace LibraryManager.DatabaseModels
{
    [DataAccessObject]
    public abstract class Keyword_Book : DataAccessObject
    {
        [BackReference]
        public abstract Keyword Keyword { get; set; }

        [BackReference]
        public abstract Book Book { get; set; }

    }
}
