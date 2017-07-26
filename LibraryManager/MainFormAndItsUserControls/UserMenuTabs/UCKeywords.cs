using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;
using LibraryManager.DatabaseModels;
using Shaolinq;

namespace LibraryManager.UserMenuTabs
{
    // UC with for adding, removing and picking keywords.
    public partial class UCKeywords : MetroUserControl
    {
        MainDatabase db = MainDatabase.getInstance();
        bool admin;
        private const string NEW_KEYWORD = "+ Nové kľúčové slovo";
        private const string DELETE_WORD = "Odstrániť slovo";
        // Set of selected keywords.
        private List<string> selected = new List<string>();
        // Set of not selected keywords.
        private List<string> remaining;

        // Start with empty "selected" set.
        public UCKeywords(bool admin)
        {
            InitializeComponent();
            this.admin = admin;
            RefreshKeywords();
        }

        // Start with "selected" set filled with keyword from the book.
        public UCKeywords(Guid bookId, bool admin)
        {
            InitializeComponent();
            this.admin = admin;
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

        // Displays the buttons according to sets.
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

            // Admin has also a right to add new keywords - hence the extra button.
            if (admin)
            {
                RedButton newWord = new RedButton(this);
                newWord.Text = NEW_KEYWORD;
                newWord.Width = newWord.Text.Length * 8;
                newWord.Click += (sender, e) => ShowNewKeywordForm();
                FLPKeywords.Controls.Add(newWord);
            }           

            FLPKeywords.Refresh();
        }

        // Shows form for adding keyword.
        private void ShowNewKeywordForm()
        {
            NewKeywordForm form = new NewKeywordForm();
            if (DialogResult.OK == form.ShowDialog(this))
            {
                RefreshKeywords();
            }
        }
        /// <summary>
        /// </summary>
        /// <returns> A set of selected keywords. </returns>
        public List<string> GetSelected()
        {
            return selected;
        }

        // Clears the set of selected keywords.
        public void ClearSelected()
        {
            selected.Clear();
            FLPSelected.Controls.Clear();
            RefreshKeywords();
        }

        // Moves keyword between selected and unselected.
        private void KeywordClick(Button b)
        {
            // If was selected - deselects.
            if (b.Parent == FLPSelected)
            {
                FLPSelected.Controls.Remove(b);
                FLPKeywords.Controls.Add(b);
                selected.Remove(b.Text);
                remaining.Add(b.Text);
                }
            else // If not selected => selects.
            if (b.Parent == FLPKeywords)
            {
                FLPKeywords.Controls.Remove(b);
                FLPSelected.Controls.Add(b);
                remaining.Remove(b.Text);
                selected.Add(b.Text);
            }
        }

        // Refreshes keywords leaving only those that match entered text.
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
                    if (!parent.admin)
                    {
                        MetroFramework.MetroMessageBox.Show(parent, "Na túto operáciu potrebujete administrátorské právo!", "Operácia nepovolená", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
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
