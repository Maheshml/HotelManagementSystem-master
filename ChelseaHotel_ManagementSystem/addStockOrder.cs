using BusinessEntities;
using BusinessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace ChelseaHotel_ManagementSystem
{
    public partial class addStockOrder : Form
    {
        #region Instance Attributes
        private IModel Model;
        mainContainer mc;
        double orderTotal = 0;



        #endregion

        #region Instance Properties

        #endregion


        #region Constructors
        public addStockOrder(mainContainer parent, IModel Model)
        {
         

            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel1.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel1.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel1.Height) / 2);
            button2.Enabled = false;
        }
        #endregion


        public void creatStockOrderDoc()
        {

            var glue = new Chunk(new VerticalPositionMark());
            var doc = new Document();

            var bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, false);
            var times = new Font(bfTimes, 22);

            var OrderItem = BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, false);
            var OrderItemFont = new Font(OrderItem, 16);

            var Total = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false);
            var OrderTotal = new Font(Total, 14);


            Random rm = new Random();

            var ramString = rm.Next(0, 5000).ToString();
            try
            {
                doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 25, 3);
                //Horizontal rule
                var hr =
                    new Paragraph(
                        new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK,
                            Element.ALIGN_CENTER, 1)));

                //path to save the doc
                var wri = PdfWriter.GetInstance(doc,
                    new FileStream(
                        "C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\ChelseaHotel_ManagementSystem\\Resources\\StockOrder" + ramString+ ".pdf",
                        FileMode.Create));
          

                var lineBreak =
                    new Paragraph(
                        new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.WHITE,
                             Element.ALIGN_LEFT, 10)));

                doc.Open();


                //add logo to the PDF document
                var Logo =
                    iTextSharp.text.Image.GetInstance(

                        "C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\ChelseaHotel_ManagementSystem\\Resources\\Logo\\logo.jpg");
                Logo.ScalePercent(25f);
                Logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(Logo);
                //add title to the PDF document


                var pageTitle = new Paragraph("\t\tStock Order", times)
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 40
                };
                doc.Add(pageTitle);
                doc.Add(hr); //add a Horizontal line separating the the title and logo from the menu items
                doc.Add(lineBreak);



                doc.Add(lineBreak);
             
                var Order = new Paragraph("Items: ", OrderItemFont)
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 2
                };
                Order.IndentationLeft = 10;
                doc.Add(Order);
                doc.Add(lineBreak);


                // create table
                PdfPTable table = new PdfPTable(5);
                table.DefaultCell.Border = Rectangle.NO_BORDER;
                
                PdfPCell cell1 = new PdfPCell(new Phrase("Item ID"));
                PdfPCell cell2 = new PdfPCell(new Phrase("Item Name"));
                PdfPCell cell3 = new PdfPCell(new Phrase("Quantity"));
                PdfPCell cell4 = new PdfPCell(new Phrase("Unit Price"));
                PdfPCell cell5 = new PdfPCell(new Phrase("Total Items"));

                cell1.BorderWidth = 0;
                cell2.BorderWidth = 0;
                cell3.BorderWidth = 0;
                cell4.BorderWidth = 0;
                cell5.BorderWidth = 0;

                table.AddCell(cell1);
                table.AddCell(cell2);
                table.AddCell(cell3); 
                table.AddCell(cell4);
                table.AddCell(cell5);

                double unitPrice;

                try
                {

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        unitPrice = Convert.ToDouble(dataGridView1.Rows[i].Cells["unitPrice"].Value);

                        table.AddCell(dataGridView1.Rows[i].Cells["itemID"].Value.ToString());
                        table.AddCell(dataGridView1.Rows[i].Cells["itemName"].Value.ToString());
                        table.AddCell(dataGridView1.Rows[i].Cells["quantity"].Value.ToString());
                        table.AddCell("€"+unitPrice.ToString("0.00"));
                        table.AddCell(dataGridView1.Rows[i].Cells["total"].Value.ToString());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please fill up the order!");
                }


              //  table.HorizontalAlignment = 2;


                doc.Add(table);


                double orderBalance = Convert.ToDouble(OrderTotal_txtbox.Text);

                var _total = new Paragraph("Total: €"+ orderBalance.ToString("0.00")+"€", OrderTotal)
                {
                    Alignment = Element.ALIGN_RIGHT,
                    PaddingTop = 5
                };
                _total.IndentationRight = 10;
                doc.Add(_total);

                doc.Add(lineBreak);
                var OrderDetails = new Paragraph("Order Details: ", OrderItemFont)
                {
                    Alignment = Element.ALIGN_LEFT,
                    
                };
                OrderDetails.IndentationLeft = 20;
                doc.Add(OrderDetails);
                doc.Add(lineBreak);


                PdfPTable TableOrderDetails = new PdfPTable(2);
                TableOrderDetails.DefaultCell.Border = Rectangle.NO_BORDER;
                TableOrderDetails.WidthPercentage = 40;
                TableOrderDetails.HorizontalAlignment = 0;
  

                PdfPCell HCell1 = new PdfPCell(new Phrase(""));
                PdfPCell HCell2 = new PdfPCell(new Phrase(""));

                TableOrderDetails.AddCell("Supplier: ");
                TableOrderDetails.AddCell(supplier_combo.Text);

                TableOrderDetails.AddCell("Deliver To: ");
                TableOrderDetails.AddCell(deliverTo_txtbox.Text);

                TableOrderDetails.AddCell("Created Date: ");
                //TableOrderDetails.AddCell(dateTimePicker1.Text);



                doc.Add(TableOrderDetails);


            }
            catch
                (iTextSharp.text.BadElementException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                doc.Close();
                doc = null;
            }
        }

        private void calculateOrderTotal()
        {
            int countRows = dataGridView1.RowCount;
            for (int i = 0; i < countRows - 1; i++)
            {
                String totalGet = Convert.ToString(dataGridView1.Rows[0].Cells[4].FormattedValue.ToString());
                orderTotal += Convert.ToDouble(totalGet);
                MessageBox.Show(Convert.ToString(orderTotal));
            }
        }


        private void createStockOrder_Load(object sender, EventArgs e)
        {
            Model.PopulateSupplierList();

            foreach (Supplier aSup in Model.SupplierList)
            {
                supplier_combo.Items.Add(aSup.name);
            }

        }
        //save stock order
        private void button1_Click(object sender, EventArgs e)
        {
            //creatStockOrderDoc();
            button2.Enabled = true;
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to create this stock order?", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime orderCreated = Convert.ToDateTime(dateTimePicker1.Text);
                string supplierName = supplier_combo.SelectedItem.ToString();
                int supplierID = 0;
                string deliverTo = deliverTo_txtbox.Text;
                string status = "Not Sent";
                double orderTotal = Convert.ToDouble(OrderTotal_txtbox.Text);
                int highest = 0;
                


                foreach (Supplier aSupplier in Model.SupplierList)
                {
                    if (aSupplier.name == supplierName)
                    {
                        supplierID = aSupplier.SupplierID;
                    }
                }

                Model.AddNewStockOrder(orderCreated, supplierID, deliverTo, orderTotal, status);

                foreach (StockOrder aOrder in Model.StockOrderList)
                {


                    if (aOrder.orderID > highest)
                    {
                        highest = aOrder.orderID;
                       
                    }
                }

                int rowsCount = dataGridView1.Rows.Count;

                for (int i = 0; i <= rowsCount - 1; i++)
                {
                    string itemID = Convert.ToString(dataGridView1.Rows[i].Cells[0].FormattedValue.ToString());
                    int theItemID = Convert.ToInt16(itemID);

                    string qty = Convert.ToString(dataGridView1.Rows[i].Cells[2].FormattedValue.ToString());
                    int theQty = Convert.ToInt16(qty);

                    string total = Convert.ToString(dataGridView1.Rows[i].Cells[4].FormattedValue.ToString());
                    double theTotal = Convert.ToDouble(total);

                    Model.AddNewStockOrderItem(theItemID, theQty, theTotal, highest);

                }


            }

        }

        private void supplier_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemNameCombo.Items.Clear();
            int supplierID = 0;
            String supplier = supplier_combo.SelectedItem.ToString();
            Model.PopulateSupplierList();
            Model.PopulateItemList();


            MessageBox.Show(supplier_combo.Text);
            foreach (Supplier aSupplier in Model.SupplierList)
            {
                if (aSupplier.name == supplier)
                {
                    supplierID = aSupplier.SupplierID;
                }
            }

            foreach (Item aItem in Model.ItemList)
            {
                if (aItem.supplierID == supplierID)
                {
                    itemNameCombo.Items.Add(aItem.name);
                }
            }


        }

        //private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    int quantity;
        //    string SelectedText;
        //    SelectedText = Convert.ToString(dataGridView1.Rows[0].Cells[1].FormattedValue.ToString());

        //    this.dataGridView1.Rows[0].Cells[3].Value = SelectedText;
        //    foreach (Item aItem in Model.ItemList)
        //    {
        //        if (aItem.name == SelectedText)
        //        {
        //            quantity = aItem.quantity;
        //        }
        //    }

        //}




        private void itemNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.Rows.Count;
            String item = itemNameCombo.SelectedItem.ToString();

            foreach (Item aItem in Model.ItemList)
            {
                if (aItem.name == item)
                {
                    if (rowCount <= 2)
                    {

                        this.dataGridView1.Rows[0].Cells[0].Value = aItem.ItemID;
                        this.dataGridView1.Rows[0].Cells[1].Value = aItem.name;
                        this.dataGridView1.Rows[0].Cells[3].Value = string.Format("{0:0.00}", aItem.unitPrice);
                    }

                    else
                    {

                        this.dataGridView1.Rows[rowCount - 2].Cells[0].Value = aItem.ItemID;
                        this.dataGridView1.Rows[rowCount - 2].Cells[1].Value = aItem.name;
                        this.dataGridView1.Rows[rowCount - 2].Cells[3].Value = string.Format("{0:0.00}", aItem.unitPrice);
                    }


                }

            }
        }

        private void quantityNumerical_ValueChanged(object sender, EventArgs e)
        {
            int rowsCount = dataGridView1.Rows.Count;
            string unitPrice;

            string totals = "";
            int theQuantity = (int)quantityNumerical.Value;
            double theTotal = 0;


            if (rowsCount <= 2)
            {
                this.dataGridView1.Rows[0].Cells[2].Value = theQuantity;
                unitPrice = Convert.ToString(dataGridView1.Rows[rowsCount - 1].Cells[3].FormattedValue.ToString());
                double aUnitPrice = Convert.ToDouble(unitPrice);
                double total = aUnitPrice * theQuantity;
                orderTotal += total;
                this.dataGridView1.Rows[0].Cells[4].Value = string.Format("{0:0.00}", total);

            }

            else
            {
                this.dataGridView1.Rows[rowsCount - 2].Cells[2].Value = theQuantity;
                unitPrice = Convert.ToString(dataGridView1.Rows[rowsCount - 1].Cells[3].FormattedValue.ToString());
                double aUnitPrice = Convert.ToDouble(unitPrice);
                double total = aUnitPrice * theQuantity;
                orderTotal += total;
                this.dataGridView1.Rows[rowsCount - 2].Cells[4].Value = string.Format("{0:0.00}", total);

            }

            for (int i = 0; i <= rowsCount - 1; i++)
            {
                totals = Convert.ToString(dataGridView1.Rows[i].Cells[4].FormattedValue.ToString());
                theTotal += Convert.ToDouble(totals);

            }

            OrderTotal_txtbox.Text = string.Format("{0:0.00}", theTotal); 

        }

        private void addItem_btn_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(1);

            int rows = dataGridView1.Rows.Count;

            int index = dataGridView1.CurrentCell.RowIndex;
            String message = Convert.ToString(index);


        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to cancel creating this stock order?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }










        //
        //  print the stock order
        //
        private async void button2_Click(object sender, EventArgs e)
        {

            PrintStokOrder ps = new PrintStokOrder();

            try
            {
                creatStockOrderDoc();

                ps.ShowDialog();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public async Task<string> WaitAsynchronouslyAsync()
        {
            await Task.Delay(10);
            return "Finished";
        }

        private void OrderTotal_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiveOrder_btn_Click(object sender, EventArgs e)
        {

            receiveOrder form = new receiveOrder(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }































        //private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        // {
        //     double price;
        //     string quantity=null;
        //     int theQuantity;
        //     double thetotal=0;
        //    // SelectedText = Convert.ToString(dataGridView1.Rows[0].Cells[1].FormattedValue.ToString());

        //  //   this.dataGridView1.Rows[0].Cells[3].Value = SelectedText;
        //     foreach(Item aItem in Model.ItemList)
        //     {
        //     //if (aItem.name==SelectedText)
        //     //{
        //     // price = aItem.unitPrice;
        //     //        this.dataGridView1.Rows[0].Cells[3].Value = price;
        //     // quantity= Convert.ToString(dataGridView1.Rows[0].Cells[2].FormattedValue.ToString());

        //     //        if (quantity==null)
        //     //        {
        //     //            theQuantity = 0;
        //     //            thetotal = 0;
        //     //        }

        //     //        else if (quantity!=null)
        //     //        {
        //     //            theQuantity = Convert.ToInt16(quantity);
        //     //            thetotal = price * theQuantity;
        //     //        }



        //     //    this.dataGridView1.Rows[0].Cells[4].Value = thetotal;

        //     //    }
        //     }


    }
    }
