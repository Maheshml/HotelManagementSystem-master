using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntities;
using DataAccessLayer;

namespace ChelseaHotel_ManagementSystem
{
    public partial class addSpecialOffer : Form
    {
        #region Instance Attributes
        IModel Model;
        mainContainer mc;
        #endregion

        public addSpecialOffer(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_AddRoom_Enter(object sender, EventArgs e)
        {

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_ID.Text);
            Decimal percent = Convert.ToDecimal(textBox_DiscountPercent.Text);
            DateTime sDate = Convert.ToDateTime(dateTimePicker_sDate.Value.ToString("yyyy-MM-dd"));
            DateTime eDate = Convert.ToDateTime(dateTimePicker_eDate.Value.ToString("yyyy-MM-dd"));
            string name = textBox_Name.Text;
            string Desc = textBox_Desc.Text;
            string State = comboBox_State.SelectedItem.ToString();

            bool Result = Model.addNewSpecialOffer(id,percent, sDate, eDate, name, Desc, State);

            if (Result == true)
            {
                MessageBox.Show("Discount created");
            }
            else
            {
                MessageBox.Show("Can't create this offer");
            }
        }

        private void CreateSpecialOffer_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new ViewSpecialOffers(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
    