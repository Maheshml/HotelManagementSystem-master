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
using System;

namespace ChelseaHotel_ManagementSystem
{
    public partial class receiveOrder : Form
    {
        #region Instance Attributes
        private IModel Model;
        mainContainer mc;
        double orderTotal = 0;
        String orderID;
        


        #endregion

        #region Instance Properties

        #endregion


        #region Constructors
        public receiveOrder(mainContainer parent,IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
           
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
            this.Model = Model;
        }


        #endregion

        private void receiveOrder_Load(object sender, EventArgs e)
        {
            Model.PopulateStockOrderList();
            

            if (Model.StockOrderList != null)
            {
                Model.PopulateStockOrderItemList();

                foreach (StockOrder aOrder in Model.StockOrderList)
                {
                    if (aOrder.status == "Sent")
                    {

                        Model.PopulateSupplierList();
                        foreach(Supplier aSupplier in Model.SupplierList)
                        {
                            if(aSupplier.SupplierID==aOrder.supplierID)
                            {
                                orders.Rows.Add(aOrder.orderID, aSupplier.name, string.Format("{0:0.00}", aOrder.orderTotal),  aOrder.orderSent, aOrder.status);
                            }
                        }
                        
                    }
                }
            }

            else
            {
                MessageBox.Show("Empty");
            }
        }

        private void orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Clear();

            orderID = orders.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            foreach(StockOrderItem aItem in Model.StockOrderItemList)
            {
                if(aItem.OrderID==Convert.ToInt16(orderID))
                {
                    Model.PopulateItemList();

                    foreach(Item aInvItem in Model.ItemList)
                    {
                        if(aItem.ItemID==aInvItem.ItemID)
                        {
                            dataGridView1.Rows.Add(aItem.ItemID, aInvItem.name, string.Format("{0:0.00}", aInvItem.unitPrice), string.Format("{0:0.00}", aItem.Total), aItem.Quantity);
                            orderTotal+= Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                            textBox6.Text = string.Format("{0:0.00}", orderTotal);
                        }
                    }
                }
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                orderTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    orderTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
                textBox6.Text = string.Format("{0:0.00}", orderTotal);
            }

            else
            {
                orderTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    double price= Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    int total= Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    dataGridView1[3, i].Value = price * total;
                    orderTotal += price*total;
                }
                textBox6.Text = string.Format("{0:0.00}", orderTotal);
                int index = orders.CurrentCell.RowIndex;

                orders[2, index].Value = string.Format("{0:0.00}", orderTotal);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            


            DialogResult dialogResult = MessageBox.Show("Order Total: € "+ string.Format("{0:0.00}", orderTotal) +"\n\nAre you sure you wish to finishing receiving this order?", "Receive Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkBox1.Checked)
                {
                    orderTotal = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        orderTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    textBox6.Text = string.Format("{0:0.00}", orderTotal);

                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        foreach(StockOrderItem aItem in Model.StockOrderItemList)
                        {
                            if (aItem.ItemID == Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))
                            {
                                aItem.QtyReceived = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                                aItem.Total = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                                Model.ReceiveStockOrderItem(aItem);
                            }
                        }

                        foreach(Item anII in Model.ItemList)
                        {
                            if (anII.name.Equals(dataGridView1.Rows[i].Cells[1].Value))
                            {
                                anII.quantity+= Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                                Model.UpdateItemQuantity(anII);
                            }
                        }
                    }
                }

                else
                {
                    orderTotal = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        double price = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                        int total = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                        dataGridView1[3, i].Value = string.Format("{0:0.00}", price*total);

                        orderTotal += price * total;

                        foreach(StockOrderItem aItem in Model.StockOrderItemList)
                        {
                            if (aItem.OrderID== Convert.ToInt32(orders.Rows[i].Cells[0].Value))
                            {
                                aItem.QtyReceived = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                                aItem.Total = price * total;
                                Model.ReceiveStockOrderItem(aItem);
                            }
                        }

                        foreach (Item anII in Model.ItemList)
                        {
                            if (anII.name.Equals(dataGridView1.Rows[i].Cells[1].Value))
                            {
                                anII.quantity+= Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                                Model.UpdateItemQuantity(anII);
                            }
                        }
                    }
                    textBox6.Text = string.Format("{0:0.00}", orderTotal);
                    int index = orders.CurrentCell.RowIndex;

                    orders[2, index].Value = string.Format("{0:0.00}", orderTotal);

                }

                foreach (StockOrder aOrder in Model.StockOrderList)
                {
                    if(aOrder.orderID==Convert.ToInt16(orderID))
                    {
                        aOrder.orderTotal = orderTotal;
                    }
                }

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    int itemID= Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                    foreach(Item anItem in Model.ItemList)
                    {
                        if(itemID==anItem.ItemID)
                        {
                            anItem.quantity+= Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                            
                            foreach(StockOrder anOrder in Model.StockOrderList)
                            {
                                if(anOrder.orderID==Convert.ToInt16(orderID))
                                {
                                    anOrder.status = "Order Received";
                                    anOrder.orderTotal = orderTotal;
                                    Model.ReceiveStockOrder(anOrder);
                                    
                                }
                            }
                        }
                    }

                }

                
                MessageBox.Show("Order has been received and inventory updated");
                
            }
        }
    }
}
