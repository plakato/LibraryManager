namespace LibraryManager.UserMenuTabs
{
    partial class UCChangePassword
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
            this.TLPWithTextBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BChangePassword = new MetroFramework.Controls.MetroButton();
            this.TBOriginalPassword = new MetroFramework.Controls.MetroTextBox();
            this.TBNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.TBNewPasswordCheck = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.TLPWithTextBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TLPWithTextBoxes
            // 
            this.TLPWithTextBoxes.AutoSize = true;
            this.TLPWithTextBoxes.BackColor = System.Drawing.Color.Transparent;
            this.TLPWithTextBoxes.ColumnCount = 2;
            this.TLPWithTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPWithTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPWithTextBoxes.Controls.Add(this.metroLabel1, 0, 0);
            this.TLPWithTextBoxes.Controls.Add(this.metroLabel2, 0, 1);
            this.TLPWithTextBoxes.Controls.Add(this.metroLabel3, 0, 2);
            this.TLPWithTextBoxes.Controls.Add(this.BChangePassword, 0, 3);
            this.TLPWithTextBoxes.Controls.Add(this.TBOriginalPassword, 1, 0);
            this.TLPWithTextBoxes.Controls.Add(this.TBNewPassword, 1, 1);
            this.TLPWithTextBoxes.Controls.Add(this.TBNewPasswordCheck, 1, 2);
            this.TLPWithTextBoxes.Location = new System.Drawing.Point(19, 23);
            this.TLPWithTextBoxes.Name = "TLPWithTextBoxes";
            this.TLPWithTextBoxes.Padding = new System.Windows.Forms.Padding(10);
            this.TLPWithTextBoxes.RowCount = 4;
            this.TLPWithTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPWithTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPWithTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPWithTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPWithTextBoxes.Size = new System.Drawing.Size(315, 172);
            this.TLPWithTextBoxes.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Pôvodné heslo:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nové heslo:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 68);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nové heslo znovu:";
            // 
            // BChangePassword
            // 
            this.BChangePassword.Location = new System.Drawing.Point(13, 100);
            this.BChangePassword.Name = "BChangePassword";
            this.BChangePassword.Size = new System.Drawing.Size(115, 23);
            this.BChangePassword.TabIndex = 3;
            this.BChangePassword.Text = "Zmeniť heslo";
            this.BChangePassword.UseSelectable = true;
            this.BChangePassword.Click += new System.EventHandler(this.BChangePassword_Click);
            // 
            // TBOriginalPassword
            // 
            // 
            // 
            // 
            this.TBOriginalPassword.CustomButton.Image = null;
            this.TBOriginalPassword.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.TBOriginalPassword.CustomButton.Name = "";
            this.TBOriginalPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBOriginalPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBOriginalPassword.CustomButton.TabIndex = 1;
            this.TBOriginalPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBOriginalPassword.CustomButton.UseSelectable = true;
            this.TBOriginalPassword.CustomButton.Visible = false;
            this.TBOriginalPassword.Lines = new string[0];
            this.TBOriginalPassword.Location = new System.Drawing.Point(134, 13);
            this.TBOriginalPassword.MaxLength = 32767;
            this.TBOriginalPassword.Name = "TBOriginalPassword";
            this.TBOriginalPassword.PasswordChar = '●';
            this.TBOriginalPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBOriginalPassword.SelectedText = "";
            this.TBOriginalPassword.SelectionLength = 0;
            this.TBOriginalPassword.SelectionStart = 0;
            this.TBOriginalPassword.ShortcutsEnabled = true;
            this.TBOriginalPassword.Size = new System.Drawing.Size(168, 23);
            this.TBOriginalPassword.TabIndex = 4;
            this.TBOriginalPassword.UseSelectable = true;
            this.TBOriginalPassword.UseSystemPasswordChar = true;
            this.TBOriginalPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBOriginalPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBOriginalPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TBOriginalPassword_Validating);
            // 
            // TBNewPassword
            // 
            // 
            // 
            // 
            this.TBNewPassword.CustomButton.Image = null;
            this.TBNewPassword.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.TBNewPassword.CustomButton.Name = "";
            this.TBNewPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBNewPassword.CustomButton.TabIndex = 1;
            this.TBNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBNewPassword.CustomButton.UseSelectable = true;
            this.TBNewPassword.CustomButton.Visible = false;
            this.TBNewPassword.Lines = new string[0];
            this.TBNewPassword.Location = new System.Drawing.Point(134, 42);
            this.TBNewPassword.MaxLength = 32767;
            this.TBNewPassword.Name = "TBNewPassword";
            this.TBNewPassword.PasswordChar = '●';
            this.TBNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBNewPassword.SelectedText = "";
            this.TBNewPassword.SelectionLength = 0;
            this.TBNewPassword.SelectionStart = 0;
            this.TBNewPassword.ShortcutsEnabled = true;
            this.TBNewPassword.Size = new System.Drawing.Size(168, 23);
            this.TBNewPassword.TabIndex = 5;
            this.TBNewPassword.UseSelectable = true;
            this.TBNewPassword.UseSystemPasswordChar = true;
            this.TBNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TBNewPassword_Validating);
            // 
            // TBNewPasswordCheck
            // 
            // 
            // 
            // 
            this.TBNewPasswordCheck.CustomButton.Image = null;
            this.TBNewPasswordCheck.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.TBNewPasswordCheck.CustomButton.Name = "";
            this.TBNewPasswordCheck.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBNewPasswordCheck.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBNewPasswordCheck.CustomButton.TabIndex = 1;
            this.TBNewPasswordCheck.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBNewPasswordCheck.CustomButton.UseSelectable = true;
            this.TBNewPasswordCheck.CustomButton.Visible = false;
            this.TBNewPasswordCheck.Lines = new string[0];
            this.TBNewPasswordCheck.Location = new System.Drawing.Point(134, 71);
            this.TBNewPasswordCheck.MaxLength = 32767;
            this.TBNewPasswordCheck.Name = "TBNewPasswordCheck";
            this.TBNewPasswordCheck.PasswordChar = '●';
            this.TBNewPasswordCheck.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBNewPasswordCheck.SelectedText = "";
            this.TBNewPasswordCheck.SelectionLength = 0;
            this.TBNewPasswordCheck.SelectionStart = 0;
            this.TBNewPasswordCheck.ShortcutsEnabled = true;
            this.TBNewPasswordCheck.Size = new System.Drawing.Size(168, 23);
            this.TBNewPasswordCheck.TabIndex = 6;
            this.TBNewPasswordCheck.UseSelectable = true;
            this.TBNewPasswordCheck.UseSystemPasswordChar = true;
            this.TBNewPasswordCheck.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBNewPasswordCheck.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBNewPasswordCheck.Validating += new System.ComponentModel.CancelEventHandler(this.TBNewPassword_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UCChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLPWithTextBoxes);
            this.Name = "UCChangePassword";
            this.Size = new System.Drawing.Size(476, 279);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.TLPWithTextBoxes.ResumeLayout(false);
            this.TLPWithTextBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.TableLayoutPanel TLPWithTextBoxes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton BChangePassword;
        private MetroFramework.Controls.MetroTextBox TBOriginalPassword;
        private MetroFramework.Controls.MetroTextBox TBNewPassword;
        private MetroFramework.Controls.MetroTextBox TBNewPasswordCheck;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
