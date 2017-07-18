namespace LibraryManager
{
    partial class UCUserMenu
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
            this.TCUserMenu = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ucSearchBooks1 = new LibraryManager.UCSearchBooks();
            this.TCUserMenu.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCUserMenu
            // 
            this.TCUserMenu.Controls.Add(this.metroTabPage1);
            this.TCUserMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCUserMenu.Location = new System.Drawing.Point(0, 0);
            this.TCUserMenu.Name = "TCUserMenu";
            this.TCUserMenu.SelectedIndex = 0;
            this.TCUserMenu.Size = new System.Drawing.Size(775, 475);
            this.TCUserMenu.TabIndex = 0;
            this.TCUserMenu.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.ucSearchBooks1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(767, 433);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // ucSearchBooks1
            // 
            this.ucSearchBooks1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchBooks1.Location = new System.Drawing.Point(0, 3);
            this.ucSearchBooks1.Name = "ucSearchBooks1";
            this.ucSearchBooks1.Size = new System.Drawing.Size(647, 446);
            this.ucSearchBooks1.TabIndex = 2;
            this.ucSearchBooks1.UseSelectable = true;
            // 
            // UCUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCUserMenu);
            this.Name = "UCUserMenu";
            this.Size = new System.Drawing.Size(775, 475);
            this.TCUserMenu.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TCUserMenu;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private UCSearchBooks ucSearchBooks1;
    }
}
