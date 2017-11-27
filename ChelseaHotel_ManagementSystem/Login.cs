using BusinessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class Login : Form
    {
        #region Instance Attributes

        private IModel Model;
        mainContainer mc;

        #endregion

        #region Constructors
        public Login(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        #endregion


        private void Submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var validUser = Model.Login(username_txtbox.Text, password_txtbox.Text);

                if (validUser)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid name or password");
                    username_txtbox.Text = "";
                    password_txtbox.Text = "";
                    username_txtbox.Select();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Source);
            }
        }


        private void cancel_button_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        public static void ProcessLogin(mainContainer mc, IModel Model)
        {


            //Checkscurrent user type and displays new managment board for that user
            switch (Model.getUserTypeForCurrentUser())
            {
                case 1:
                    //System Administrator
                    break;

                case 2:
                    //General Manager               
                    DashboardGeneralManager form2 = new DashboardGeneralManager(mc, Model); // All forms get passed the formContainer and a reference to the model object. 
                    //this.Text = this.Text + "-Manager";
                    form2.Dock = DockStyle.Fill;
                    form2.Show();
                    break;
                case 3:
                    //Receptionist
                    DashboardReceptionist form3 = new DashboardReceptionist(mc, Model);
                    form3.Dock = DockStyle.Fill;
                    form3.Show();

                    break;
                case 4:
                    //Kitchen Manager
                   var restaurantKitchenManager = new DashboardKitchenManager(mc, Model);
                   restaurantKitchenManager.Dock =  DockStyle.Fill;
                   restaurantKitchenManager.Show();
                    break;
                case 5:
                    // Kitchen Staff
                    break;
                case 6:
                    // Bar Manager
                    break;
                case 7:
                    // Bar Staff
                    break;
                case 8:
                    // Restaurant Staff
                    break;

                default:
                    //Logo
                    //ManagmentBoard form2 = new ManagmentBoard(this, Model); // All forms get passed the formContainer and a reference to the model object. 
                    //this.Text = this.Text + "-Manager";
                    //form2.Dock = DockStyle.Fill;
                    //form2.Show();

                    break;

            }
        }


    }
}
