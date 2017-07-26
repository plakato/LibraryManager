using Shaolinq;
using Shaolinq.MySql;
using System.Windows.Forms;

namespace LibraryManager.DatabaseModels
{
    /// <summary>
    /// Main database containing specific tables - DataAccessObjects. Works as a singleton
    /// - saves instance and returns it in static getInstance()
    /// </summary>
    [DataAccessModel]
    public abstract class MainDatabase : DataAccessModel
    {
        // singleton instance
        static MainDatabase db;

        // Creates database and saves its instace. Reports succes in bool value.
        public static void Initialize()
        {
            var configuration = MySqlConfiguration.Create("LibraryDatabase", "localhost", "root", "");
            db = BuildDataAccessModel<MainDatabase>(configuration);

            try
            {
                db.Create(DatabaseCreationOptions.IfNotExist);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                // DO nothing - databse already exists
            }
         }
        public static MainDatabase getInstance()
        {
            return db;
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
