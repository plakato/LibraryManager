namespace LibraryManager
{
    partial class UCLogedOut
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TBLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TBPassword = new MetroFramework.Controls.MetroTextBox();
            this.BSignIn = new MetroFramework.Controls.MetroButton();
            this.Lwarning = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.metroLabel1);
            this.flowLayoutPanel1.Controls.Add(this.TBLogin);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel2);
            this.flowLayoutPanel1.Controls.Add(this.TBPassword);
            this.flowLayoutPanel1.Controls.Add(this.BSignIn);
            this.flowLayoutPanel1.Controls.Add(this.Lwarning);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(398, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Login:";
            // 
            // TBLogin
            // 
            // 
            // 
            // 
            this.TBLogin.CustomButton.Image = null;
            this.TBLogin.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.TBLogin.CustomButton.Name = "";
            this.TBLogin.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TBLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBLogin.CustomButton.TabIndex = 1;
            this.TBLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBLogin.CustomButton.UseSelectable = true;
            this.TBLogin.CustomButton.Visible = false;
            this.TBLogin.Lines = new string[0];
            this.TBLogin.Location = new System.Drawing.Point(53, 3);
            this.TBLogin.MaxLength = 32767;
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.PasswordChar = '\0';
            this.TBLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBLogin.SelectedText = "";
            this.TBLogin.SelectionLength = 0;
            this.TBLogin.SelectionStart = 0;
            this.TBLogin.ShortcutsEnabled = true;
            this.TBLogin.Size = new System.Drawing.Size(100, 20);
            this.TBLogin.TabIndex = 1;
            this.TBLogin.UseSelectable = true;
            this.TBLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(159, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Heslo:";
            // 
            // TBPassword
            // 
            // 
            // 
            // 
            this.TBPassword.CustomButton.Image = null;
            this.TBPassword.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.TBPassword.CustomButton.Name = "";
            this.TBPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TBPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBPassword.CustomButton.TabIndex = 1;
            this.TBPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBPassword.CustomButton.UseSelectable = true;
            this.TBPassword.CustomButton.Visible = false;
            this.TBPassword.Lines = new string[0];
            this.TBPassword.Location = new System.Drawing.Point(209, 3);
            this.TBPassword.MaxLength = 32767;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '●';
            this.TBPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBPassword.SelectedText = "";
            this.TBPassword.SelectionLength = 0;
            this.TBPassword.SelectionStart = 0;
            this.TBPassword.ShortcutsEnabled = true;
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 3;
            this.TBPassword.UseSelectable = true;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPassword_KeyPress);
            // 
            // BSignIn
            // 
            this.BSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFlowBreak(this.BSignIn, true);
            this.BSignIn.Location = new System.Drawing.Point(315, 3);
            this.BSignIn.Name = "BSignIn";
            this.BSignIn.Size = new System.Drawing.Size(75, 23);
            this.BSignIn.TabIndex = 4;
            this.BSignIn.Text = "Prihlásiť";
            this.BSignIn.UseSelectable = true;
            this.BSignIn.Click += new System.EventHandler(this.BSignIn_Click);
            // 
            // Lwarning
            // 
            this.Lwarning.AutoSize = true;
            this.Lwarning.FontSize = MetroFramework.MetroLabelSize.Small;
            this.Lwarning.ForeColor = System.Drawing.Color.Red;
            this.Lwarning.Location = new System.Drawing.Point(3, 29);
            this.Lwarning.Name = "Lwarning";
            this.Lwarning.Size = new System.Drawing.Size(46, 15);
            this.Lwarning.TabIndex = 5;
            this.Lwarning.Text = "warning";
            this.Lwarning.UseCustomForeColor = true;
            this.Lwarning.Visible = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UCLogedOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCLogedOut";
            this.Size = new System.Drawing.Size(398, 46);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TBLogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TBPassword;
        private MetroFramework.Controls.MetroButton BSignIn;
        private MetroFramework.Controls.MetroLabel Lwarning;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}
