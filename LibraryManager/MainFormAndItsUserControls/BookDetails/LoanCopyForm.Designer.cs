namespace LibraryManager.BookDetails
{
    partial class LoanCopyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanCopyForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BLoan = new MetroFramework.Controls.MetroButton();
            this.DTUntilWhen = new MetroFramework.Controls.MetroDateTime();
            this.CBWho = new MetroFramework.Controls.MetroComboBox();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BLoan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DTUntilWhen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CBWho, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Komu:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Dokedy:";
            // 
            // BLoan
            // 
            this.BLoan.Location = new System.Drawing.Point(3, 73);
            this.BLoan.Name = "BLoan";
            this.BLoan.Size = new System.Drawing.Size(75, 23);
            this.BLoan.TabIndex = 2;
            this.BLoan.Text = "Hotovo";
            this.BLoan.UseSelectable = true;
            this.BLoan.Click += new System.EventHandler(this.BLoan_Click);
            // 
            // DTUntilWhen
            // 
            this.DTUntilWhen.CustomFormat = "dd/MM/yyyy";
            this.DTUntilWhen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTUntilWhen.Location = new System.Drawing.Point(84, 38);
            this.DTUntilWhen.MinimumSize = new System.Drawing.Size(0, 29);
            this.DTUntilWhen.Name = "DTUntilWhen";
            this.DTUntilWhen.Size = new System.Drawing.Size(184, 29);
            this.DTUntilWhen.TabIndex = 3;
            this.DTUntilWhen.Validating += new System.ComponentModel.CancelEventHandler(this.DTUntilWhen_Validating);
            // 
            // CBWho
            // 
            this.CBWho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBWho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CBWho.FormattingEnabled = true;
            this.CBWho.ItemHeight = 23;
            this.CBWho.Location = new System.Drawing.Point(84, 3);
            this.CBWho.Name = "CBWho";
            this.CBWho.Size = new System.Drawing.Size(184, 29);
            this.CBWho.TabIndex = 4;
            this.CBWho.UseSelectable = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LoanCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 209);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoanCopyForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Požičať knihu";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.LoanCopyForm_Load);
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BLoan;
        private MetroFramework.Controls.MetroDateTime DTUntilWhen;
        private MetroFramework.Controls.MetroComboBox CBWho;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}