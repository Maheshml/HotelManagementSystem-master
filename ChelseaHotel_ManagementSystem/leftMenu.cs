using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
   
    public partial class LeftMenu : UserControl
    {
        public int numberOfButtons = 0;
        public string[] namesOfButtons;

        public LeftMenu()
        {
            List<Button> buttons = new List<Button>();
            numberOfButtons = 3;
            for (int i = 0; i < numberOfButtons; i++)
            {
               Button button = new Button();

               button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
               button.Location = new System.Drawing.Point(20, 360 + (i*60));
                //  button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                //  button1.Name = "button1";
                button.Size = new System.Drawing.Size(260, 45);
                // button1.TabIndex = 1;
                button.Text = "Add User";
                // button1.UseVisualStyleBackColor = true;
                buttons.Add(button);
                this.Controls.Add(button);
            }

            InitializeComponent();
        }

        public LeftMenu(string nameOfForm,int numberOfButtons, string[] nameOfButtons)
        {
            //label2.AutoSize = true;
            //label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
            //label2.Location = new System.Drawing.Point(330, 27);
            //label2.Name = "label2";
            //label2.Size = new System.Drawing.Size(154, 38);
            //this.label2.TabIndex = 3;
            //this.label2.Text = "Add User";
            List<Button> buttons = new List<Button>();
            numberOfButtons = 3;
            for (int i = 0; i < numberOfButtons; i++)
            {
                Button button = new Button();

                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(209)))), ((int)(((byte)(144)))));
                button.Location = new System.Drawing.Point(20, 360 + (i * 60));
                //  button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                //  button1.Name = "button1";
                button.Size = new System.Drawing.Size(260, 45);
                // button1.TabIndex = 1;
                button.Text = "Add User";
                // button1.UseVisualStyleBackColor = true;
                buttons.Add(button);
                this.Controls.Add(button);
            }
        }
    }
}
