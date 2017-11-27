namespace ChelseaHotel_ManagementSystem
{
    partial class viewListOfAvailableRooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.availableRoomsDatagridView = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doubleRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suiteRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookRoom_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateFrom_lbl = new System.Windows.Forms.Label();
            this.dateTo_lbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomsDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.availableRoomsDatagridView);
            this.panel3.Controls.Add(this.back_btn);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1361, 596);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(49, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Manage Room";
            // 
            // availableRoomsDatagridView
            // 
            this.availableRoomsDatagridView.AllowUserToOrderColumns = true;
            this.availableRoomsDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availableRoomsDatagridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.availableRoomsDatagridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.availableRoomsDatagridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.availableRoomsDatagridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availableRoomsDatagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.availableRoomsDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableRoomsDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.singleRoom,
            this.doubleRoom,
            this.suiteRoom,
            this.totalCapacity});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availableRoomsDatagridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.availableRoomsDatagridView.Location = new System.Drawing.Point(340, 208);
            this.availableRoomsDatagridView.Name = "availableRoomsDatagridView";
            this.availableRoomsDatagridView.ReadOnly = true;
            this.availableRoomsDatagridView.RowHeadersWidth = 45;
            this.availableRoomsDatagridView.Size = new System.Drawing.Size(953, 265);
            this.availableRoomsDatagridView.TabIndex = 22;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // singleRoom
            // 
            this.singleRoom.HeaderText = "Single Room";
            this.singleRoom.Name = "singleRoom";
            this.singleRoom.ReadOnly = true;
            // 
            // doubleRoom
            // 
            this.doubleRoom.HeaderText = "Double Room";
            this.doubleRoom.Name = "doubleRoom";
            this.doubleRoom.ReadOnly = true;
            // 
            // suiteRoom
            // 
            this.suiteRoom.HeaderText = "Suite Room";
            this.suiteRoom.Name = "suiteRoom";
            this.suiteRoom.ReadOnly = true;
            // 
            // totalCapacity
            // 
            this.totalCapacity.HeaderText = "Total Capacity";
            this.totalCapacity.Name = "totalCapacity";
            this.totalCapacity.ReadOnly = true;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.back_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.back_btn.FlatAppearance.BorderSize = 2;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.back_btn.Location = new System.Drawing.Point(3, 348);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(283, 41);
            this.back_btn.TabIndex = 21;
            this.back_btn.Text = "Main Menu";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChelseaHotel_ManagementSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookRoom_btn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.dateFrom_lbl);
            this.groupBox1.Controls.Add(this.dateTo_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.groupBox1.Location = new System.Drawing.Point(322, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 531);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Available Rooms";
            // 
            // bookRoom_btn
            // 
            this.bookRoom_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.bookRoom_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.bookRoom_btn.FlatAppearance.BorderSize = 2;
            this.bookRoom_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookRoom_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.bookRoom_btn.Location = new System.Drawing.Point(399, 469);
            this.bookRoom_btn.Name = "bookRoom_btn";
            this.bookRoom_btn.Size = new System.Drawing.Size(283, 41);
            this.bookRoom_btn.TabIndex = 13;
            this.bookRoom_btn.Text = "Book Room";
            this.bookRoom_btn.UseVisualStyleBackColor = false;
            this.bookRoom_btn.Click += new System.EventHandler(this.bookRoom_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button1.Location = new System.Drawing.Point(688, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerFromDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dateTimePickerFromDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.dateTimePickerFromDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.dateTimePickerFromDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dateTimePickerFromDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(323, 87);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(210, 38);
            this.dateTimePickerFromDate.TabIndex = 9;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerToDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dateTimePickerToDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.dateTimePickerToDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.dateTimePickerToDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dateTimePickerToDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(604, 87);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(210, 38);
            this.dateTimePickerToDate.TabIndex = 11;
            // 
            // dateFrom_lbl
            // 
            this.dateFrom_lbl.AutoSize = true;
            this.dateFrom_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.dateFrom_lbl.Location = new System.Drawing.Point(319, 53);
            this.dateFrom_lbl.Name = "dateFrom_lbl";
            this.dateFrom_lbl.Size = new System.Drawing.Size(143, 22);
            this.dateFrom_lbl.TabIndex = 8;
            this.dateFrom_lbl.Text = "Pick Date From: ";
            // 
            // dateTo_lbl
            // 
            this.dateTo_lbl.AutoSize = true;
            this.dateTo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.dateTo_lbl.Location = new System.Drawing.Point(600, 53);
            this.dateTo_lbl.Name = "dateTo_lbl";
            this.dateTo_lbl.Size = new System.Drawing.Size(119, 22);
            this.dateTo_lbl.TabIndex = 10;
            this.dateTo_lbl.Text = "Pick Date To:";
            // 
            // viewListOfAvailableRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1386, 622);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewListOfAvailableRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display List Of Available Rooms";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomsDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView availableRoomsDatagridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn singleRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn doubleRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn suiteRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCapacity;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bookRoom_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label dateFrom_lbl;
        private System.Windows.Forms.Label dateTo_lbl;
    }
}