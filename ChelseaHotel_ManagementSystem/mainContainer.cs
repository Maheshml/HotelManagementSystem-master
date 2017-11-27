using BusinessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class mainContainer : Form
    {

        #region Instance Attributes
        private IModel Model;
        #endregion


        #region Instance Properties
        public mainContainer(IModel Model)
        {
            
            InitializeComponent();
            this.Model = Model;

        }
        #endregion

        private void mainContainer_Load(object sender, EventArgs e)
        {
            
        }


        private void mainContainer_Shown(object sender, EventArgs e)
        {
            Login formLogin = new Login(Model);
            formLogin.ShowDialog();

            // Checks current user type and opens new form (i.e. managment board)
            Login.ProcessLogin(this, Model);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

            // Clear current user
            Model.Logout();

            // Display Login form
            Login formLogin = new Login(Model);
            formLogin.ShowDialog();

        }
    }
}
