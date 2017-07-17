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
            this.components = new System.ComponentModel.Container();
            this.TCUserMenu = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ucSearchBooks1 = new LibraryManager.UCSearchBooks();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.ucAddNewBook1 = new LibraryManager.UCAddNewBook();
            this.TCUserMenu.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCUserMenu
            // 
            this.TCUserMenu.Controls.Add(this.metroTabPage1);
            this.TCUserMenu.Controls.Add(this.metroTabPage2);
            this.TCUserMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCUserMenu.Location = new System.Drawing.Point(0, 0);
            this.TCUserMenu.Name = "TCUserMenu";
            this.TCUserMenu.SelectedIndex = 1;
            this.TCUserMenu.Size = new System.Drawing.Size(564, 92);
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
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.metroTabPage1.Size = new System.Drawing.Size(556, 50);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Hľadať knižku";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // ucSearchBooks1
            // 
            this.ucSearchBooks1.AutoSize = true;
            this.ucSearchBooks1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSearchBooks1.Location = new System.Drawing.Point(10, 10);
            this.ucSearchBooks1.Name = "ucSearchBooks1";
            this.ucSearchBooks1.Size = new System.Drawing.Size(536, 30);
            this.ucSearchBooks1.TabIndex = 2;
            this.ucSearchBooks1.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.ucAddNewBook1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(556, 50);
            this.metroTabPage2.TabIndex = 4;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // ucAddNewBook1
            // 
            this.ucAddNewBook1.Location = new System.Drawing.Point(4, 4);
            this.ucAddNewBook1.Name = "ucAddNewBook1";
            this.ucAddNewBook1.Size = new System.Drawing.Size(641, 434);
            this.ucAddNewBook1.TabIndex = 2;
            this.ucAddNewBook1.UseSelectable = true;
            // 
            // UCUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCUserMenu);
            this.Name = "UCUserMenu";
            this.Size = new System.Drawing.Size(564, 92);
            this.TCUserMenu.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TCUserMenu;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private UCSearchBooks ucSearchBooks1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private UCAddNewBook ucAddNewBook1;
    }
}
