using MetroFramework.Controls;

namespace LibraryManager
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.Lschool_name = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ucWelcome1 = new LibraryManager.UCWelcome();
            this.ucLogIn1 = new LibraryManager.UCLogIn();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lschool_name
            // 
            this.Lschool_name.AutoSize = true;
            this.Lschool_name.BackColor = System.Drawing.Color.Transparent;
            this.Lschool_name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lschool_name.ForeColor = System.Drawing.SystemColors.Menu;
            this.Lschool_name.Location = new System.Drawing.Point(23, 59);
            this.Lschool_name.Name = "Lschool_name";
            this.Lschool_name.Size = new System.Drawing.Size(120, 13);
            this.Lschool_name.TabIndex = 0;
            this.Lschool_name.Text = "SZŠ Sv. Alžbety, Košice";
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.Crimson;
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Divider.ForeColor = System.Drawing.Color.Red;
            this.Divider.Location = new System.Drawing.Point(0, 100);
            this.Divider.MinimumSize = new System.Drawing.Size(2, 2);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(10000, 2);
            this.Divider.TabIndex = 1;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = global::LibraryManager.Properties.Settings.Default.LibraryRedStyle;
            this.metroStyleManager1.Theme = global::LibraryManager.Properties.Settings.Default.LibraryRed;
            // 
            // ucWelcome1
            // 
            this.ucWelcome1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucWelcome1.Location = new System.Drawing.Point(300, 292);
            this.ucWelcome1.Name = "ucWelcome1";
            this.ucWelcome1.Size = new System.Drawing.Size(378, 125);
            this.ucWelcome1.TabIndex = 3;
            // 
            // ucLogIn1
            // 
            this.ucLogIn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucLogIn1.Location = new System.Drawing.Point(576, 50);
            this.ucLogIn1.Name = "ucLogIn1";
            this.ucLogIn1.Size = new System.Drawing.Size(401, 47);
            this.ucLogIn1.TabIndex = 4;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ucLogIn1);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.Lschool_name);
            this.Controls.Add(this.ucWelcome1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeScreen";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Učiteľská knižnica";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lschool_name;
        private System.Windows.Forms.Label Divider;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private UCWelcome ucWelcome1;
        private UCLogIn ucLogIn1;
    }
}

