namespace ChelseaHotel_ManagementSystem
{
    partial class Archive
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
            this.label_SelectSystem = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_SelecySystem = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Archive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SelectSystem
            // 
            this.label_SelectSystem.AutoSize = true;
            this.label_SelectSystem.Location = new System.Drawing.Point(13, 13);
            this.label_SelectSystem.Name = "label_SelectSystem";
            this.label_SelectSystem.Size = new System.Drawing.Size(84, 13);
            this.label_SelectSystem.TabIndex = 0;
            this.label_SelectSystem.Text = "Select a system:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label_SelecySystem
            // 
            this.label_SelecySystem.AutoSize = true;
            this.label_SelecySystem.Location = new System.Drawing.Point(245, 13);
            this.label_SelecySystem.Name = "label_SelecySystem";
            this.label_SelecySystem.Size = new System.Drawing.Size(152, 13);
            this.label_SelecySystem.TabIndex = 2;
            this.label_SelecySystem.Text = "Select a table from this system:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(413, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 159);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_Archive
            // 
            this.button_Archive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Archive.Location = new System.Drawing.Point(16, 262);
            this.button_Archive.Name = "button_Archive";
            this.button_Archive.Size = new System.Drawing.Size(75, 23);
            this.button_Archive.TabIndex = 5;
            this.button_Archive.Text = "Archive";
            this.button_Archive.UseVisualStyleBackColor = true;
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(28)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(718, 310);
            this.Controls.Add(this.button_Archive);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label_SelecySystem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_SelectSystem);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            this.Name = "Archive";
            this.Text = "Archive";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SelectSystem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_SelecySystem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Archive;
    }
}