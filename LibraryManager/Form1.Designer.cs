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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.Lschool_name = new System.Windows.Forms.Label();
            this.Divider = new System.Windows.Forms.Label();
            this.FlowLayoutPanelSignIn = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.Llogin = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.FlowLayoutPanelSignIn.SuspendLayout();
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
            this.Divider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Divider.BackColor = System.Drawing.Color.Crimson;
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Divider.ForeColor = System.Drawing.Color.Red;
            this.Divider.Location = new System.Drawing.Point(0, 92);
            this.Divider.MinimumSize = new System.Drawing.Size(2, 2);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(10000, 2);
            this.Divider.TabIndex = 1;
            // 
            // FlowLayoutPanelSignIn
            // 
            this.FlowLayoutPanelSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanelSignIn.AutoSize = true;
            this.FlowLayoutPanelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPanelSignIn.Controls.Add(this.metroLabel1);
            this.FlowLayoutPanelSignIn.Controls.Add(this.metroTextBox1);
            this.FlowLayoutPanelSignIn.Controls.Add(this.Llogin);
            this.FlowLayoutPanelSignIn.Controls.Add(this.metroTextBox2);
            this.FlowLayoutPanelSignIn.Location = new System.Drawing.Point(565, 44);
            this.FlowLayoutPanelSignIn.Name = "FlowLayoutPanelSignIn";
            this.FlowLayoutPanelSignIn.Size = new System.Drawing.Size(412, 29);
            this.FlowLayoutPanelSignIn.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Menu;
            this.metroLabel1.Location = new System.Drawing.Point(3, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Login:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(53, 3);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(150, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Llogin
            // 
            this.Llogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Llogin.AutoSize = true;
            this.Llogin.Location = new System.Drawing.Point(209, 5);
            this.Llogin.Name = "Llogin";
            this.Llogin.Size = new System.Drawing.Size(44, 19);
            this.Llogin.TabIndex = 4;
            this.Llogin.Text = "Heslo:";
            this.Llogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(259, 3);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(150, 23);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.FlowLayoutPanelSignIn);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.Lschool_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeScreen";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Učiteľská knižnica";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.FlowLayoutPanelSignIn.ResumeLayout(false);
            this.FlowLayoutPanelSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lschool_name;
        private System.Windows.Forms.Label Divider;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelSignIn;
        private MetroLabel metroLabel1;
        private MetroTextBox metroTextBox1;
        private MetroLabel Llogin;
        private MetroTextBox metroTextBox2;
    }
}

