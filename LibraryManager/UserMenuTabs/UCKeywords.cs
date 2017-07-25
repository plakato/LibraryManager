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
using Shaolinq;

namespace LibraryManager.UserMenuTabs
{
    public partial class UCKeywords : MetroUserControl
    {
        MainDatabase db = MainDatabase.getInstance(); 
        private const string NEW_KEYWORD = "+ Nové kľúčové slovo";
        private const string DELETE_WORD = "Odstrániť slovo";
        private List<string> selected = new List<string>();
        private List<string> remaining;

        public UCKeywords()
        {
            InitializeComponent();
            RefreshKeywords();

        }

        public UCKeywords(Guid bookId)
        {
            InitializeComponent();
            Book book = db.Books.GetReference(bookId);
            selected = book.GetKeywords().ToList();
            foreach (string word in selected)
            {
                RedButton b = new RedButton(this);
                b.Text = word;
                b.Width = b.Text.Length * 8;
                b.Click += (sender, e) => KeywordClick(b);
                FLPSelected.Controls.Add(b);
            }
            RefreshKeywords();
        }

        private async void RefreshKeywords()
        {
            FLPKeywords.Controls.Clear();
            var all = await db.Keywords
                                .Select(k => k.Word)
                                .Where(w => w.IsLike($"%{TBKeyword.Text}%"))
                                .ToListAsync();
            remaining = await all.Except(selected).ToListAsync();

            foreach (string word in remaining)
            {
                RedButton b = new RedButton(this);
                b.Text = word;
                b.Width = b.Text.Length * 8;
                b.Click += (sender, e) => KeywordClick(b);
                FLPKeywords.Controls.Add(b);
            }

            RedButton newWord = new RedButton(this);
            newWord.Text = NEW_KEYWORD;
            newWord.Width = newWord.Text.Length * 8;
            newWord.Click += (sender, e) => ShowNewKeywordForm();
            FLPKeywords.Controls.Add(newWord);

            FLPKeywords.Refresh();
        }

        private void ShowNewKeywordForm()
        {
            NewKeywordForm form = new NewKeywordForm();
            if (DialogResult.OK == form.ShowDialog(this))
            {
                RefreshKeywords();
            }
        }

        public List<string> GetSelected()
        {
            return selected;
        }

        public void ClearSelected()
        {
            selected.Clear();
            FLPSelected.Controls.Clear();
            RefreshKeywords();
        }

        private void KeywordClick(Button b)
        {
            if (b.Parent == FLPSelected)
            {
                FLPSelected.Controls.Remove(b);
                FLPKeywords.Controls.Add(b);
                selected.Remove(b.Text);
                remaining.Add(b.Text);
                }
            else
            if (b.Parent == FLPKeywords)
            {
                FLPKeywords.Controls.Remove(b);
                FLPSelected.Controls.Add(b);
                remaining.Remove(b.Text);
                selected.Add(b.Text);
            }
        }

        private void TBKeyword_TextChanged(object sender, EventArgs e)
        {
            RefreshKeywords();
        }

        private class RedButton : MetroButton
        {
            UCKeywords parent;
            public RedButton(UCKeywords parent)
            {
                this.parent = parent;
                UseCustomBackColor = true;
                UseCustomForeColor = true;
                BackColor = Color.FromArgb(209, 17, 65);
                ForeColor = Color.WhiteSmoke;
                ContextMenuStrip = GetContextMenuStrip();
            }

            private ContextMenuStrip GetContextMenuStrip()
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.Items.Add(DELETE_WORD);
                cms.ItemClicked += (sender,e) => HandleMenuClick(e, cms);
                return cms;
            }

            private async void HandleMenuClick(ToolStripItemClickedEventArgs e, ContextMenuStrip cms)
            {
                if (e.ClickedItem.Text == DELETE_WORD)
                {
                    if (DialogResult.Yes == MessageBox.Show(this, "Naozaj chcete odstrániť toto kľúčové slovo? Spolu s ním budú odstránené aj všetky jeho výskyty v knižnici.", "", 
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    {
                        using (var scope = new DataAccessScope())
                        {
                            MainDatabase db = MainDatabase.getInstance();
                            await db.Keywords.Where(k => k.Word == cms.SourceControl.Text).DeleteAsync();
                            await scope.CompleteAsync();
                        }
                        if (parent.FLPSelected.Contains(cms.SourceControl))
                        {
                            parent.FLPSelected.Controls.Remove(cms.SourceControl);
                        }
                    }
                    parent.RefreshKeywords();
                }

            }
        }

    }
}
