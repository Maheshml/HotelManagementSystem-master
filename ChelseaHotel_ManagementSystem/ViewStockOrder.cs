using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;
using System.Net.Mail;
using System.Net;

namespace ChelseaHotel_ManagementSystem
{
    public partial class ViewStockOrder : Form
    {
        IModel model;
        mainContainer mc;
        public ViewStockOrder(mainContainer parent,IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.model = model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        private void ViewStockOrder_Load(object sender, EventArgs e)
        {
           
        }

        private void button_Populate_Click(object sender, EventArgs e)
        {
            model.PopulateStockOrderList();
            foreach (StockOrder stock in model.StockOrderList)
            {
                string[] row1 = new string[] { stock.orderID.ToString(), stock.orderCreated.ToString(), stock.orderSent.ToString(), "null", stock.supplierID.ToString(), stock.deliverTo.ToString(), stock.orderTotal.ToString(), stock.status.ToString() };
                dataGridView_StockOrder.Rows.Add(row1);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            model.PopulateStockOrderItemList();
            model.PopulateItemList();
            string name = "";
            string email = "";
            model.PopulateSupplierList();
            int OrderNumber = 0;
            int StockOrderItemId = 0;
            int quantity = 0;
            string Item = "";
            int supplierId = 0;
            int ItemId = 0;
            int rowindex = dataGridView_StockOrder.CurrentCell.RowIndex;
            int columnindex = dataGridView_StockOrder.CurrentCell.ColumnIndex;
            int stockId = Convert.ToInt32(dataGridView_StockOrder.Rows[rowindex].Cells[columnindex].Value.ToString());
            foreach (StockOrder stock in model.StockOrderList)
            {
                if (stockId == stock.orderID)
                {
                    OrderNumber = stock.orderID;
                    supplierId = stock.supplierID;

                }
            }
            foreach (StockOrderItem sItem in model.StockOrderItemList)
            {
                if (stockId == sItem.OrderID)
                {
                    StockOrderItemId = sItem.OrderItemID;
                    quantity = sItem.Quantity;
                    ItemId = sItem.ItemID;
                }

            }
            foreach (Item item in model.ItemList)
            {
                if (ItemId == item.ItemID)
                {
                    Item = item.name;
                }
            }
            foreach (Supplier supplier in model.SupplierList)
            {
                if (supplierId == supplier.SupplierID)
                {
                    email = supplier.email;
                    name = supplier.name;
                }
            }
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("chelseahotelsystem2017@gmail.com", "Chelsea2017");
            string message = name + "\nWe require a delivery of " + quantity.ToString() + " " + Item + "\nChelsea Hotel";
            MailMessage mm = new MailMessage("chelseahotelsystem2017@gmail.com", "malone.daniel9@gmail.com", "Stock Order", message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);


        }
    }
}
