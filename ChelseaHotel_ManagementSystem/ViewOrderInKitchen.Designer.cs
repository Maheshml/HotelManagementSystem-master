namespace ChelseaHotel_ManagementSystem
{
    partial class ViewOrderInKitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderInKitchen));
            this.NextOrder_Brn = new System.Windows.Forms.Button();
            this.preveOrder_btn = new System.Windows.Forms.Button();
            this.menuReader = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.menuReader)).BeginInit();
            this.SuspendLayout();
            // 
            // NextOrder_Brn
            // 
            this.NextOrder_Brn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.NextOrder_Brn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextOrder_Brn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.NextOrder_Brn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.NextOrder_Brn.Location = new System.Drawing.Point(626, 705);
            this.NextOrder_Brn.Name = "NextOrder_Brn";
            this.NextOrder_Brn.Size = new System.Drawing.Size(149, 98);
            this.NextOrder_Brn.TabIndex = 0;
            this.NextOrder_Brn.Text = "Next Order";
            this.NextOrder_Brn.UseVisualStyleBackColor = true;
            this.NextOrder_Brn.Click += new System.EventHandler(this.NextOrder_Brn_Click);
            // 
            // preveOrder_btn
            // 
            this.preveOrder_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.preveOrder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preveOrder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.preveOrder_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.preveOrder_btn.Location = new System.Drawing.Point(452, 705);
            this.preveOrder_btn.Name = "preveOrder_btn";
            this.preveOrder_btn.Size = new System.Drawing.Size(149, 98);
            this.preveOrder_btn.TabIndex = 2;
            this.preveOrder_btn.Text = "Previous Order";
            this.preveOrder_btn.UseVisualStyleBackColor = true;
            this.preveOrder_btn.Click += new System.EventHandler(this.preveOrder_btn_Click);
            // 
            // menuReader
            // 
            this.menuReader.Enabled = true;
            this.menuReader.Location = new System.Drawing.Point(12, 12);
            this.menuReader.Name = "menuReader";
            this.menuReader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("menuReader.OcxState")));
            this.menuReader.Size = new System.Drawing.Size(763, 672);
            this.menuReader.TabIndex = 3;
            // 
            // ViewOrderInKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(787, 819);
            this.Controls.Add(this.menuReader);
            this.Controls.Add(this.preveOrder_btn);
            this.Controls.Add(this.NextOrder_Brn);
            this.Name = "ViewOrderInKitchen";
            this.Text = "ViewOrderInKitchen";
            ((System.ComponentModel.ISupportInitialize)(this.menuReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextOrder_Brn;
        ///private AxAcroPDFLib.AxAcroPDF menuReader;
        private System.Windows.Forms.Button preveOrder_btn;
        private AxAcroPDFLib.AxAcroPDF menuReader;
        //private AxAcroPDFLib.AxAcroPDF menuReader;
    }
}