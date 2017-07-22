using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using LibraryManager.DatabaseModels;

namespace LibraryManager.UserMenuTabs
{
    public partial class UCKeywords : MetroUserControl
    {
        MainDatabase db = MainDatabase.getInstance(); 
        private const string NEW_KEYWORD = "Nové kľúčové slovo";
        public UCKeywords()
        {
            InitializeComponent();
            UpdateKeywords();
        }

        private void UpdateKeywords()
        {
            foreach (Keyword k in db.Keywords)
            {
                MetroTile tile = new MetroTile();
                tile.Text = k.Word;
                tile.Padding = new Padding(3, 3, 3, 3);
                FLPKeywords.Controls.Add(tile);
            }

            MetroTile newTile = new MetroTile();
            newTile.Padding = new Padding(3, 3, 3, 3);
            newTile.Text = NEW_KEYWORD;
            newTile.Click += (sender, e) => ShowNewKeywordForm();
            FLPKeywords.Controls.Add(newTile);
        }

        private void ShowNewKeywordForm()
        {
            NewKeywordForm form = new NewKeywordForm();
            form.ShowDialog(this);
        }
    }
}
