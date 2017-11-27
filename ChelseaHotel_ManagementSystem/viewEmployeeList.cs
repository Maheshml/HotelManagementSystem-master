using BusinessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class viewEmployeeList : Form
    {

        #region Instance Attributes
        IModel Model;
        mainContainer mc;
        #endregion

        public viewEmployeeList(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var displayEmployeeList = new viewEmployeeDetails(mc, Model);
            displayEmployeeList.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new addEmployee(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}


