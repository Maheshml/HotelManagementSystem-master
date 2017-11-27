using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class addBooking : Form
    {
        #region Instance Attributes
        IModel Model;
        mainContainer mc;
        #endregion

        public addBooking(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
            this.Model = Model;

            //Step 1 - Room
            panel5.Show();
            //Step 2 - Guest + Payment
            panel2.Hide();


            //Check in date
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now.AddYears(1);
        }

        private void submitBookingButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelBookingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitBookingButton_Click_1(object sender, EventArgs e)
        {
            panel2.Show();
            panel5.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.panel5.Show();
            this.panel2.Hide();
        }

        private void numberOfDays_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {


            int checkInDay = dateTimePicker1.Value.DayOfYear;
            int checkOutDay = dateTimePicker2.Value.DayOfYear;

            int diff = checkOutDay - checkInDay;
            //var diff = Math.round((endDate - startDate) / 1000 / 60 / 60 / 24); //Difference in days

            numberOfDays.Text = "";
            numberOfDays.Text += diff; 
            numberOfDays.Text += " Days";
        }
    }
}
