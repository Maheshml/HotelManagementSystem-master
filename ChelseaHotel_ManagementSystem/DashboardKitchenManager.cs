using BusinessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class DashboardKitchenManager : Form
    {


        #region Instance Attributes
        IModel Model;
        mainContainer mc;
        #endregion

       

        public DashboardKitchenManager(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        private void ManageStock_btn_Click(object sender, EventArgs e)
        {
            var form = new ViewStockOrder(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void setupMenu_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            var setupMenu = new SetUpMenu(mc, Model);
            setupMenu.Dock = DockStyle.Fill;
            setupMenu.Show();
           

        }

        private void getReport_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var getReport = new getReport(mc, Model);
            getReport.Dock = DockStyle.Fill;
            getReport.Show();
        }

        private void manageSupplier_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manageSupplier = new ManageSuppliers();
            manageSupplier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manageSupplier = new ManageSuppliers();
            manageSupplier.Show();
        }

        }
    }

