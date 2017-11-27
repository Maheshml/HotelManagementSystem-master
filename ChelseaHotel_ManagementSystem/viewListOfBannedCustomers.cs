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

namespace ChelseaHotel_ManagementSystem
{
    public partial class viewListOfBannedCustomers : Form
    {
        #region Instance Attributes
        IModel Model;
        mainContainer fc;
        #endregion


        public viewListOfBannedCustomers(mainContainer parent,IModel Model)
        {
            InitializeComponent();
            //MdiParent = parent;
            //fc = parent;
            this.Model = Model;
        }

        private void matchingCustomersLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void viewListOfBannedCustomers_Load(object sender, EventArgs e)
        {
            foreach (BannedCustomer customer in Model.BannedCustomerList)
            {
                MessageBox.Show(customer.LastName);
                //bannedCustomersListbox.Items.Add(customer.LastName);
            }

            //foreach (User customer in Model.UserList)
            //{
            //    MessageBox.Show(customer.Name);
            //    //bannedCustomersListbox.Items.Add(customer.LastName);
            //}


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete " + firstNameBox.ToString() + " ? ", "Are you sure !", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            foreach (BannedCustomer customer in Model.BannedCustomerList)
            {

                if (customer.FirstName == firstNameBox.ToString() && customer.LastName == lastNameBox.ToString() && customer.Email == emailAddressBox.ToString())
                {
                    Model.DeleteBannedCustomer(customer);
                    
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String firstName, lastName, email, reasonForBan, photo;
            firstName = firstNameBox.Text;
            lastName = lastNameBox.Text;
            email = emailAddressBox.Text;
            photo = "photo location";
            reasonForBan = reasonForBanBox.Text;
            MessageBox.Show(reasonForBan);
            int id;
            id = 0;

            if (Model.AddCustomerToBannedList(id, firstName, lastName, email, reasonForBan, photo))
            {
                MessageBox.Show("Customer Successfully Banned");
                firstNameBox.Text = "";
                lastNameBox.Text = "";
                emailAddressBox.Text = "";
                reasonForBanBox.Text = "";
            }
            else
            {
                MessageBox.Show("Fail creating user");
            }
        }
    }
}
