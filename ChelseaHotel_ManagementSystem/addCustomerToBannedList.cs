using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using BusinessEntities;
using DataAccessLayer;

namespace ChelseaHotel_ManagementSystem
{
    public partial class addCustomerToBannedList : Form
    {

        #region Instance Attributes
        IModel Model;
        mainContainer mc;
        private static IDataLayer DataLayer;
        //private IModel Model = BusinessLayer.Model.GetInstance(DataLayer);
        
        #endregion 

        public addCustomerToBannedList(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            //panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            String firstName, lastName, email, reasonForBan, photo;
            firstName = firstnameTextBox.Text;
            lastName = surnameTextBox.Text;
            email = emailAddressTextBox.Text;
            photo = "photo location";
            reasonForBan = reasonForBanningTextBox2.Text;
            MessageBox.Show(reasonForBan);
            int id;
            id = 0;

            if (Model.AddCustomerToBannedList(id, firstName, lastName, email, reasonForBan, photo))
            {
                MessageBox.Show("User created");
                firstnameTextBox.Text = "";
                surnameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Fail creating user");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
