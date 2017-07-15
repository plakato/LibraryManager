﻿namespace LibraryManager
{
    partial class NewCategoryForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TBCategoryName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Názov kategórie:";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TBCategoryName
            // 
            // 
            // 
            // 
            this.TBCategoryName.CustomButton.Image = null;
            this.TBCategoryName.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.TBCategoryName.CustomButton.Name = "";
            this.TBCategoryName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBCategoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBCategoryName.CustomButton.TabIndex = 1;
            this.TBCategoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBCategoryName.CustomButton.UseSelectable = true;
            this.TBCategoryName.CustomButton.Visible = false;
            this.TBCategoryName.Lines = new string[0];
            this.TBCategoryName.Location = new System.Drawing.Point(158, 73);
            this.TBCategoryName.MaxLength = 32767;
            this.TBCategoryName.Name = "TBCategoryName";
            this.TBCategoryName.PasswordChar = '\0';
            this.TBCategoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBCategoryName.SelectedText = "";
            this.TBCategoryName.SelectionLength = 0;
            this.TBCategoryName.SelectionStart = 0;
            this.TBCategoryName.ShortcutsEnabled = true;
            this.TBCategoryName.Size = new System.Drawing.Size(224, 23);
            this.TBCategoryName.TabIndex = 1;
            this.TBCategoryName.UseSelectable = true;
            this.TBCategoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBCategoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.metroButton1.Location = new System.Drawing.Point(23, 125);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Vytvoriť";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton2.Location = new System.Drawing.Point(307, 125);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Zrušiť";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // NewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 179);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.TBCategoryName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "NewCategoryForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Nová kategória";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox TBCategoryName;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}