using BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ChelseaHotel_ManagementSystem
{
    public partial class DashboardGeneralManager : Form
    {
        #region Instance Attributes
        private IModel Model;
        mainContainer mc;
        #endregion


        #region Constructors
        public DashboardGeneralManager(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;

            panel3.Location = new System.Drawing.Point( (Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }
        #endregion

        
        private void UsersButton_Click(object sender, EventArgs e)
        {
            addUser form = new addUser(mc, Model); // All forms get passed the formContainer and a reference to the model object. 
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();

            // Clear current user
            Model.Logout();

            // Display Login form
            Login formLogin = new Login(Model);
            formLogin.ShowDialog();
            
            // Checks current user type and opens new form (i.e. managment board)
            Login.ProcessLogin(mc, Model);


        }

        private void employees_button_Click(object sender, EventArgs e)
        {
            var form = new addEmployee(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
            
        }

        private void specialOffers_button_Click(object sender, EventArgs e)
        {
            var form = new ViewSpecialOffers(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            var form = new viewListOfAvailableRooms(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new addCustomerToBannedList(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void occupancyRate_button_Click(object sender, EventArgs e)
        {
            var form = new viewListOfAvailableRooms(mc, Model);
            //    var form = new TakeOrder(mc, Model);
           form.Dock = DockStyle.Fill;
           form.Show();
        }
    }
}
