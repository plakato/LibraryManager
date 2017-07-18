using MetroFramework.Controls;

namespace LibraryManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Lschool_name = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ucLogIn1 = new LibraryManager.UCLogedOut();
            this.PLogInLogOut = new MetroFramework.Controls.MetroPanel();
            this.PMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ucWelcome1 = new LibraryManager.UCWelcome();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.PLogInLogOut.SuspendLayout();
            this.PMainPanel.SuspendLayout();
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
            // ucLogIn1
            // 
            this.ucLogIn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucLogIn1.Location = new System.Drawing.Point(20, 0);
            this.ucLogIn1.Name = "ucLogIn1";
            this.ucLogIn1.Size = new System.Drawing.Size(401, 47);
            this.ucLogIn1.TabIndex = 4;
            // 
            // PLogInLogOut
            // 
            this.PLogInLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PLogInLogOut.AutoSize = true;
            this.PLogInLogOut.Controls.Add(this.ucLogIn1);
            this.PLogInLogOut.HorizontalScrollbarBarColor = true;
            this.PLogInLogOut.HorizontalScrollbarHighlightOnWheel = false;
            this.PLogInLogOut.HorizontalScrollbarSize = 10;
            this.PLogInLogOut.Location = new System.Drawing.Point(556, 42);
            this.PLogInLogOut.Name = "PLogInLogOut";
            this.PLogInLogOut.Size = new System.Drawing.Size(421, 55);
            this.PLogInLogOut.TabIndex = 6;
            this.PLogInLogOut.VerticalScrollbarBarColor = true;
            this.PLogInLogOut.VerticalScrollbarHighlightOnWheel = false;
            this.PLogInLogOut.VerticalScrollbarSize = 10;
            // 
            // PMainPanel
            // 
            this.PMainPanel.ColumnCount = 1;
            this.PMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PMainPanel.Controls.Add(this.ucWelcome1, 0, 1);
            this.PMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMainPanel.Location = new System.Drawing.Point(20, 60);
            this.PMainPanel.Name = "PMainPanel";
            this.PMainPanel.RowCount = 2;
            this.PMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3431F));
            this.PMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.65691F));
            this.PMainPanel.Size = new System.Drawing.Size(960, 520);
            this.PMainPanel.TabIndex = 7;
            // 
            // ucWelcome1
            // 
            this.ucWelcome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWelcome1.Location = new System.Drawing.Point(3, 67);
            this.ucWelcome1.Name = "ucWelcome1";
            this.ucWelcome1.Size = new System.Drawing.Size(954, 450);
            this.ucWelcome1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.PLogInLogOut);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.Lschool_name);
            this.Controls.Add(this.PMainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Učiteľská knižnica";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.PLogInLogOut.ResumeLayout(false);
            this.PMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lschool_name;
        private System.Windows.Forms.Label Divider;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private UCLogedOut ucLogIn1;
        private MetroPanel PLogInLogOut;
        private System.Windows.Forms.TableLayoutPanel PMainPanel;
        private UCWelcome ucWelcome1;
    }
}

