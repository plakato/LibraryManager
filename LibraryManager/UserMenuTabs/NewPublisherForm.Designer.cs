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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
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
            // 
            // metroButton1
            // 
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.metroButton1.Location = new System.Drawing.Point(24, 115);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(149, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Pridať vydavateľstvo";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton2.Location = new System.Drawing.Point(423, 115);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Zrušiť";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // NewPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 165);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
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
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}