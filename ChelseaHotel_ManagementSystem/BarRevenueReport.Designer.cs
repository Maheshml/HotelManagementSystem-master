namespace ChelseaHotel_ManagementSystem
{
    partial class BarRevenueReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTo_lbl = new System.Windows.Forms.Label();
            this.dateFrom_lbl = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.report_groupBox = new System.Windows.Forms.GroupBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.monthlyReport_btn = new System.Windows.Forms.Button();
            this.dailyReport_btn = new System.Windows.Forms.Button();
            this.weeklyReport_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.report_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.report_groupBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 515);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChelseaHotel_ManagementSystem.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 199);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dateTo_lbl);
            this.groupBox1.Controls.Add(this.dateFrom_lbl);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.groupBox1.Location = new System.Drawing.Point(220, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 277);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Dynamic Report";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button5.Location = new System.Drawing.Point(887, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 41);
            this.button5.TabIndex = 17;
            this.button5.Text = "Submit";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dateTo_lbl
            // 
            this.dateTo_lbl.AutoSize = true;
            this.dateTo_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.dateTo_lbl.Location = new System.Drawing.Point(58, 89);
            this.dateTo_lbl.Name = "dateTo_lbl";
            this.dateTo_lbl.Size = new System.Drawing.Size(66, 20);
            this.dateTo_lbl.TabIndex = 14;
            this.dateTo_lbl.Text = "Date To";
            // 
            // dateFrom_lbl
            // 
            this.dateFrom_lbl.AutoSize = true;
            this.dateFrom_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.dateFrom_lbl.Location = new System.Drawing.Point(39, 49);
            this.dateFrom_lbl.Name = "dateFrom_lbl";
            this.dateFrom_lbl.Size = new System.Drawing.Size(85, 20);
            this.dateFrom_lbl.TabIndex = 12;
            this.dateFrom_lbl.Text = "Date From";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dateTimePicker2.Location = new System.Drawing.Point(130, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(272, 26);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // report_groupBox
            // 
            this.report_groupBox.Controls.Add(this.submit_btn);
            this.report_groupBox.Controls.Add(this.monthlyReport_btn);
            this.report_groupBox.Controls.Add(this.dailyReport_btn);
            this.report_groupBox.Controls.Add(this.weeklyReport_btn);
            this.report_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.report_groupBox.Location = new System.Drawing.Point(220, 5);
            this.report_groupBox.Name = "report_groupBox";
            this.report_groupBox.Size = new System.Drawing.Size(1035, 186);
            this.report_groupBox.TabIndex = 11;
            this.report_groupBox.TabStop = false;
            this.report_groupBox.Text = "Select One Of the Default Reports";
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.submit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(887, 139);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(142, 41);
            this.submit_btn.TabIndex = 11;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = false;
            // 
            // monthlyReport_btn
            // 
            this.monthlyReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.monthlyReport_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.monthlyReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthlyReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyReport_btn.Location = new System.Drawing.Point(535, 93);
            this.monthlyReport_btn.Name = "monthlyReport_btn";
            this.monthlyReport_btn.Size = new System.Drawing.Size(246, 41);
            this.monthlyReport_btn.TabIndex = 10;
            this.monthlyReport_btn.Text = "Monthly Report";
            this.monthlyReport_btn.UseVisualStyleBackColor = false;
            // 
            // dailyReport_btn
            // 
            this.dailyReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dailyReport_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.dailyReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReport_btn.Location = new System.Drawing.Point(31, 93);
            this.dailyReport_btn.Name = "dailyReport_btn";
            this.dailyReport_btn.Size = new System.Drawing.Size(246, 41);
            this.dailyReport_btn.TabIndex = 8;
            this.dailyReport_btn.Text = "Daily Report";
            this.dailyReport_btn.UseVisualStyleBackColor = false;
            // 
            // weeklyReport_btn
            // 
            this.weeklyReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.weeklyReport_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.weeklyReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weeklyReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyReport_btn.Location = new System.Drawing.Point(283, 93);
            this.weeklyReport_btn.Name = "weeklyReport_btn";
            this.weeklyReport_btn.Size = new System.Drawing.Size(246, 41);
            this.weeklyReport_btn.TabIndex = 9;
            this.weeklyReport_btn.Text = "Weekly Report";
            this.weeklyReport_btn.UseVisualStyleBackColor = false;
            // 
            // BarRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1338, 568);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.Name = "BarRevenueReport";
            this.Text = "ReportBar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.report_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label dateTo_lbl;
        private System.Windows.Forms.Label dateFrom_lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox report_groupBox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button monthlyReport_btn;
        private System.Windows.Forms.Button dailyReport_btn;
        private System.Windows.Forms.Button weeklyReport_btn;
    }
}