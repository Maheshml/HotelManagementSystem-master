using BusinessLayer;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class viewItem : Form
    {
        mainContainer fc;

        private static IDataLayer DataLayer;
        private IModel Model = BusinessLayer.Model.GetInstance(DataLayer);

        public viewItem()
        {
            InitializeComponent();
        }

       

        private void manageSupplier_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manageSupplier = new ManageSuppliers();
            manageSupplier.ShowDialog();
        }



        private void setupMenu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var setupMenu = new SetUpMenu(fc, Model);
            setupMenu.ShowDialog();

        }

        private void getReport_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var getReport = new getReport(fc, Model);
            getReport.ShowDialog();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            var restaurantKitchen = new DashboardKitchenManager(fc, Model);
            restaurantKitchen.Show();
            this.Close();
        }

        private void manageStock_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
           // var manageStock = new ManageStock();
            //manageStock.ShowDialog();

        }
     }
}
