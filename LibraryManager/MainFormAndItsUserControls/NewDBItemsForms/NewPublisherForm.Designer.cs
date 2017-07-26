namespace LibraryManager
{
    partial class NewPublisherForm
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TBPublisherName = new MetroFramework.Controls.MetroTextBox();
            this.BAdd = new MetroFramework.Controls.MetroButton();
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Názov vydavateľstva:";
            // 
            // TBPublisherName
            // 
            // 
            // 
            // 
            this.TBPublisherName.CustomButton.Image = null;
            this.TBPublisherName.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.TBPublisherName.CustomButton.Name = "";
            this.TBPublisherName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBPublisherName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBPublisherName.CustomButton.TabIndex = 1;
            this.TBPublisherName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBPublisherName.CustomButton.UseSelectable = true;
            this.TBPublisherName.CustomButton.Visible = false;
            this.TBPublisherName.Lines = new string[0];
            this.TBPublisherName.Location = new System.Drawing.Point(174, 74);
            this.TBPublisherName.MaxLength = 32767;
            this.TBPublisherName.Name = "TBPublisherName";
            this.TBPublisherName.PasswordChar = '\0';
            this.TBPublisherName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBPublisherName.SelectedText = "";
            this.TBPublisherName.SelectionLength = 0;
            this.TBPublisherName.SelectionStart = 0;
            this.TBPublisherName.ShortcutsEnabled = true;
            this.TBPublisherName.Size = new System.Drawing.Size(324, 23);
            this.TBPublisherName.TabIndex = 1;
            this.TBPublisherName.UseSelectable = true;
            this.TBPublisherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBPublisherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBPublisherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPublisherName_KeyPress);
            // 
            // BAdd
            // 
            this.BAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BAdd.Location = new System.Drawing.Point(24, 115);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(149, 23);
            this.BAdd.TabIndex = 2;
            this.BAdd.Text = "Pridať vydavateľstvo";
            this.BAdd.UseSelectable = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BClose
            // 
            this.BClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BClose.Location = new System.Drawing.Point(423, 115);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(75, 23);
            this.BClose.TabIndex = 3;
            this.BClose.Text = "Zrušiť";
            this.BClose.UseSelectable = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // NewPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 165);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.TBPublisherName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "NewPublisherForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Nové vydavateľstvo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.LightBlue;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox TBPublisherName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BClose;
        private MetroFramework.Controls.MetroButton BAdd;
    }
}