namespace ChelseaHotel_ManagementSystem
{
    partial class PrintStokOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintStokOrder));
            this.printDocBox = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.printDocBox)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocBox
            // 
            this.printDocBox.Enabled = true;
            this.printDocBox.Location = new System.Drawing.Point(12, 12);
            this.printDocBox.Name = "printDocBox";
            this.printDocBox.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("printDocBox.OcxState")));
            this.printDocBox.Size = new System.Drawing.Size(744, 691);
            this.printDocBox.TabIndex = 0;
            this.printDocBox.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // PrintStokOrder
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(768, 715);
            this.Controls.Add(this.printDocBox);
            this.Name = "PrintStokOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PrintStokOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printDocBox)).EndInit();
            this.ResumeLayout(false);

        }

        private AxAcroPDFLib.AxAcroPDF printDocBox;

        //private AxAcroPDFLib.AxAcroPDF printDocBox;

        #endregion

        //private AxAcroPDFLib.AxAcroPDF printDocBox;
    }
}