namespace ChelseaHotel_ManagementSystem
{
    partial class TakeOrder
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_TitleAddRoom = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Items = new System.Windows.Forms.DataGridView();
            this.Column_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_barPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_RemoveRow = new System.Windows.Forms.Button();
            this.button_Generate = new System.Windows.Forms.Button();
            this.comboBox_Generate = new System.Windows.Forms.ComboBox();
            this.button_SubmitOrder = new System.Windows.Forms.Button();
            this.button_AddToOrder = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.Column_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Payment = new System.Windows.Forms.TextBox();
            this.label_Paid = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Items)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(290, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 693);
            this.panel3.TabIndex = 60;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 6);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1091, 575);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.panel4.Controls.Add(this.label_TitleAddRoom);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 47);
            this.panel4.TabIndex = 10;
            // 
            // label_TitleAddRoom
            // 
            this.label_TitleAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleAddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.label_TitleAddRoom.Location = new System.Drawing.Point(3, 0);
            this.label_TitleAddRoom.Name = "label_TitleAddRoom";
            this.label_TitleAddRoom.Size = new System.Drawing.Size(367, 53);
            this.label_TitleAddRoom.TabIndex = 1;
            this.label_TitleAddRoom.Text = "Bar Order";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Items, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.63636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.363636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 486);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridView_Items
            // 
            this.dataGridView_Items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dataGridView_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Id,
            this.Column_Name,
            this.Column_barPrice,
            this.Column_Quantity});
            this.dataGridView_Items.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Items.Name = "dataGridView_Items";
            this.dataGridView_Items.Size = new System.Drawing.Size(724, 468);
            this.dataGridView_Items.TabIndex = 0;
            this.dataGridView_Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Items_CellContentClick);
            // 
            // Column_Id
            // 
            this.Column_Id.HeaderText = "ID";
            this.Column_Id.Name = "Column_Id";
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_barPrice
            // 
            this.Column_barPrice.HeaderText = "Price";
            this.Column_barPrice.Name = "Column_barPrice";
            // 
            // Column_Quantity
            // 
            this.Column_Quantity.HeaderText = "Quantity";
            this.Column_Quantity.Name = "Column_Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.button_RemoveRow);
            this.panel2.Controls.Add(this.button_Generate);
            this.panel2.Controls.Add(this.comboBox_Generate);
            this.panel2.Controls.Add(this.button_SubmitOrder);
            this.panel2.Controls.Add(this.button_AddToOrder);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(2, 535);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 37);
            this.panel2.TabIndex = 4;
            // 
            // button_RemoveRow
            // 
            this.button_RemoveRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveRow.ForeColor = System.Drawing.Color.Black;
            this.button_RemoveRow.Location = new System.Drawing.Point(455, 3);
            this.button_RemoveRow.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoveRow.Name = "button_RemoveRow";
            this.button_RemoveRow.Size = new System.Drawing.Size(120, 32);
            this.button_RemoveRow.TabIndex = 7;
            this.button_RemoveRow.Text = "Remove";
            this.button_RemoveRow.UseVisualStyleBackColor = true;
            this.button_RemoveRow.Click += new System.EventHandler(this.button_RemoveRow_Click);
            // 
            // button_Generate
            // 
            this.button_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generate.ForeColor = System.Drawing.Color.Black;
            this.button_Generate.Location = new System.Drawing.Point(174, 3);
            this.button_Generate.Margin = new System.Windows.Forms.Padding(2);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(120, 32);
            this.button_Generate.TabIndex = 6;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // comboBox_Generate
            // 
            this.comboBox_Generate.FormattingEnabled = true;
            this.comboBox_Generate.Items.AddRange(new object[] {
            "Drinks",
            "Snacks"});
            this.comboBox_Generate.Location = new System.Drawing.Point(7, 8);
            this.comboBox_Generate.Name = "comboBox_Generate";
            this.comboBox_Generate.Size = new System.Drawing.Size(149, 21);
            this.comboBox_Generate.TabIndex = 5;
            // 
            // button_SubmitOrder
            // 
            this.button_SubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SubmitOrder.ForeColor = System.Drawing.Color.Black;
            this.button_SubmitOrder.Location = new System.Drawing.Point(595, 3);
            this.button_SubmitOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_SubmitOrder.Name = "button_SubmitOrder";
            this.button_SubmitOrder.Size = new System.Drawing.Size(120, 32);
            this.button_SubmitOrder.TabIndex = 4;
            this.button_SubmitOrder.Text = "Submit Order";
            this.button_SubmitOrder.UseVisualStyleBackColor = true;
            this.button_SubmitOrder.Click += new System.EventHandler(this.button_SubmitOrder_Click);
            // 
            // button_AddToOrder
            // 
            this.button_AddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddToOrder.ForeColor = System.Drawing.Color.Black;
            this.button_AddToOrder.Location = new System.Drawing.Point(322, 3);
            this.button_AddToOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddToOrder.Name = "button_AddToOrder";
            this.button_AddToOrder.Size = new System.Drawing.Size(120, 32);
            this.button_AddToOrder.TabIndex = 3;
            this.button_AddToOrder.Text = "Add";
            this.button_AddToOrder.UseVisualStyleBackColor = true;
            this.button_AddToOrder.Click += new System.EventHandler(this.button_AddToOrder_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(497, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 34);
            this.button6.TabIndex = 1;
            this.button6.Text = "Submit";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(641, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 34);
            this.button5.TabIndex = 0;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox_Total
            // 
            this.textBox_Total.Enabled = false;
            this.textBox_Total.Location = new System.Drawing.Point(1229, 565);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(100, 20);
            this.textBox_Total.TabIndex = 6;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.label_Total.Location = new System.Drawing.Point(1106, 563);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(48, 20);
            this.label_Total.TabIndex = 5;
            this.label_Total.Text = "Total:";
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dataGridView_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Item,
            this.Column_Price});
            this.dataGridView_Order.Location = new System.Drawing.Point(1032, 73);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.Size = new System.Drawing.Size(318, 468);
            this.dataGridView_Order.TabIndex = 61;
            this.dataGridView_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column_Item
            // 
            this.Column_Item.HeaderText = "Column_Price";
            this.Column_Item.Name = "Column_Item";
            // 
            // Column_Price
            // 
            this.Column_Price.HeaderText = "Price";
            this.Column_Price.Name = "Column_Price";
            // 
            // textBox_Payment
            // 
            this.textBox_Payment.Location = new System.Drawing.Point(1229, 615);
            this.textBox_Payment.Name = "textBox_Payment";
            this.textBox_Payment.Size = new System.Drawing.Size(100, 20);
            this.textBox_Payment.TabIndex = 9;
            // 
            // label_Paid
            // 
            this.label_Paid.AutoSize = true;
            this.label_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Paid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.label_Paid.Location = new System.Drawing.Point(1106, 613);
            this.label_Paid.Name = "label_Paid";
            this.label_Paid.Size = new System.Drawing.Size(117, 20);
            this.label_Paid.TabIndex = 8;
            this.label_Paid.Text = "Amount Payed:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(45, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 628);
            this.flowLayoutPanel1.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChelseaHotel_ManagementSystem.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 199);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(3, 205);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label3.Size = new System.Drawing.Size(111, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bar Order";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button4.Location = new System.Drawing.Point(3, 254);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Main Menu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1362, 715);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox_Payment);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label_Paid);
            this.Controls.Add(this.dataGridView_Order);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TakeOrder";
            this.Text = "TakeOrder";
            this.Load += new System.EventHandler(this.TakeOrder_Load);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Items)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_TitleAddRoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_AddToOrder;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_SubmitOrder;
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.DataGridView dataGridView_Items;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.ComboBox comboBox_Generate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_barPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Quantity;
        private System.Windows.Forms.Button button_RemoveRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.TextBox textBox_Payment;
        private System.Windows.Forms.Label label_Paid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}