namespace LibraryManager.MainFormAndItsUserControls
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // TCUserMenu
            // 
            this.TCUserMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCUserMenu.Location = new System.Drawing.Point(0, 0);
            this.TCUserMenu.Name = "TCUserMenu";
            this.TCUserMenu.Size = new System.Drawing.Size(662, 429);
            this.TCUserMenu.Style = MetroFramework.MetroColorStyle.Red;
            this.TCUserMenu.TabIndex = 0;
            this.TCUserMenu.TabStop = false;
            this.TCUserMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TCUserMenu.UseSelectable = true;
            this.TCUserMenu.SelectedIndexChanged += new System.EventHandler(this.TCUserMenu_SelectedIndexChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UCUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCUserMenu);
            this.Name = "UCUserMenu";
            this.Size = new System.Drawing.Size(662, 429);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TCUserMenu;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}
