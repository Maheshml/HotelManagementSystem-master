using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;

namespace ChelseaHotel_ManagementSystem
{
    public partial class addSupplier : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Instance Properties

        #endregion


        #region Constructors
        public addSupplier(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        #endregion






        private void submit_btn_Click(object sender, EventArgs e)
        {



            int ID = Convert.ToInt32(ID_textbox.Text);
            Model.AddNewSupplier(ID, name_txtbox.Text, phone_textbox.Text, email_txtbox.Text, street_textbox.Text, city_textbox.Text, county_textbox.Text, info_textbox.Text);
            MessageBox.Show("Supplier added successfully");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



