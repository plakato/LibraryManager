﻿using LibraryManager.DatabaseModels;
using MetroFramework;
using MetroFramework.Forms;
using Shaolinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.UserMenuTabs
{
    public partial class NewKeywordForm : MetroForm
    {
        MainDatabase db = MainDatabase.getInstance();
        public NewKeywordForm()
        {
            InitializeComponent();
        }

        private async void BSave_Click(object sender, EventArgs e)
        {
            if (TBWord.Text == "")
            {
                MetroMessageBox.Show(this, "Kľúčové slovo nemôže byť prázdne!", "Uups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Keywords.Where(k => k.Word == TBWord.Text).Any())
            {
                MetroMessageBox.Show(this, "Takéto kľúčové slovo už existuje!", "Uups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var scope = new DataAccessScope())
            {
                var word = db.Keywords.Create();
                word.Word = TBWord.Text;
                await scope.CompleteAsync();
            }
            MetroMessageBox.Show(this, "Kľúčové slovo úspešne uložené!", "Hurá", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Close();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
