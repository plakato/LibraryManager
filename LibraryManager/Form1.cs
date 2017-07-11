using Shaolinq;
using Shaolinq.MySql;
using Shaolinq.Sqlite;
using System;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var configuration = MySqlConfiguration.Create("LibraryDatabase", "localhost", "root", "");
            var model = DataAccessModel.BuildDataAccessModel<DatabaseModels.MainDatabase>(configuration);

            Console.WriteLine();

            model.Create(DatabaseCreationOptions.DeleteExistingDatabase);
        }
    }
}
