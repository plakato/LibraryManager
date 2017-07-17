namespace LibraryManager
{
    partial class UCAddNewUser
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TBName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TBLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TBPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TBPasswordCheck = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TAdminRights = new MetroFramework.Controls.MetroToggle();
            this.BAddUser = new MetroFramework.Controls.MetroButton();
            this.Lwarning = new MetroFramework.Controls.MetroLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.10835F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBLogin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBPasswordCheck, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TAdminRights, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BAddUser, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Lwarning, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 252);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Meno a priezvisko:";
            // 
            // TBName
            // 
            // 
            // 
            // 
            this.TBName.CustomButton.Image = null;
            this.TBName.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.TBName.CustomButton.Name = "";
            this.TBName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBName.CustomButton.TabIndex = 1;
            this.TBName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBName.CustomButton.UseSelectable = true;
            this.TBName.CustomButton.Visible = false;
            this.TBName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBName.Lines = new string[0];
            this.TBName.Location = new System.Drawing.Point(172, 13);
            this.TBName.MaxLength = 32767;
            this.TBName.Name = "TBName";
            this.TBName.PasswordChar = '\0';
            this.TBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBName.SelectedText = "";
            this.TBName.SelectionLength = 0;
            this.TBName.SelectionStart = 0;
            this.TBName.ShortcutsEnabled = true;
            this.TBName.Size = new System.Drawing.Size(278, 23);
            this.TBName.TabIndex = 1;
            this.TBName.UseSelectable = true;
            this.TBName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Login:";
            // 
            // TBLogin
            // 
            // 
            // 
            // 
            this.TBLogin.CustomButton.Image = null;
            this.TBLogin.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.TBLogin.CustomButton.Name = "";
            this.TBLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBLogin.CustomButton.TabIndex = 1;
            this.TBLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBLogin.CustomButton.UseSelectable = true;
            this.TBLogin.CustomButton.Visible = false;
            this.TBLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBLogin.Lines = new string[0];
            this.TBLogin.Location = new System.Drawing.Point(172, 49);
            this.TBLogin.MaxLength = 32767;
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.PasswordChar = '\0';
            this.TBLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBLogin.SelectedText = "";
            this.TBLogin.SelectionLength = 0;
            this.TBLogin.SelectionStart = 0;
            this.TBLogin.ShortcutsEnabled = true;
            this.TBLogin.Size = new System.Drawing.Size(278, 23);
            this.TBLogin.TabIndex = 3;
            this.TBLogin.UseSelectable = true;
            this.TBLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBLogin.Validating += new System.ComponentModel.CancelEventHandler(this.TBLogin_Validating);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Heslo:";
            // 
            // TBPassword
            // 
            // 
            // 
            // 
            this.TBPassword.CustomButton.Image = null;
            this.TBPassword.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.TBPassword.CustomButton.Name = "";
            this.TBPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBPassword.CustomButton.TabIndex = 1;
            this.TBPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBPassword.CustomButton.UseSelectable = true;
            this.TBPassword.CustomButton.Visible = false;
            this.TBPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBPassword.Lines = new string[0];
            this.TBPassword.Location = new System.Drawing.Point(172, 88);
            this.TBPassword.MaxLength = 32767;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '●';
            this.TBPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBPassword.SelectedText = "";
            this.TBPassword.SelectionLength = 0;
            this.TBPassword.SelectionStart = 0;
            this.TBPassword.ShortcutsEnabled = true;
            this.TBPassword.Size = new System.Drawing.Size(278, 23);
            this.TBPassword.TabIndex = 5;
            this.TBPassword.UseSelectable = true;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Heslo znovu:";
            // 
            // TBPasswordCheck
            // 
            // 
            // 
            // 
            this.TBPasswordCheck.CustomButton.Image = null;
            this.TBPasswordCheck.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.TBPasswordCheck.CustomButton.Name = "";
            this.TBPasswordCheck.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBPasswordCheck.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBPasswordCheck.CustomButton.TabIndex = 1;
            this.TBPasswordCheck.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBPasswordCheck.CustomButton.UseSelectable = true;
            this.TBPasswordCheck.CustomButton.Visible = false;
            this.TBPasswordCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBPasswordCheck.Lines = new string[0];
            this.TBPasswordCheck.Location = new System.Drawing.Point(172, 127);
            this.TBPasswordCheck.MaxLength = 32767;
            this.TBPasswordCheck.Name = "TBPasswordCheck";
            this.TBPasswordCheck.PasswordChar = '●';
            this.TBPasswordCheck.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBPasswordCheck.SelectedText = "";
            this.TBPasswordCheck.SelectionLength = 0;
            this.TBPasswordCheck.SelectionStart = 0;
            this.TBPasswordCheck.ShortcutsEnabled = true;
            this.TBPasswordCheck.Size = new System.Drawing.Size(278, 23);
            this.TBPasswordCheck.TabIndex = 7;
            this.TBPasswordCheck.UseSelectable = true;
            this.TBPasswordCheck.UseSystemPasswordChar = true;
            this.TBPasswordCheck.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBPasswordCheck.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBPasswordCheck.Validating += new System.ComponentModel.CancelEventHandler(this.TBPasswordCheck_Validating);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 168);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(148, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Administrátorské právo:";
            // 
            // TAdminRights
            // 
            this.TAdminRights.AutoSize = true;
            this.TAdminRights.Location = new System.Drawing.Point(172, 171);
            this.TAdminRights.Name = "TAdminRights";
            this.TAdminRights.Size = new System.Drawing.Size(80, 17);
            this.TAdminRights.TabIndex = 9;
            this.TAdminRights.Text = "Off";
            this.TAdminRights.UseSelectable = true;
            // 
            // BAddUser
            // 
            this.BAddUser.AutoSize = true;
            this.BAddUser.Location = new System.Drawing.Point(13, 215);
            this.BAddUser.Name = "BAddUser";
            this.BAddUser.Size = new System.Drawing.Size(92, 23);
            this.BAddUser.TabIndex = 10;
            this.BAddUser.Text = "Pridaj užívateľa";
            this.BAddUser.UseSelectable = true;
            this.BAddUser.Click += new System.EventHandler(this.BAddUser_Click);
            // 
            // Lwarning
            // 
            this.Lwarning.AutoSize = true;
            this.Lwarning.ForeColor = System.Drawing.Color.Red;
            this.Lwarning.Location = new System.Drawing.Point(172, 212);
            this.Lwarning.Name = "Lwarning";
            this.Lwarning.Size = new System.Drawing.Size(55, 19);
            this.Lwarning.TabIndex = 11;
            this.Lwarning.Text = "warning";
            this.Lwarning.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // UCAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCAddNewUser";
            this.Size = new System.Drawing.Size(463, 342);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TBName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TBLogin;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TBPassword;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TBPasswordCheck;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroToggle TAdminRights;
        private MetroFramework.Controls.MetroButton BAddUser;
        private MetroFramework.Controls.MetroLabel Lwarning;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
