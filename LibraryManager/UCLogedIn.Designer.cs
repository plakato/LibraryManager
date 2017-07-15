namespace LibraryManager
{
    partial class UCLogedIn
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
            this.Llogin = new MetroFramework.Controls.MetroLabel();
            this.BLogOut = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Llogin
            // 
            this.Llogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Llogin.AutoSize = true;
            this.Llogin.Location = new System.Drawing.Point(89, 6);
            this.Llogin.Name = "Llogin";
            this.Llogin.Size = new System.Drawing.Size(38, 19);
            this.Llogin.TabIndex = 0;
            this.Llogin.Text = "login";
            // 
            // BLogOut
            // 
            this.BLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BLogOut.Location = new System.Drawing.Point(143, 6);
            this.BLogOut.Name = "BLogOut";
            this.BLogOut.Size = new System.Drawing.Size(75, 23);
            this.BLogOut.TabIndex = 1;
            this.BLogOut.Text = "Odhlásiť";
            this.BLogOut.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UCLogedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.BLogOut);
            this.Controls.Add(this.Llogin);
            this.Name = "UCLogedIn";
            this.Size = new System.Drawing.Size(221, 38);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Llogin;
        private MetroFramework.Controls.MetroButton BLogOut;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}
