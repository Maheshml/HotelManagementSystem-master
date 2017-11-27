namespace ChelseaHotel_ManagementSystem
{
    partial class DashboardKitchenManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardKitchenManager));
            this.panel3 = new System.Windows.Forms.Panel();
            this.name_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.getReport_btn = new System.Windows.Forms.Button();
            this.setupMenu_btn = new System.Windows.Forms.Button();
            this.checkRoster_btn = new System.Windows.Forms.Button();
            this.ManageStock_btn = new System.Windows.Forms.Button();
            this.manageSupplier_btn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.panel3.Controls.Add(this.name_lbl);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.getReport_btn);
            this.panel3.Controls.Add(this.setupMenu_btn);
            this.panel3.Controls.Add(this.checkRoster_btn);
            this.panel3.Controls.Add(this.ManageStock_btn);
            this.panel3.Controls.Add(this.manageSupplier_btn);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1274, 533);
            this.panel3.TabIndex = 0;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.name_lbl.Location = new System.Drawing.Point(568, 61);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(652, 39);
            this.name_lbl.TabIndex = 24;
            this.name_lbl.Text = "Restaurant/Kitchen Manager Admin Panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChelseaHotel_ManagementSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(745, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 98);
            this.button1.TabIndex = 5;
            this.button1.Text = "Suppliers";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "StockPlus.png");
            this.imageList1.Images.SetKeyName(1, "file-2.png");
            this.imageList1.Images.SetKeyName(2, "menu-1.png");
            this.imageList1.Images.SetKeyName(3, "menu-4.png");
            this.imageList1.Images.SetKeyName(4, "Custom-Icon-Design-Flatastic-2-Truck.ico");
            this.imageList1.Images.SetKeyName(5, "setmenu.png");
            // 
            // getReport_btn
            // 
            this.getReport_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.getReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.getReport_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.getReport_btn.ImageIndex = 1;
            this.getReport_btn.ImageList = this.imageList1;
            this.getReport_btn.Location = new System.Drawing.Point(915, 327);
            this.getReport_btn.Margin = new System.Windows.Forms.Padding(20);
            this.getReport_btn.Name = "getReport_btn";
            this.getReport_btn.Size = new System.Drawing.Size(149, 98);
            this.getReport_btn.TabIndex = 6;
            this.getReport_btn.Text = "Get Report";
            this.getReport_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.getReport_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.getReport_btn.UseVisualStyleBackColor = true;
            this.getReport_btn.Click += new System.EventHandler(this.getReport_btn_Click);
            // 
            // setupMenu_btn
            // 
            this.setupMenu_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.setupMenu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setupMenu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.setupMenu_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.setupMenu_btn.ImageIndex = 5;
            this.setupMenu_btn.ImageList = this.imageList1;
            this.setupMenu_btn.Location = new System.Drawing.Point(915, 157);
            this.setupMenu_btn.Margin = new System.Windows.Forms.Padding(20);
            this.setupMenu_btn.Name = "setupMenu_btn";
            this.setupMenu_btn.Size = new System.Drawing.Size(149, 98);
            this.setupMenu_btn.TabIndex = 3;
            this.setupMenu_btn.Text = "Setup Menu";
            this.setupMenu_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setupMenu_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.setupMenu_btn.UseVisualStyleBackColor = true;
            this.setupMenu_btn.Click += new System.EventHandler(this.setupMenu_btn_Click);
            // 
            // checkRoster_btn
            // 
            this.checkRoster_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.checkRoster_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkRoster_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkRoster_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.checkRoster_btn.ImageIndex = 2;
            this.checkRoster_btn.ImageList = this.imageList1;
            this.checkRoster_btn.Location = new System.Drawing.Point(575, 327);
            this.checkRoster_btn.Margin = new System.Windows.Forms.Padding(20);
            this.checkRoster_btn.Name = "checkRoster_btn";
            this.checkRoster_btn.Size = new System.Drawing.Size(149, 98);
            this.checkRoster_btn.TabIndex = 4;
            this.checkRoster_btn.Text = "Check Roster";
            this.checkRoster_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkRoster_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkRoster_btn.UseVisualStyleBackColor = true;
            // 
            // ManageStock_btn
            // 
            this.ManageStock_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.ManageStock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageStock_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ManageStock_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.ManageStock_btn.ImageIndex = 0;
            this.ManageStock_btn.ImageList = this.imageList1;
            this.ManageStock_btn.Location = new System.Drawing.Point(575, 157);
            this.ManageStock_btn.Margin = new System.Windows.Forms.Padding(20);
            this.ManageStock_btn.Name = "ManageStock_btn";
            this.ManageStock_btn.Size = new System.Drawing.Size(149, 98);
            this.ManageStock_btn.TabIndex = 1;
            this.ManageStock_btn.Text = "Stock Orders";
            this.ManageStock_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ManageStock_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ManageStock_btn.UseVisualStyleBackColor = true;
            this.ManageStock_btn.Click += new System.EventHandler(this.ManageStock_btn_Click);
            // 
            // manageSupplier_btn
            // 
            this.manageSupplier_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.manageSupplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageSupplier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.manageSupplier_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.manageSupplier_btn.ImageIndex = 3;
            this.manageSupplier_btn.ImageList = this.imageList1;
            this.manageSupplier_btn.Location = new System.Drawing.Point(745, 157);
            this.manageSupplier_btn.Margin = new System.Windows.Forms.Padding(20);
            this.manageSupplier_btn.Name = "manageSupplier_btn";
            this.manageSupplier_btn.Size = new System.Drawing.Size(149, 98);
            this.manageSupplier_btn.TabIndex = 2;
            this.manageSupplier_btn.Text = "Food";
            this.manageSupplier_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.manageSupplier_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manageSupplier_btn.UseVisualStyleBackColor = true;
            this.manageSupplier_btn.Click += new System.EventHandler(this.manageSupplier_btn_Click);
            // 
            // DashboardKitchenManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1294, 562);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardKitchenManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant/ Kitchen Manager Admin Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button getReport_btn;
        private System.Windows.Forms.Button setupMenu_btn;
        private System.Windows.Forms.Button checkRoster_btn;
        private System.Windows.Forms.Button ManageStock_btn;
        private System.Windows.Forms.Button manageSupplier_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.ImageList imageList1;
    }
}