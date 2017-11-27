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


//Grace McNamara
namespace ChelseaHotel_ManagementSystem
{
    public partial class editUser : Form
    {
        #region Instance Attributes
        IModel Model;
        mainContainer mc;
        #endregion

        #region Instance Properties

        #endregion


        #region Constructors
        public editUser(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel1.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel1.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel1.Height) / 2);

        }

        public editUser() { }
        #endregion

        int userRole;
        bool userState;

        private void editUser_Load(object sender, EventArgs e)
        {
            foreach (User user in Model.UserList)
            {

                username_combo.Items.Add(user.Name);
                
           }

           
           

        }
        
        

        private void submit_btn_Click(object sender, EventArgs e)
        {

            switch (userRole_Combo.Text)
            {
                case "System Administrator":
                    userRole = 1;
                    break;
                case "General Manager":
                    userRole = 2;
                    break;
                case "Receptionist":
                    userRole = 3;
                    break;
                default:
                    userRole = 0;
                    break;
                    //Bar Staff
                    //Bar Manager
                    //Kitchen Staff
                    //Kitchen Manager
                    //Receptionist
                    //General Manager
                    //System Administrator
            }

           
            if (status_check.CheckState.ToString().Equals("Checked"))
                userState = true;
            else if (status_check.CheckState.ToString().Equals("Unchecked"))
                userState = false;
            foreach (User user in Model.UserList)
            {
                

                if (user.Name == username_combo.SelectedItem.ToString())
                {
                    
                   
                    if (password_text.Text == confirmpassword_textbox.Text)
                    {
                        user.Password = confirmpassword_textbox.Text;
                        user.Name = username_textBox.Text;
                        user.Status = userState;
                        user.UserType = userRole;
                       
                        Model.EditUser(user);
                        username_textBox.Text = "";
                        password_text.Text = "";
                        confirmpassword_textbox.Text = "";
                       
                    }

                    else
                    {
                        MessageBox.Show("Passwords don't match");
                        

                    }
                   
                }

               
            }
            

            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            addUser form = new addUser(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
            this.Hide();
        }
    }
}
