namespace ChelseaHotel_ManagementSystem
{
    partial class viewInventory
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
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiringDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.getReport_btn = new System.Windows.Forms.Button();
            this.setupMenu_btn = new System.Windows.Forms.Button();
            this.checkRoster_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.manageSupplier_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.placeStockOrer_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.itemNameOK_btn = new System.Windows.Forms.Button();
            this.itemName_textBox1 = new System.Windows.Forms.TextBox();
            this.itemName_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.inventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inventoryGrid.ColumnHeadersHeight = 30;
            this.inventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemDescription,
            this.qtyAvailable,
            this.expiringDate});
            this.inventoryGrid.Location = new System.Drawing.Point(26, 41);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.Size = new System.Drawing.Size(944, 196);
            this.inventoryGrid.TabIndex = 7;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemDescription
            // 
            this.itemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemDescription.HeaderText = "Item Description";
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.ReadOnly = true;
            // 
            // qtyAvailable
            // 
            this.qtyAvailable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtyAvailable.HeaderText = "Qantity Available";
            this.qtyAvailable.Name = "qtyAvailable";
            this.qtyAvailable.ReadOnly = true;
            // 
            // expiringDate
            // 
            this.expiringDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expiringDate.HeaderText = "Expiring Date";
            this.expiringDate.Name = "expiringDate";
            this.expiringDate.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.itemNameOK_btn);
            this.panel1.Controls.Add(this.itemName_textBox1);
            this.panel1.Controls.Add(this.itemName_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.getReport_btn);
            this.panel1.Controls.Add(this.setupMenu_btn);
            this.panel1.Controls.Add(this.checkRoster_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.manageSupplier_btn);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(32, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 515);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(247, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "View Inventory";
            // 
            // getReport_btn
            // 
            this.getReport_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.getReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getReport_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.getReport_btn.Location = new System.Drawing.Point(3, 451);
            this.getReport_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.getReport_btn.Name = "getReport_btn";
            this.getReport_btn.Size = new System.Drawing.Size(202, 36);
            this.getReport_btn.TabIndex = 6;
            this.getReport_btn.Text = "Get Report";
            this.getReport_btn.UseVisualStyleBackColor = true;
            this.getReport_btn.Click += new System.EventHandler(this.getReport_btn_Click);
            // 
            // setupMenu_btn
            // 
            this.setupMenu_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.setupMenu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setupMenu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupMenu_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.setupMenu_btn.Location = new System.Drawing.Point(3, 405);
            this.setupMenu_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.setupMenu_btn.Name = "setupMenu_btn";
            this.setupMenu_btn.Size = new System.Drawing.Size(202, 36);
            this.setupMenu_btn.TabIndex = 5;
            this.setupMenu_btn.Text = "Setup Menu";
            this.setupMenu_btn.UseVisualStyleBackColor = true;
            this.setupMenu_btn.Click += new System.EventHandler(this.setupMenu_btn_Click);
            // 
            // checkRoster_btn
            // 
            this.checkRoster_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.checkRoster_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkRoster_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRoster_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.checkRoster_btn.Location = new System.Drawing.Point(3, 267);
            this.checkRoster_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkRoster_btn.Name = "checkRoster_btn";
            this.checkRoster_btn.Size = new System.Drawing.Size(202, 36);
            this.checkRoster_btn.TabIndex = 2;
            this.checkRoster_btn.Text = "Check Roster";
            this.checkRoster_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button1.Location = new System.Drawing.Point(3, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manage Stock";
            this.button1.Click += new System.EventHandler(this.manageStock_btn_Click);
            // 
            // manageSupplier_btn
            // 
            this.manageSupplier_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.manageSupplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageSupplier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSupplier_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.manageSupplier_btn.Location = new System.Drawing.Point(3, 359);
            this.manageSupplier_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.manageSupplier_btn.Name = "manageSupplier_btn";
            this.manageSupplier_btn.Size = new System.Drawing.Size(202, 36);
            this.manageSupplier_btn.TabIndex = 4;
            this.manageSupplier_btn.Text = "Manage Suppliers";
            this.manageSupplier_btn.UseVisualStyleBackColor = true;
            this.manageSupplier_btn.Click += new System.EventHandler(this.manageSupplier_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.home_btn.Location = new System.Drawing.Point(3, 221);
            this.home_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(202, 36);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ChelseaHotel_ManagementSystem.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 199);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.placeStockOrer_btn);
            this.groupBox1.Controls.Add(this.inventoryGrid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.groupBox1.Location = new System.Drawing.Point(253, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 307);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Details";
            // 
            // placeStockOrer_btn
            // 
            this.placeStockOrer_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.placeStockOrer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeStockOrer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeStockOrer_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.placeStockOrer_btn.Location = new System.Drawing.Point(768, 258);
            this.placeStockOrer_btn.Margin = new System.Windows.Forms.Padding(10);
            this.placeStockOrer_btn.Name = "placeStockOrer_btn";
            this.placeStockOrer_btn.Size = new System.Drawing.Size(202, 36);
            this.placeStockOrer_btn.TabIndex = 9;
            this.placeStockOrer_btn.Text = "Place Stock Order";
            this.placeStockOrer_btn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button2.Location = new System.Drawing.Point(788, 86);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "View All Inventory";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // itemNameOK_btn
            // 
            this.itemNameOK_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.itemNameOK_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemNameOK_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameOK_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.itemNameOK_btn.Location = new System.Drawing.Point(676, 86);
            this.itemNameOK_btn.Margin = new System.Windows.Forms.Padding(10);
            this.itemNameOK_btn.Name = "itemNameOK_btn";
            this.itemNameOK_btn.Size = new System.Drawing.Size(90, 36);
            this.itemNameOK_btn.TabIndex = 27;
            this.itemNameOK_btn.Text = "View Item";
            this.itemNameOK_btn.UseVisualStyleBackColor = true;
            // 
            // itemName_textBox1
            // 
            this.itemName_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_textBox1.Location = new System.Drawing.Point(372, 91);
            this.itemName_textBox1.Name = "itemName_textBox1";
            this.itemName_textBox1.Size = new System.Drawing.Size(291, 26);
            this.itemName_textBox1.TabIndex = 26;
            // 
            // itemName_lbl
            // 
            this.itemName_lbl.AutoSize = true;
            this.itemName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.itemName_lbl.Location = new System.Drawing.Point(275, 94);
            this.itemName_lbl.Name = "itemName_lbl";
            this.itemName_lbl.Size = new System.Drawing.Size(91, 20);
            this.itemName_lbl.TabIndex = 25;
            this.itemName_lbl.Text = "Item Name:";
            // 
            // ViewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1338, 568);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Inventory";
            this.Load += new System.EventHandler(this.ViewInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView inventoryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiringDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button getReport_btn;
        private System.Windows.Forms.Button setupMenu_btn;
        private System.Windows.Forms.Button checkRoster_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button manageSupplier_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button placeStockOrer_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button itemNameOK_btn;
        private System.Windows.Forms.TextBox itemName_textBox1;
        private System.Windows.Forms.Label itemName_lbl;
    }
}