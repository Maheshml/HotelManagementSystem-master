using BusinessLayer;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class viewInventory : Form
    {
        mainContainer fc;

        private static IDataLayer DataLayer;
        private IModel Model = BusinessLayer.Model.GetInstance(DataLayer);


        public viewInventory()
        {

           // InitializeComponent();
           // mainContainer mainContainer = new mainContainer();
           // this.MdiParent = mainContainer;
        }

        private void backToManageStoclPanel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            //ManageStock manageStock = new ManageStock();
            //manageStock.Show();
        }

        private void managerInventoryHome_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //var restaurantKitchen = new RestaurantKitchenManagerAdminPanel();
            //ManageStock manageInventory = new ManageStock();
            //restaurantKitchen.ShowDialog();
        }

        private void manageStock_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
           // var manageStock = new ManageStock();
           // manageStock.ShowDialog();
        }


        private void manageSupplier_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manageSupplier = new ManageSuppliers();
            manageSupplier.Show();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RKManager = new DashboardKitchenManager(fc, Model);
            RKManager.Show();
        }


        private void setupMenu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var setupMenu = new SetUpMenu(fc, Model);
            setupMenu.Show();
        }

        private void getReport_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var getReport = new getReport(fc, Model);
            getReport.Show();
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {

        }
    }
}
