﻿using MetroFramework.Forms;
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

namespace LibraryManager.BookDetails
{
    public partial class LoanCopyForm : MetroForm
    {
        DatabaseModels.MainDatabase db = DatabaseModels.MainDatabase.getInstance();
        DatabaseModels.Copy copy;
        public LoanCopyForm(DatabaseModels.Copy copy)
        {
            InitializeComponent();
            this.copy = copy;
            CBWho.DropDownStyle = ComboBoxStyle.DropDownList;
            CBWho.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void LoanCopyForm_Load(object sender, EventArgs e)
        {
            foreach (DatabaseModels.User user in db.Users)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = user.Name;
                item.Value = user.Login;
                CBWho.Items.Add(item);
            }
        }

        private void DTUntilWhen_Validating(object sender, CancelEventArgs e)
        {
            if (0 >= DateTime.Compare(DTUntilWhen.Value, DateTime.Now))
            {
                errorProvider.SetError(DTUntilWhen, "Zvoľte čas v budúcnosti.");
            } else
            {
                errorProvider.SetError(DTUntilWhen, null);
            }
        }

        private async void BLoan_Click(object sender, EventArgs e)
        {
            if ("" != errorProvider.GetError(DTUntilWhen) || CBWho.SelectedItem.ToString() == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Zadané údaje nie sú validné.", "Uups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DatabaseModels.User user = db.Users.GetReference(((ComboBoxItem)CBWho.SelectedItem).Value);

            using (var scope = new DataAccessScope())
            {
                var loan = db.Loans.Create();
                loan.Active = true;
                loan.Copy = copy;
                loan.When = DateTime.Now;
                loan.UntilWhen = DTUntilWhen.Value;
                loan.Who = user;
                await scope.CompleteAsync();
            }

            if (DialogResult.OK == MetroFramework.MetroMessageBox.Show(this, "Kniha úspešne vypožičaná.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Question))
            {
                Close();
            }
        }

        // ComboBoxItem with option to store additional value.
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
