﻿using Shaolinq;

namespace LibraryManager.DatabaseModels
{
    /// <summary>
    /// Main database containing specific tables - DataAccessObjects.
    /// </summary>
    [DataAccessModel]
    public abstract class MainDatabase : DataAccessModel
    {
        [DataAccessObjects]
        public abstract DataAccessObjects<User> Users { get;  }

        [DataAccessObjects]
        public abstract DataAccessObjects<Book> Books { get; }
        
        [DataAccessObjects]
        public abstract DataAccessObjects<Category> Categories { get; }

        [DataAccessObjects]
        public abstract DataAccessObjects<Category_Book> Category_Book { get; }

        [DataAccessObjects]
        public abstract DataAccessObjects<Copy> Copies { get; }

        [DataAccessObjects]
        public abstract DataAccessObjects<Keyword> Keywords { get; }

        [DataAccessObjects]
        public abstract DataAccessObjects<Keyword_Book> Keyword_Book { get; }

        [DataAccessObjects]
        public abstract DataAccessObjects<Loan> Loans { get; }

        [DataAccessObjects]
        public abstract DataAccessObjects<Reservation> Reservations { get; }
        

    }
}