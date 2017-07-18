using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.BookDetails
{
    public partial class BookUserForm : MetroForm
    {
        public BookUserForm(DatabaseModels.User user, DatabaseModels.Book book)
        {
            InitializeComponent();
        }
    }
}
