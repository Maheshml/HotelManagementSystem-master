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
using DataAccessLayer;


namespace ChelseaHotel_ManagementSystem
{
    public partial class DashboardReceptionist : Form
    {
        #region Instance Attributes
        private IModel Model;
        mainContainer mc;
        #endregion

        public DashboardReceptionist(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel1.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel1.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel1.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bannedCustomersButton_Click(object sender, EventArgs e)
        {
            //var setmenu = new viewListOfBannedCustomers(Model);
            //setmenu.Show();
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

        private void button10_Click(object sender, EventArgs e)
        {
            addBooking form = new addBooking(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkIn_btn_Click(object sender, EventArgs e)
        {
            checkIn form = new checkIn(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
            checkOut form = new checkOut(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
