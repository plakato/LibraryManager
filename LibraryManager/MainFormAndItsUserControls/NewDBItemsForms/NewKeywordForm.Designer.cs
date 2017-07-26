namespace LibraryManager.UserMenuTabs
{
    partial class NewKeywordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewKeywordForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TBWord = new MetroFramework.Controls.MetroTextBox();
            this.BSave = new MetroFramework.Controls.MetroButton();
            this.BClose = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TBWord
            // 
            // 
            // 
            // 
            this.TBWord.CustomButton.Image = null;
            this.TBWord.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.TBWord.CustomButton.Name = "";
            this.TBWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBWord.CustomButton.TabIndex = 1;
            this.TBWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBWord.CustomButton.UseSelectable = true;
            this.TBWord.CustomButton.Visible = false;
            this.TBWord.Lines = new string[0];
            this.TBWord.Location = new System.Drawing.Point(23, 79);
            this.TBWord.MaxLength = 32767;
            this.TBWord.Name = "TBWord";
            this.TBWord.PasswordChar = '\0';
            this.TBWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBWord.SelectedText = "";
            this.TBWord.SelectionLength = 0;
            this.TBWord.SelectionStart = 0;
            this.TBWord.ShortcutsEnabled = true;
            this.TBWord.Size = new System.Drawing.Size(337, 23);
            this.TBWord.TabIndex = 0;
            this.TBWord.UseSelectable = true;
            this.TBWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBWord_KeyPress);
            // 
            // BSave
            // 
            this.BSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BSave.Location = new System.Drawing.Point(24, 127);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 1;
            this.BSave.Text = "Uložiť";
            this.BSave.UseSelectable = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BClose
            // 
            this.BClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BClose.Location = new System.Drawing.Point(285, 127);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(75, 23);
            this.BClose.TabIndex = 2;
            this.BClose.Text = "Zrušiť";
            this.BClose.UseSelectable = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // NewKeywordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 177);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.TBWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewKeywordForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Nové kľúčové slovo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox TBWord;
        private MetroFramework.Controls.MetroButton BClose;
        private MetroFramework.Controls.MetroButton BSave;
    }
}