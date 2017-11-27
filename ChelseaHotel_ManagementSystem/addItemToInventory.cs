using BusinessLayer;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class addItemToInventory : Form
    {
        mainContainer fc;

        private static IDataLayer DataLayer;
        private IModel Model = BusinessLayer.Model.GetInstance(DataLayer);

        public addItemToInventory()
        {
            //InitializeComponent();

            //mainContainer mainContainer = new mainContainer();
            //this.MdiParent = mainContainer;
        }
       
        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
          var rkManagerHome = new DashboardKitchenManager(fc, Model);
            rkManagerHome.ShowDialog();
        }

        private void managerStock_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            //var manageStock = new ManageStock();
            //manageStock.Show();

        }

        private void setupMenu_btn_Click(object sender, EventArgs e)
        {
            var setupMenu = new SetUpMenu(fc, Model);
            this.Hide();
            setupMenu.Show();

        }

        private void getReport_btn_Click(object sender, EventArgs e)
        {
            var getReport = new getReport(fc, Model);
            this.Hide();
            getReport.ShowDialog();


        }

        private void manageSupplier_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manageSupplier = new ManageSuppliers();
            manageSupplier.ShowDialog();
        }

       
    }
}
