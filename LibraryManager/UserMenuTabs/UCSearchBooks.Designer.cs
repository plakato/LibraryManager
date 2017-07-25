namespace LibraryManager
{
    partial class UCSearchBooks
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.CBPublicationYearFrom = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.CBPublicationYearTo = new MetroFramework.Controls.MetroComboBox();
            this.CBPublisher = new MetroFramework.Controls.MetroComboBox();
            this.CBCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TBSector = new MetroFramework.Controls.MetroTextBox();
            this.TBisbn = new MetroFramework.Controls.MetroTextBox();
            this.TBAuthor = new MetroFramework.Controls.MetroTextBox();
            this.TBTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.CBPageCountFrom = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.CBPageCountTo = new MetroFramework.Controls.MetroComboBox();
            this.TLPConditions = new System.Windows.Forms.TableLayoutPanel();
            this.BSearch = new MetroFramework.Controls.MetroButton();
            this.LVResults = new MetroFramework.Controls.MetroListView();
            this.TitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.TLPConditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.metroLabel9);
            this.flowLayoutPanel1.Controls.Add(this.CBPublicationYearFrom);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel10);
            this.flowLayoutPanel1.Controls.Add(this.CBPublicationYearTo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(313, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 40);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(25, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "od";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBPublicationYearFrom
            // 
            this.CBPublicationYearFrom.FormattingEnabled = true;
            this.CBPublicationYearFrom.ItemHeight = 23;
            this.CBPublicationYearFrom.Location = new System.Drawing.Point(34, 3);
            this.CBPublicationYearFrom.Name = "CBPublicationYearFrom";
            this.CBPublicationYearFrom.Size = new System.Drawing.Size(90, 29);
            this.CBPublicationYearFrom.TabIndex = 1;
            this.CBPublicationYearFrom.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(130, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(25, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "do";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBPublicationYearTo
            // 
            this.CBPublicationYearTo.FormattingEnabled = true;
            this.CBPublicationYearTo.ItemHeight = 23;
            this.CBPublicationYearTo.Location = new System.Drawing.Point(161, 3);
            this.CBPublicationYearTo.Name = "CBPublicationYearTo";
            this.CBPublicationYearTo.Size = new System.Drawing.Size(90, 29);
            this.CBPublicationYearTo.TabIndex = 3;
            this.CBPublicationYearTo.UseSelectable = true;
            // 
            // CBPublisher
            // 
            this.CBPublisher.FormattingEnabled = true;
            this.CBPublisher.ItemHeight = 23;
            this.CBPublisher.Location = new System.Drawing.Point(313, 48);
            this.CBPublisher.Name = "CBPublisher";
            this.CBPublisher.Size = new System.Drawing.Size(121, 29);
            this.CBPublisher.TabIndex = 13;
            this.CBPublisher.UseSelectable = true;
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.ItemHeight = 23;
            this.CBCategory.Location = new System.Drawing.Point(313, 13);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(121, 29);
            this.CBCategory.TabIndex = 12;
            this.CBCategory.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(215, 126);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(73, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Počet strán";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(215, 80);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Rok vydania:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(215, 45);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Vydavateľstvo:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(215, 10);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Kategória:";
            // 
            // TBSector
            // 
            // 
            // 
            // 
            this.TBSector.CustomButton.Image = null;
            this.TBSector.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.TBSector.CustomButton.Name = "";
            this.TBSector.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBSector.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBSector.CustomButton.TabIndex = 1;
            this.TBSector.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBSector.CustomButton.UseSelectable = true;
            this.TBSector.CustomButton.Visible = false;
            this.TBSector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBSector.Lines = new string[0];
            this.TBSector.Location = new System.Drawing.Point(69, 129);
            this.TBSector.MaxLength = 32767;
            this.TBSector.Name = "TBSector";
            this.TBSector.PasswordChar = '\0';
            this.TBSector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBSector.SelectedText = "";
            this.TBSector.SelectionLength = 0;
            this.TBSector.SelectionStart = 0;
            this.TBSector.ShortcutsEnabled = true;
            this.TBSector.Size = new System.Drawing.Size(120, 23);
            this.TBSector.TabIndex = 7;
            this.TBSector.UseSelectable = true;
            this.TBSector.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBSector.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TBisbn
            // 
            // 
            // 
            // 
            this.TBisbn.CustomButton.Image = null;
            this.TBisbn.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.TBisbn.CustomButton.Name = "";
            this.TBisbn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBisbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBisbn.CustomButton.TabIndex = 1;
            this.TBisbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBisbn.CustomButton.UseSelectable = true;
            this.TBisbn.CustomButton.Visible = false;
            this.TBisbn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBisbn.Lines = new string[0];
            this.TBisbn.Location = new System.Drawing.Point(69, 83);
            this.TBisbn.MaxLength = 32767;
            this.TBisbn.Name = "TBisbn";
            this.TBisbn.PasswordChar = '\0';
            this.TBisbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBisbn.SelectedText = "";
            this.TBisbn.SelectionLength = 0;
            this.TBisbn.SelectionStart = 0;
            this.TBisbn.ShortcutsEnabled = true;
            this.TBisbn.Size = new System.Drawing.Size(120, 23);
            this.TBisbn.TabIndex = 6;
            this.TBisbn.UseSelectable = true;
            this.TBisbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBisbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TBAuthor
            // 
            // 
            // 
            // 
            this.TBAuthor.CustomButton.Image = null;
            this.TBAuthor.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.TBAuthor.CustomButton.Name = "";
            this.TBAuthor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBAuthor.CustomButton.TabIndex = 1;
            this.TBAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBAuthor.CustomButton.UseSelectable = true;
            this.TBAuthor.CustomButton.Visible = false;
            this.TBAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBAuthor.Lines = new string[0];
            this.TBAuthor.Location = new System.Drawing.Point(69, 48);
            this.TBAuthor.MaxLength = 32767;
            this.TBAuthor.Name = "TBAuthor";
            this.TBAuthor.PasswordChar = '\0';
            this.TBAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBAuthor.SelectedText = "";
            this.TBAuthor.SelectionLength = 0;
            this.TBAuthor.SelectionStart = 0;
            this.TBAuthor.ShortcutsEnabled = true;
            this.TBAuthor.Size = new System.Drawing.Size(120, 23);
            this.TBAuthor.TabIndex = 5;
            this.TBAuthor.UseSelectable = true;
            this.TBAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TBTitle
            // 
            // 
            // 
            // 
            this.TBTitle.CustomButton.Image = null;
            this.TBTitle.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.TBTitle.CustomButton.Name = "";
            this.TBTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBTitle.CustomButton.TabIndex = 1;
            this.TBTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBTitle.CustomButton.UseSelectable = true;
            this.TBTitle.CustomButton.Visible = false;
            this.TBTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBTitle.Lines = new string[0];
            this.TBTitle.Location = new System.Drawing.Point(69, 13);
            this.TBTitle.MaxLength = 32767;
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.PasswordChar = '\0';
            this.TBTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBTitle.SelectedText = "";
            this.TBTitle.SelectionLength = 0;
            this.TBTitle.SelectionStart = 0;
            this.TBTitle.ShortcutsEnabled = true;
            this.TBTitle.Size = new System.Drawing.Size(120, 23);
            this.TBTitle.TabIndex = 4;
            this.TBTitle.UseSelectable = true;
            this.TBTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 126);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Sektor:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "ISBN:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 45);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Autor:";
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.metroLabel11);
            this.flowLayoutPanel2.Controls.Add(this.CBPageCountFrom);
            this.flowLayoutPanel2.Controls.Add(this.metroLabel12);
            this.flowLayoutPanel2.Controls.Add(this.CBPageCountTo);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(313, 129);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(321, 59);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(25, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "od";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBPageCountFrom
            // 
            this.CBPageCountFrom.FormattingEnabled = true;
            this.CBPageCountFrom.ItemHeight = 23;
            this.CBPageCountFrom.Location = new System.Drawing.Point(34, 3);
            this.CBPageCountFrom.Name = "CBPageCountFrom";
            this.CBPageCountFrom.Size = new System.Drawing.Size(90, 29);
            this.CBPageCountFrom.TabIndex = 1;
            this.CBPageCountFrom.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(130, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(25, 19);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "do";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBPageCountTo
            // 
            this.CBPageCountTo.FormattingEnabled = true;
            this.CBPageCountTo.ItemHeight = 23;
            this.CBPageCountTo.Location = new System.Drawing.Point(161, 3);
            this.CBPageCountTo.Name = "CBPageCountTo";
            this.CBPageCountTo.Size = new System.Drawing.Size(90, 29);
            this.CBPageCountTo.TabIndex = 3;
            this.CBPageCountTo.UseSelectable = true;
            // 
            // TLPConditions
            // 
            this.TLPConditions.AutoSize = true;
            this.TLPConditions.BackColor = System.Drawing.Color.Transparent;
            this.TLPConditions.ColumnCount = 5;
            this.TLPConditions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPConditions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPConditions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPConditions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPConditions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPConditions.Controls.Add(this.flowLayoutPanel2, 4, 3);
            this.TLPConditions.Controls.Add(this.metroLabel1, 0, 0);
            this.TLPConditions.Controls.Add(this.BSearch, 4, 5);
            this.TLPConditions.Controls.Add(this.metroLabel2, 0, 1);
            this.TLPConditions.Controls.Add(this.metroLabel3, 0, 2);
            this.TLPConditions.Controls.Add(this.metroLabel4, 0, 3);
            this.TLPConditions.Controls.Add(this.TBTitle, 1, 0);
            this.TLPConditions.Controls.Add(this.TBAuthor, 1, 1);
            this.TLPConditions.Controls.Add(this.TBisbn, 1, 2);
            this.TLPConditions.Controls.Add(this.TBSector, 1, 3);
            this.TLPConditions.Controls.Add(this.metroLabel5, 3, 0);
            this.TLPConditions.Controls.Add(this.metroLabel6, 3, 1);
            this.TLPConditions.Controls.Add(this.metroLabel7, 3, 2);
            this.TLPConditions.Controls.Add(this.metroLabel8, 3, 3);
            this.TLPConditions.Controls.Add(this.CBCategory, 4, 0);
            this.TLPConditions.Controls.Add(this.CBPublisher, 4, 1);
            this.TLPConditions.Controls.Add(this.flowLayoutPanel1, 4, 2);
            this.TLPConditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPConditions.Location = new System.Drawing.Point(0, 0);
            this.TLPConditions.Name = "TLPConditions";
            this.TLPConditions.Padding = new System.Windows.Forms.Padding(10);
            this.TLPConditions.RowCount = 6;
            this.TLPConditions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPConditions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPConditions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPConditions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPConditions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPConditions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPConditions.Size = new System.Drawing.Size(647, 237);
            this.TLPConditions.TabIndex = 0;
            // 
            // BSearch
            // 
            this.BSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BSearch.Location = new System.Drawing.Point(542, 194);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(92, 30);
            this.BSearch.TabIndex = 16;
            this.BSearch.Text = "Hľadaj";
            this.BSearch.UseSelectable = true;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // LVResults
            // 
            this.LVResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleColumn,
            this.AuthorColumn,
            this.StatusColumn});
            this.LVResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVResults.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LVResults.FullRowSelect = true;
            this.LVResults.Location = new System.Drawing.Point(0, 237);
            this.LVResults.MultiSelect = false;
            this.LVResults.Name = "LVResults";
            this.LVResults.OwnerDraw = true;
            this.LVResults.Size = new System.Drawing.Size(647, 209);
            this.LVResults.TabIndex = 1;
            this.LVResults.UseCompatibleStateImageBehavior = false;
            this.LVResults.UseSelectable = true;
            this.LVResults.View = System.Windows.Forms.View.Details;
            this.LVResults.Visible = false;
            this.LVResults.ItemActivate += new System.EventHandler(this.LVResults_ItemActivate);
            this.LVResults.Resize += new System.EventHandler(this.LVResults_Resize);
            // 
            // TitleColumn
            // 
            this.TitleColumn.Text = "Názov";
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.Text = "Autor";
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Stav";
            // 
            // UCSearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LVResults);
            this.Controls.Add(this.TLPConditions);
            this.Name = "UCSearchBooks";
            this.Size = new System.Drawing.Size(647, 446);
            this.Load += new System.EventHandler(this.UCSearchBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.TLPConditions.ResumeLayout(false);
            this.TLPConditions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.TableLayoutPanel TLPConditions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox CBPageCountFrom;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox CBPageCountTo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TBTitle;
        private MetroFramework.Controls.MetroTextBox TBAuthor;
        private MetroFramework.Controls.MetroTextBox TBisbn;
        private MetroFramework.Controls.MetroTextBox TBSector;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox CBCategory;
        private MetroFramework.Controls.MetroComboBox CBPublisher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox CBPublicationYearFrom;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox CBPublicationYearTo;
        private MetroFramework.Controls.MetroListView LVResults;
        private System.Windows.Forms.ColumnHeader TitleColumn;
        private System.Windows.Forms.ColumnHeader AuthorColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private MetroFramework.Controls.MetroButton BSearch;
    }
}
