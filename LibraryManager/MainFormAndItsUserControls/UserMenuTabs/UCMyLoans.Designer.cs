namespace LibraryManager.UserMenuTabs
{
    partial class UCMyLoans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GVLoans = new MetroFramework.Controls.MetroGrid();
            this.TitleLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UntilWhenLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.GVReservations = new MetroFramework.Controls.MetroGrid();
            this.ReservationIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleRColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorRColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyCountRColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UntilWhenRColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteReservation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVReservations)).BeginInit();
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
            this.flowLayoutPanel1.Controls.Add(this.metroLabel1);
            this.flowLayoutPanel1.Controls.Add(this.GVLoans);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel2);
            this.flowLayoutPanel1.Controls.Add(this.GVReservations);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(547, 411);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Výpožičky";
            // 
            // GVLoans
            // 
            this.GVLoans.AllowUserToAddRows = false;
            this.GVLoans.AllowUserToDeleteRows = false;
            this.GVLoans.AllowUserToOrderColumns = true;
            this.GVLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVLoans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GVLoans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVLoans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVLoans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVLoans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GVLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleLColumn,
            this.AuthorLColumn,
            this.UntilWhenLColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVLoans.DefaultCellStyle = dataGridViewCellStyle8;
            this.GVLoans.EnableHeadersVisualStyles = false;
            this.GVLoans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GVLoans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVLoans.Location = new System.Drawing.Point(3, 42);
            this.GVLoans.Name = "GVLoans";
            this.GVLoans.ReadOnly = true;
            this.GVLoans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVLoans.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GVLoans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVLoans.Size = new System.Drawing.Size(518, 150);
            this.GVLoans.TabIndex = 1;
            // 
            // TitleLColumn
            // 
            this.TitleLColumn.HeaderText = "Názov knihy";
            this.TitleLColumn.Name = "TitleLColumn";
            this.TitleLColumn.ReadOnly = true;
            // 
            // AuthorLColumn
            // 
            this.AuthorLColumn.HeaderText = "Autor";
            this.AuthorLColumn.Name = "AuthorLColumn";
            this.AuthorLColumn.ReadOnly = true;
            // 
            // UntilWhenLColumn
            // 
            this.UntilWhenLColumn.HeaderText = "Dokedy";
            this.UntilWhenLColumn.Name = "UntilWhenLColumn";
            this.UntilWhenLColumn.ReadOnly = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 215);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Rezervácie";
            // 
            // GVReservations
            // 
            this.GVReservations.AllowUserToAddRows = false;
            this.GVReservations.AllowUserToDeleteRows = false;
            this.GVReservations.AllowUserToOrderColumns = true;
            this.GVReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GVReservations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GVReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationIDColumn,
            this.TitleRColumn,
            this.AuthorRColumn,
            this.CopyCountRColumn,
            this.UntilWhenRColumn,
            this.DeleteReservation});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVReservations.DefaultCellStyle = dataGridViewCellStyle11;
            this.GVReservations.EnableHeadersVisualStyles = false;
            this.GVReservations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GVReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVReservations.Location = new System.Drawing.Point(3, 237);
            this.GVReservations.Name = "GVReservations";
            this.GVReservations.ReadOnly = true;
            this.GVReservations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GVReservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVReservations.Size = new System.Drawing.Size(518, 150);
            this.GVReservations.TabIndex = 4;
            this.GVReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVReservations_CellContentClick);
            // 
            // ReservationIDColumn
            // 
            this.ReservationIDColumn.HeaderText = "ReservationIDColumn";
            this.ReservationIDColumn.Name = "ReservationIDColumn";
            this.ReservationIDColumn.ReadOnly = true;
            this.ReservationIDColumn.Visible = false;
            // 
            // TitleRColumn
            // 
            this.TitleRColumn.HeaderText = "Názov knihy";
            this.TitleRColumn.Name = "TitleRColumn";
            this.TitleRColumn.ReadOnly = true;
            // 
            // AuthorRColumn
            // 
            this.AuthorRColumn.HeaderText = "Autor";
            this.AuthorRColumn.Name = "AuthorRColumn";
            this.AuthorRColumn.ReadOnly = true;
            // 
            // CopyCountRColumn
            // 
            this.CopyCountRColumn.HeaderText = "Počet kusov";
            this.CopyCountRColumn.Name = "CopyCountRColumn";
            this.CopyCountRColumn.ReadOnly = true;
            // 
            // UntilWhenRColumn
            // 
            this.UntilWhenRColumn.HeaderText = "Dokedy";
            this.UntilWhenRColumn.Name = "UntilWhenRColumn";
            this.UntilWhenRColumn.ReadOnly = true;
            // 
            // DeleteReservation
            // 
            this.DeleteReservation.HeaderText = "Zrušiť rezerváciu";
            this.DeleteReservation.Name = "DeleteReservation";
            this.DeleteReservation.ReadOnly = true;
            this.DeleteReservation.Text = "Zrušiť";
            // 
            // UCMyLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCMyLoans";
            this.Size = new System.Drawing.Size(547, 411);
            this.Load += new System.EventHandler(this.UCMyLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid GVLoans;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleLColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorLColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntilWhenLColumn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid GVReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleRColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorRColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyCountRColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntilWhenRColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteReservation;
    }
}
