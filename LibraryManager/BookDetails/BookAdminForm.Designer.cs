namespace LibraryManager.BookDetails
{
    partial class BookAdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAdminForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TLPDetail = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.LTitle = new MetroFramework.Controls.MetroLabel();
            this.LAuthor = new MetroFramework.Controls.MetroLabel();
            this.LISBN = new MetroFramework.Controls.MetroLabel();
            this.LPublicationYear = new MetroFramework.Controls.MetroLabel();
            this.LPublisher = new MetroFramework.Controls.MetroLabel();
            this.LPageCount = new MetroFramework.Controls.MetroLabel();
            this.LCategory = new MetroFramework.Controls.MetroLabel();
            this.LSection = new MetroFramework.Controls.MetroLabel();
            this.BEditBookDetail = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.GVLoanReturn = new MetroFramework.Controls.MetroGrid();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UntilWhenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LoanIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteCopyColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.GVResevations = new MetroFramework.Controls.MetroGrid();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhoMadeReservationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UntilWhenReservColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteReservationColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.LCopyCount = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.TLPDetail.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVLoanReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVResevations)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TLPDetail
            // 
            this.TLPDetail.ColumnCount = 2;
            this.TLPDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPDetail.Controls.Add(this.metroLabel3, 0, 2);
            this.TLPDetail.Controls.Add(this.metroLabel4, 0, 3);
            this.TLPDetail.Controls.Add(this.metroLabel5, 0, 4);
            this.TLPDetail.Controls.Add(this.metroLabel6, 0, 5);
            this.TLPDetail.Controls.Add(this.metroLabel7, 0, 6);
            this.TLPDetail.Controls.Add(this.metroLabel8, 0, 7);
            this.TLPDetail.Controls.Add(this.metroLabel1, 0, 0);
            this.TLPDetail.Controls.Add(this.metroLabel2, 0, 1);
            this.TLPDetail.Controls.Add(this.LTitle, 1, 0);
            this.TLPDetail.Controls.Add(this.LAuthor, 1, 1);
            this.TLPDetail.Controls.Add(this.LISBN, 1, 2);
            this.TLPDetail.Controls.Add(this.LPublicationYear, 1, 3);
            this.TLPDetail.Controls.Add(this.LPublisher, 1, 4);
            this.TLPDetail.Controls.Add(this.LPageCount, 1, 5);
            this.TLPDetail.Controls.Add(this.LCategory, 1, 6);
            this.TLPDetail.Controls.Add(this.LSection, 1, 7);
            this.TLPDetail.Controls.Add(this.BEditBookDetail, 0, 9);
            this.TLPDetail.Controls.Add(this.metroLabel9, 0, 8);
            this.TLPDetail.Controls.Add(this.LCopyCount, 1, 8);
            this.flowLayoutPanel1.SetFlowBreak(this.TLPDetail, true);
            this.TLPDetail.Location = new System.Drawing.Point(3, 3);
            this.TLPDetail.Name = "TLPDetail";
            this.TLPDetail.Padding = new System.Windows.Forms.Padding(10);
            this.TLPDetail.RowCount = 10;
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPDetail.Size = new System.Drawing.Size(259, 342);
            this.TLPDetail.TabIndex = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 48);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "ISBN:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 67);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Rok vydania:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 86);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Vydavateľstvo:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(13, 105);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Počet strán:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(13, 124);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Kategória:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(13, 143);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Sekcia:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Názov:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Autor:";
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Location = new System.Drawing.Point(119, 10);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(29, 19);
            this.LTitle.TabIndex = 8;
            this.LTitle.Text = "     ";
            // 
            // LAuthor
            // 
            this.LAuthor.AutoSize = true;
            this.LAuthor.Location = new System.Drawing.Point(119, 29);
            this.LAuthor.Name = "LAuthor";
            this.LAuthor.Size = new System.Drawing.Size(57, 19);
            this.LAuthor.TabIndex = 9;
            this.LAuthor.Text = "            ";
            // 
            // LISBN
            // 
            this.LISBN.AutoSize = true;
            this.LISBN.Location = new System.Drawing.Point(119, 48);
            this.LISBN.Name = "LISBN";
            this.LISBN.Size = new System.Drawing.Size(37, 19);
            this.LISBN.TabIndex = 10;
            this.LISBN.Text = "       ";
            // 
            // LPublicationYear
            // 
            this.LPublicationYear.AutoSize = true;
            this.LPublicationYear.Location = new System.Drawing.Point(119, 67);
            this.LPublicationYear.Name = "LPublicationYear";
            this.LPublicationYear.Size = new System.Drawing.Size(33, 19);
            this.LPublicationYear.TabIndex = 11;
            this.LPublicationYear.Text = "      ";
            // 
            // LPublisher
            // 
            this.LPublisher.AutoSize = true;
            this.LPublisher.Location = new System.Drawing.Point(119, 86);
            this.LPublisher.Name = "LPublisher";
            this.LPublisher.Size = new System.Drawing.Size(53, 19);
            this.LPublisher.TabIndex = 12;
            this.LPublisher.Text = "           ";
            // 
            // LPageCount
            // 
            this.LPageCount.AutoSize = true;
            this.LPageCount.Location = new System.Drawing.Point(119, 105);
            this.LPageCount.Name = "LPageCount";
            this.LPageCount.Size = new System.Drawing.Size(25, 19);
            this.LPageCount.TabIndex = 13;
            this.LPageCount.Text = "    ";
            // 
            // LCategory
            // 
            this.LCategory.AutoSize = true;
            this.LCategory.Location = new System.Drawing.Point(119, 124);
            this.LCategory.Name = "LCategory";
            this.LCategory.Size = new System.Drawing.Size(21, 19);
            this.LCategory.TabIndex = 14;
            this.LCategory.Text = "   ";
            // 
            // LSection
            // 
            this.LSection.AutoSize = true;
            this.LSection.Location = new System.Drawing.Point(119, 143);
            this.LSection.Name = "LSection";
            this.LSection.Size = new System.Drawing.Size(25, 19);
            this.LSection.TabIndex = 15;
            this.LSection.Text = "    ";
            // 
            // BEditBookDetail
            // 
            this.BEditBookDetail.Location = new System.Drawing.Point(13, 184);
            this.BEditBookDetail.Name = "BEditBookDetail";
            this.BEditBookDetail.Size = new System.Drawing.Size(75, 22);
            this.BEditBookDetail.TabIndex = 18;
            this.BEditBookDetail.Text = "Editovať";
            this.BEditBookDetail.UseSelectable = true;
            this.BEditBookDetail.Click += new System.EventHandler(this.BEditBookDetail_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.TLPDetail);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel10);
            this.flowLayoutPanel1.Controls.Add(this.GVLoanReturn);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel11);
            this.flowLayoutPanel1.Controls.Add(this.GVResevations);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(920, 483);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(268, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(89, 19);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "Stav výtlačkov";
            // 
            // GVLoanReturn
            // 
            this.GVLoanReturn.AllowUserToAddRows = false;
            this.GVLoanReturn.AllowUserToDeleteRows = false;
            this.GVLoanReturn.AllowUserToOrderColumns = true;
            this.GVLoanReturn.AllowUserToResizeRows = false;
            this.GVLoanReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVLoanReturn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GVLoanReturn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVLoanReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVLoanReturn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVLoanReturn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVLoanReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GVLoanReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVLoanReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.StatusColumn,
            this.WhoColumn,
            this.LoginColumn,
            this.WhenColumn,
            this.UntilWhenColumn,
            this.ButtonColumn,
            this.LoanIDColumn,
            this.DeleteCopyColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVLoanReturn.DefaultCellStyle = dataGridViewCellStyle2;
            this.GVLoanReturn.EnableHeadersVisualStyles = false;
            this.GVLoanReturn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GVLoanReturn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVLoanReturn.Location = new System.Drawing.Point(268, 22);
            this.GVLoanReturn.Name = "GVLoanReturn";
            this.GVLoanReturn.ReadOnly = true;
            this.GVLoanReturn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVLoanReturn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GVLoanReturn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVLoanReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVLoanReturn.Size = new System.Drawing.Size(517, 127);
            this.GVLoanReturn.TabIndex = 1;
            this.GVLoanReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVLoanReturn_CellContentClick);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Číslo výtlačku";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Stav";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // WhoColumn
            // 
            this.WhoColumn.HeaderText = "Kto požičal";
            this.WhoColumn.Name = "WhoColumn";
            this.WhoColumn.ReadOnly = true;
            // 
            // LoginColumn
            // 
            this.LoginColumn.HeaderText = "Login";
            this.LoginColumn.Name = "LoginColumn";
            this.LoginColumn.ReadOnly = true;
            this.LoginColumn.Visible = false;
            // 
            // WhenColumn
            // 
            this.WhenColumn.HeaderText = "Kedy";
            this.WhenColumn.Name = "WhenColumn";
            this.WhenColumn.ReadOnly = true;
            // 
            // UntilWhenColumn
            // 
            this.UntilWhenColumn.HeaderText = "Dokedy";
            this.UntilWhenColumn.Name = "UntilWhenColumn";
            this.UntilWhenColumn.ReadOnly = true;
            // 
            // ButtonColumn
            // 
            this.ButtonColumn.HeaderText = "Vrátiť/Požičať";
            this.ButtonColumn.Name = "ButtonColumn";
            this.ButtonColumn.ReadOnly = true;
            // 
            // LoanIDColumn
            // 
            this.LoanIDColumn.HeaderText = "LoanID";
            this.LoanIDColumn.Name = "LoanIDColumn";
            this.LoanIDColumn.ReadOnly = true;
            this.LoanIDColumn.Visible = false;
            // 
            // DeleteCopyColumn
            // 
            this.DeleteCopyColumn.HeaderText = "Odstrániť výtlačok";
            this.DeleteCopyColumn.Name = "DeleteCopyColumn";
            this.DeleteCopyColumn.ReadOnly = true;
            this.DeleteCopyColumn.Text = "Odstrániť";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(268, 155);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(268, 158);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(72, 19);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "Rezervácie";
            // 
            // GVResevations
            // 
            this.GVResevations.AllowUserToAddRows = false;
            this.GVResevations.AllowUserToDeleteRows = false;
            this.GVResevations.AllowUserToOrderColumns = true;
            this.GVResevations.AllowUserToResizeRows = false;
            this.GVResevations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVResevations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GVResevations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVResevations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVResevations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVResevations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVResevations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GVResevations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVResevations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.WhoMadeReservationColumn,
            this.UntilWhenReservColumn,
            this.ReservationIDColumn,
            this.DeleteReservationColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVResevations.DefaultCellStyle = dataGridViewCellStyle5;
            this.GVResevations.EnableHeadersVisualStyles = false;
            this.GVResevations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GVResevations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVResevations.Location = new System.Drawing.Point(268, 180);
            this.GVResevations.Name = "GVResevations";
            this.GVResevations.ReadOnly = true;
            this.GVResevations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVResevations.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GVResevations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVResevations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVResevations.Size = new System.Drawing.Size(517, 135);
            this.GVResevations.TabIndex = 3;
            this.GVResevations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVResevations_CellContentClick);
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Poradové číslo";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            // 
            // WhoMadeReservationColumn
            // 
            this.WhoMadeReservationColumn.HeaderText = "Kto";
            this.WhoMadeReservationColumn.Name = "WhoMadeReservationColumn";
            this.WhoMadeReservationColumn.ReadOnly = true;
            // 
            // UntilWhenReservColumn
            // 
            this.UntilWhenReservColumn.HeaderText = "Dokedy má záujem";
            this.UntilWhenReservColumn.Name = "UntilWhenReservColumn";
            this.UntilWhenReservColumn.ReadOnly = true;
            // 
            // ReservationIDColumn
            // 
            this.ReservationIDColumn.HeaderText = "ReservationNumber";
            this.ReservationIDColumn.Name = "ReservationIDColumn";
            this.ReservationIDColumn.ReadOnly = true;
            this.ReservationIDColumn.Visible = false;
            // 
            // DeleteReservationColumn
            // 
            this.DeleteReservationColumn.HeaderText = "Zrušiť rezerváciu";
            this.DeleteReservationColumn.Name = "DeleteReservationColumn";
            this.DeleteReservationColumn.ReadOnly = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(13, 162);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(100, 19);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "Počet výtlačkov:";
            // 
            // LCopyCount
            // 
            this.LCopyCount.AutoSize = true;
            this.LCopyCount.Location = new System.Drawing.Point(119, 162);
            this.LCopyCount.Name = "LCopyCount";
            this.LCopyCount.Size = new System.Drawing.Size(45, 19);
            this.LCopyCount.TabIndex = 20;
            this.LCopyCount.Text = "         ";
            // 
            // BookAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 465);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookAdminForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Detail knihy";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.BookAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.TLPDetail.ResumeLayout(false);
            this.TLPDetail.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVLoanReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVResevations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.TableLayoutPanel TLPDetail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel LTitle;
        private MetroFramework.Controls.MetroLabel LAuthor;
        private MetroFramework.Controls.MetroLabel LISBN;
        private MetroFramework.Controls.MetroLabel LPublicationYear;
        private MetroFramework.Controls.MetroLabel LPublisher;
        private MetroFramework.Controls.MetroLabel LPageCount;
        private MetroFramework.Controls.MetroLabel LCategory;
        private MetroFramework.Controls.MetroLabel LSection;
        private MetroFramework.Controls.MetroButton BEditBookDetail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroGrid GVLoanReturn;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroGrid GVResevations;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhoMadeReservationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntilWhenReservColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationIDColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteReservationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntilWhenColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanIDColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCopyColumn;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel LCopyCount;
    }
}