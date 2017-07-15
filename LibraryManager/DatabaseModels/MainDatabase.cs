using Shaolinq;
using Shaolinq.MySql;

namespace LibraryManager.DatabaseModels
{
    /// <summary>
    /// Main database containing specific tables - DataAccessObjects.
    /// </summary>
    [DataAccessModel]
    public abstract class MainDatabase : DataAccessModel
    {
        static MainDatabase model;
        public static void Initialize()
        {
            var configuration = MySqlConfiguration.Create("LibraryDatabase", "localhost", "root", "");
            model = BuildDataAccessModel<MainDatabase>(configuration);

            try
            {
                model.Create(DatabaseCreationOptions.DeleteExistingDatabase);

            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                // DO nothing - database is already created
            }
        }
        public static MainDatabase getInstance()
        {
            return model;
        }

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
