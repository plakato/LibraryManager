namespace LibraryManager.UserMenuTabs
{
    partial class UCKeywords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.FLPKeywords = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPSelected = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TBKeyword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FLPKeywords
            // 
            this.FLPKeywords.AutoScroll = true;
            this.FLPKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPKeywords.Location = new System.Drawing.Point(0, 0);
            this.FLPKeywords.Name = "FLPKeywords";
            this.FLPKeywords.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.FLPKeywords.Size = new System.Drawing.Size(329, 126);
            this.FLPKeywords.TabIndex = 0;
            // 
            // FLPSelected
            // 
            this.FLPSelected.AutoScroll = true;
            this.FLPSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPSelected.Location = new System.Drawing.Point(0, 0);
            this.FLPSelected.Name = "FLPSelected";
            this.FLPSelected.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.FLPSelected.Size = new System.Drawing.Size(296, 126);
            this.FLPSelected.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TBKeyword);
            this.splitContainer1.Panel1.Controls.Add(this.FLPKeywords);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.FLPSelected);
            this.splitContainer1.Size = new System.Drawing.Size(629, 126);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 3;
            // 
            // TBKeyword
            // 
            // 
            // 
            // 
            this.TBKeyword.CustomButton.Image = null;
            this.TBKeyword.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.TBKeyword.CustomButton.Name = "";
            this.TBKeyword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBKeyword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBKeyword.CustomButton.TabIndex = 1;
            this.TBKeyword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBKeyword.CustomButton.UseSelectable = true;
            this.TBKeyword.CustomButton.Visible = false;
            this.TBKeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBKeyword.Lines = new string[0];
            this.TBKeyword.Location = new System.Drawing.Point(0, 0);
            this.TBKeyword.MaxLength = 32767;
            this.TBKeyword.Name = "TBKeyword";
            this.TBKeyword.PasswordChar = '\0';
            this.TBKeyword.PromptText = "Kľúčové slovo";
            this.TBKeyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBKeyword.SelectedText = "";
            this.TBKeyword.SelectionLength = 0;
            this.TBKeyword.SelectionStart = 0;
            this.TBKeyword.ShortcutsEnabled = true;
            this.TBKeyword.Size = new System.Drawing.Size(329, 23);
            this.TBKeyword.TabIndex = 1;
            this.TBKeyword.UseSelectable = true;
            this.TBKeyword.WaterMark = "Kľúčové slovo";
            this.TBKeyword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBKeyword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBKeyword.TextChanged += new System.EventHandler(this.TBKeyword_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Vybrané kľúčové slová:";
            // 
            // UCKeywords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCKeywords";
            this.Size = new System.Drawing.Size(629, 126);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.FlowLayoutPanel FLPKeywords;
        private System.Windows.Forms.FlowLayoutPanel FLPSelected;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTextBox TBKeyword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
