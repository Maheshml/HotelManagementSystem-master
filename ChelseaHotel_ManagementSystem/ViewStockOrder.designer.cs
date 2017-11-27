namespace ChelseaHotel_ManagementSystem
{
    partial class ViewStockOrder
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_TitleAddRoom = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_StockOrder = new System.Windows.Forms.DataGridView();
            this.Column_orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_orderCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OrderSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_orderRecieved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_supplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_deliverTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_orderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Populate = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StockOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 664);
            this.panel3.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 577);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::ChelseaHotel_ManagementSystem.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 228);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(220, 6);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(871, 575);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.panel4.Controls.Add(this.label_TitleAddRoom);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 47);
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
            this.label_TitleAddRoom.Text = "Stock Order";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_StockOrder, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.63636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.363636F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 447);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // dataGridView_StockOrder
            // 
            this.dataGridView_StockOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dataGridView_StockOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StockOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_orderId,
            this.Column_orderCreate,
            this.Column_OrderSent,
            this.Column_orderRecieved,
            this.Column_supplierId,
            this.Column_deliverTo,
            this.Column_orderTotal,
            this.Column_Status});
            this.dataGridView_StockOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.dataGridView_StockOrder.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_StockOrder.Name = "dataGridView_StockOrder";
            this.dataGridView_StockOrder.Size = new System.Drawing.Size(790, 391);
            this.dataGridView_StockOrder.TabIndex = 0;
            // 
            // Column_orderId
            // 
            this.Column_orderId.HeaderText = "OrderId";
            this.Column_orderId.Name = "Column_orderId";
            this.Column_orderId.Width = 70;
            // 
            // Column_orderCreate
            // 
            this.Column_orderCreate.HeaderText = "Order Created";
            this.Column_orderCreate.Name = "Column_orderCreate";
            this.Column_orderCreate.Width = 90;
            // 
            // Column_OrderSent
            // 
            this.Column_OrderSent.HeaderText = "Order Sent";
            this.Column_OrderSent.Name = "Column_OrderSent";
            this.Column_OrderSent.Width = 80;
            // 
            // Column_orderRecieved
            // 
            this.Column_orderRecieved.HeaderText = "Order Recieved";
            this.Column_orderRecieved.Name = "Column_orderRecieved";
            // 
            // Column_supplierId
            // 
            this.Column_supplierId.HeaderText = "SupplierId";
            this.Column_supplierId.Name = "Column_supplierId";
            // 
            // Column_deliverTo
            // 
            this.Column_deliverTo.HeaderText = "Delivered To";
            this.Column_deliverTo.Name = "Column_deliverTo";
            // 
            // Column_orderTotal
            // 
            this.Column_orderTotal.HeaderText = "Order Total";
            this.Column_orderTotal.Name = "Column_orderTotal";
            // 
            // Column_Status
            // 
            this.Column_Status.HeaderText = "Status";
            this.Column_Status.Name = "Column_Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.button_Send);
            this.panel2.Controls.Add(this.button_Refresh);
            this.panel2.Controls.Add(this.button_Populate);
            this.panel2.Controls.Add(this.button_Cancel);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(2, 496);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 37);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Send.ForeColor = System.Drawing.Color.Black;
            this.button_Send.Location = new System.Drawing.Point(302, 5);
            this.button_Send.Margin = new System.Windows.Forms.Padding(2);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(120, 32);
            this.button_Send.TabIndex = 10;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(551, 5);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(120, 32);
            this.button_Refresh.TabIndex = 9;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            // 
            // button_Populate
            // 
            this.button_Populate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Populate.ForeColor = System.Drawing.Color.Black;
            this.button_Populate.Location = new System.Drawing.Point(426, 5);
            this.button_Populate.Margin = new System.Windows.Forms.Padding(2);
            this.button_Populate.Name = "button_Populate";
            this.button_Populate.Size = new System.Drawing.Size(120, 32);
            this.button_Populate.TabIndex = 7;
            this.button_Populate.Text = "Populate";
            this.button_Populate.UseVisualStyleBackColor = true;
            this.button_Populate.Click += new System.EventHandler(this.button_Populate_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Location = new System.Drawing.Point(676, 5);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(120, 32);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
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
            // ViewStockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1151, 636);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStockOrder";
            this.Text = "ViewStockOrder";
            this.Load += new System.EventHandler(this.ViewStockOrder_Load);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StockOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_TitleAddRoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_StockOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Populate;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_orderCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_orderRecieved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_supplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_deliverTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_orderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Status;
        private System.Windows.Forms.Button button_Send;
    }
}