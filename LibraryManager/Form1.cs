using MetroFramework.Forms;
using Shaolinq;
using Shaolinq.MySql;
using System;

namespace LibraryManager
{
    public partial class WelcomeScreen : MetroForm
    {
        public WelcomeScreen()
        {
            InitializeComponent();

            // Create database if not exists => on the first run of the application
            var configuration = MySqlConfiguration.Create("LibraryDatabase", "localhost", "root", "");
            var model = DataAccessModel.BuildDataAccessModel<DatabaseModels.MainDatabase>(configuration);

            try
            {
                model.Create(DatabaseCreationOptions.IfDatabaseNotExist);

            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                // DO nothing
            }
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
