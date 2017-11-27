using System;
using System.Windows.Forms;
using BusinessLayer;

namespace ChelseaHotel_ManagementSystem
{
    public partial class ManageStock : Form
    {
        #region Instance Attributes
        private mainContainer mc;
        private IModel Model;
        #endregion

        #region Constructors
        public ManageStock(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var viewInventory = new viewInventory();
            viewInventory.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //var viewItem = new ViewItem();
           // viewItem.Show();

        }


        private void addItem_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //addItemToInventory addItem = new addItemToInventory();
            //addItem.ShowDialog();

        }

        private void managerInventory_getReport_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
           // var getReport = new getReport();
           // getReport.ShowDialog();

        }

        private void createStockOrder_btn_Click(object sender, EventArgs e)
        {
           // this.Hide();
           // var createStockOrder = new createStockOrder();
           // createStockOrder.ShowDialog();
        }

        private void receiveStockOrder_btn_Click(object sender, EventArgs e)
        {
           // this.Hide();
           // var receiveOrder = new receiveOrder();
           // receiveOrder.ShowDialog();
        }

        private void manageSupplier_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  var manageSupplier = new ManageSuppliers();
          //  manageSupplier.ShowDialog();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
           // var restaurantKitchen = new RestaurantKitchenManagerAdminPanel();
          //  restaurantKitchen.Show();


        }


        private void setupMenu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  var setupMenu = new setUpMenu();
          //  setupMenu.ShowDialog();
        }

        private void getReport_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  var getReport = new getReport();
          //  getReport.ShowDialog();
        }

    }
}
