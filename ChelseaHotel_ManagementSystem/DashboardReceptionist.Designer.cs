namespace ChelseaHotel_ManagementSystem
{
    partial class DashboardReceptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardReceptionist));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bannedCustomersButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkIn_btn = new System.Windows.Forms.Button();
            this.checkOut_btn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1206, 702);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkOut_btn);
            this.panel1.Controls.Add(this.checkIn_btn);
            this.panel1.Controls.Add(this.bannedCustomersButton);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.logout_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(27, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 643);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bannedCustomersButton
            // 
            this.bannedCustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bannedCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannedCustomersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.bannedCustomersButton.ImageKey = "magic-wand.png";
            this.bannedCustomersButton.ImageList = this.imageList1;
            this.bannedCustomersButton.Location = new System.Drawing.Point(412, 272);
            this.bannedCustomersButton.Margin = new System.Windows.Forms.Padding(2);
            this.bannedCustomersButton.Name = "bannedCustomersButton";
            this.bannedCustomersButton.Size = new System.Drawing.Size(149, 98);
            this.bannedCustomersButton.TabIndex = 14;
            this.bannedCustomersButton.Text = "Housekeeping";
            this.bannedCustomersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bannedCustomersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bannedCustomersButton.UseVisualStyleBackColor = true;
         //   this.bannedCustomersButton.Click += new System.EventHandler(this.bannedCustomersButton_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user-3.png");
            this.imageList1.Images.SetKeyName(1, "users-1.png");
            this.imageList1.Images.SetKeyName(2, "user-6.png");
            this.imageList1.Images.SetKeyName(3, "user-4.png");
            this.imageList1.Images.SetKeyName(4, "gift.png");
            this.imageList1.Images.SetKeyName(5, "server.png");
            this.imageList1.Images.SetKeyName(6, "house.png");
            this.imageList1.Images.SetKeyName(7, "database-1.png");
            this.imageList1.Images.SetKeyName(8, "magic-wand.png");
            this.imageList1.Images.SetKeyName(9, "agenda.png");
            this.imageList1.Images.SetKeyName(10, "notepad.png");
            this.imageList1.Images.SetKeyName(11, "notebook-1.png");
            this.imageList1.Images.SetKeyName(12, "exit.png");
            this.imageList1.Images.SetKeyName(13, "check-in-icon-blue.png");
            this.imageList1.Images.SetKeyName(14, "traveler.png");
            this.imageList1.Images.SetKeyName(15, "Traveller-With-Suitcase-Icon.png");
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button8.ImageIndex = 10;
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(810, 121);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(149, 98);
            this.button8.TabIndex = 13;
            this.button8.Text = "Orders";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button9.ImageIndex = 1;
            this.button9.ImageList = this.imageList1;
            this.button9.Location = new System.Drawing.Point(611, 121);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(149, 98);
            this.button9.TabIndex = 12;
            this.button9.Text = "Guests";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button10.ImageIndex = 11;
            this.button10.ImageList = this.imageList1;
            this.button10.Location = new System.Drawing.Point(412, 121);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(149, 98);
            this.button10.TabIndex = 11;
            this.button10.Text = "Bookings";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 643);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::ChelseaHotel_ManagementSystem.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 389);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logout_button
            // 
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.logout_button.ImageIndex = 12;
            this.logout_button.ImageList = this.imageList1;
            this.logout_button.Location = new System.Drawing.Point(412, 412);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(149, 98);
            this.logout_button.TabIndex = 10;
            this.logout_button.Text = "Logout";
            this.logout_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(409, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Receptionist Board";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkIn_btn
            // 
            this.checkIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.checkIn_btn.ImageIndex = 13;
            this.checkIn_btn.ImageList = this.imageList1;
            this.checkIn_btn.Location = new System.Drawing.Point(611, 272);
            this.checkIn_btn.Margin = new System.Windows.Forms.Padding(2);
            this.checkIn_btn.Name = "checkIn_btn";
            this.checkIn_btn.Size = new System.Drawing.Size(149, 98);
            this.checkIn_btn.TabIndex = 15;
            this.checkIn_btn.Text = "Check In";
            this.checkIn_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkIn_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkIn_btn.UseVisualStyleBackColor = true;
            this.checkIn_btn.Click += new System.EventHandler(this.checkIn_btn_Click);
            // 
            // checkOut_btn
            // 
            this.checkOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.checkOut_btn.ImageIndex = 15;
            this.checkOut_btn.ImageList = this.imageList1;
            this.checkOut_btn.Location = new System.Drawing.Point(810, 272);
            this.checkOut_btn.Margin = new System.Windows.Forms.Padding(2);
            this.checkOut_btn.Name = "checkOut_btn";
            this.checkOut_btn.Size = new System.Drawing.Size(149, 98);
            this.checkOut_btn.TabIndex = 16;
            this.checkOut_btn.Text = "Check Out";
            this.checkOut_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkOut_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkOut_btn.UseVisualStyleBackColor = true;
            this.checkOut_btn.Click += new System.EventHandler(this.checkOut_btn_Click);
            // 
            // DashboardReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1206, 702);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "DashboardReceptionist";
            this.Text = "(Anna) Receptionist Board";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bannedCustomersButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkOut_btn;
        private System.Windows.Forms.Button checkIn_btn;
    }
}