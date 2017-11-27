using BusinessLayer;
using DataAccessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace ChelseaHotel_ManagementSystem
{
    public partial class sendOrdercsToKitchen : Form
    {
        #region Instance Attributes

        mainContainer fc;

        private static IDataLayer DataLayer;
        private IModel Model = BusinessLayer.Model.GetInstance(DataLayer);

        #endregion

        //
        //  create the order PDF
        //

        #region createMenu

        public void SendOrderPdf()
        {
            var table = new PdfPTable(3);
            var glue = new Chunk(new VerticalPositionMark());
            var doc = new Document();
            var bfHelvica = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            var Helvica = new Font(bfHelvica, 16);
            var itemType = BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, false);
            var itemTypeTilte = new Font(itemType, 16);
            var itemP = BaseFont.CreateFont(BaseFont.HELVETICA_OBLIQUE, BaseFont.CP1252, false);
            var itemPrice = new Font(itemP, 12);

            try
            {
                doc = new Document(iTextSharp.text.PageSize.A5, 10, 10, 25, 3);
                //Horizontal rule
                var hr =
                    new Paragraph(
                        new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK,
                            Element.ALIGN_CENTER, 1)));

                //small horizontal rule
                var shr =
                    new Paragraph(
                        new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 50.0F, BaseColor.BLACK,
                            Element.ALIGN_CENTER, 1)));
                //path to save the doc
                Random rdm = new Random();
                string fileName = "Order" + viewTicketNum_lbl.Text;
                DateTime datetime = DateTime.Now;
                string datet = datetime.ToString();
                var count = 0.0;
                int num = rdm.Next(1, 20);
                //if (File.Exists("C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\Kitchen Order\\" + fileName + ".pdf"))
                //{
                //    count++;
                //    fileName +=count;

                //}


                var wri = PdfWriter.GetInstance(doc,
                    new FileStream(
                        "C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\ChelseaHotel_ManagementSystem\\Resources\\Kitchen Order\\" +
                        fileName + ".pdf",
                        FileMode.Create));


                var lineBreak =
                    new Paragraph(
                        new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.WHITE,
                            Element.ALIGN_LEFT, 10)));


                doc.Open();


                //add title to the PDF document

                var pageTitle =
                    new Paragraph(
                        "Order Number: " + viewTicketNum_lbl.Text + "\nDate:  " + DateTime.Now.ToString(@"yyyy/MM/dd") +
                        "\t Time: " + DateTime.Now.ToString(@"HH:MM"), Helvica)
                    {
                        Alignment = Element.ALIGN_LEFT,
                        PaddingTop = 40
                    };
                doc.Add(pageTitle);
                var tableNum = new Paragraph("Table Number: " + showTableNum_lbl.Text, Helvica)
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 40
                };
                doc.Add(tableNum);
                doc.Add(lineBreak);

                foreach (KeyValuePair<string, int> item in orderList)
                {
                    var itemp = new Paragraph(item.Key + " x " + item.Value)
                    {
                        Alignment = Element.ALIGN_LEFT,
                        PaddingTop = 2
                    };
                    doc.Add(itemp);
                }

                doc.Add(lineBreak);
                var specialReq = new Paragraph("Special Requirement: \n" + specialResq_textBox1.Text)
                {
                    Alignment = Element.ALIGN_LEFT,
                    PaddingTop = 10
                };

                doc.Add(specialReq);
                doc.Add(lineBreak);
                doc.Add(lineBreak);
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

        #endregion

        //method to populate the grid with data from the database
        private void PopulateGrid()
        {
            foreach (var drink in Model.DrinksList)
            {
                drink_dataGridView.Rows.Add(drink.DrinkName, drink.DrinkPrice);
            }

            foreach (var menuItem in Model.MenuItemList)
            {
                switch (menuItem.ItemType)
                {
                    case "Desserts":
                        deserts_dataGridView.Rows.Add(menuItem.ItemName, menuItem.ItemPrice, menuItem.ItemType);
                        break;
                    case "Main courses":
                        mainCourses_dataGridView3.Rows.Add(menuItem.ItemName, menuItem.ItemPrice, menuItem.ItemType);
                        break;
                    case "Starters & Light Bits":
                        bites_dataGridView4.Rows.Add(menuItem.ItemName, menuItem.ItemPrice, menuItem.ItemType);
                        break;
                    case "Sides":
                        sides_dataGridView2.Rows.Add(menuItem.ItemName, menuItem.ItemPrice, menuItem.ItemType);
                        break;
                    default:
                        // MessageBox.Show(@"No Items");
                        break;
                }
            }
        }

        List<object> orderToKitchenList = new List<object>();

        Dictionary<string, int> orderList = new Dictionary<string, int>();
        Dictionary<string, int> orderToDB = new Dictionary<string, int>();

        #region Constructors

        public sendOrdercsToKitchen(IModel Model)
        {
            InitializeComponent();

            this.Model = Model;

            //call the method to populate the grids with drinks and item!
            PopulateGrid();
            //orderList.Clear();

            #region disable options at start of the application

            order_DataGridView1.Enabled = false;
            drink_dataGridView.Enabled = false;
            mainCourses_dataGridView3.Enabled = false;
            deserts_dataGridView.Enabled = false;
            sides_dataGridView2.Enabled = false;
            bites_dataGridView4.Enabled = false;
            send_btn.Enabled = false;
            AddSpecialRequest_button1.Enabled = false;

            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            cancel_btn.Enabled = false;
            newTicket_btn.Enabled = false;
            changeTable_btn.Enabled = false;

            #endregion
        }

        #endregion

        private double _balance;
        private string _ticketNum;
        private string _drinkName;
        private double _drinkPrice;
        private string _dessert;
        private double _dessertPrice;
        private string _itemType;


        //------------  WILL BE SENT TO THE ORDER TABLE -------------
        private string _mainCourse; //
        private double _mainCoursePrice; //  MAIN COURSE


        private string _starterBites; //
        private double _starterBitesPrice; //  STARTERS & LIGHT BITES


        private string _sides; //
        private double _sidesPrice; //  SIDES


        private string tableNumber; //  the table number will be also sent to the kitchen
        //  -----------------------     END     -------------------------------


        private int itemQty = 1;
        private int _tichetNum = 1;
        private string _thiscketNumCHR;
        private int _DeleteRowIndex = 0;

        //
        //  populate the "order_datagrid" with the values selected from the "drinks_datagrid", "desserts_datagrid", 
        //  "maincourse_datagrid", "bites_datagrid" and "sodes_datagrid"
        //
        private void drink_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            //  get the value selected and assign the item name and item price to two local variables
            //
            _drinkName = drink_dataGridView.Rows[e.RowIndex].Cells["drinks"].Value.ToString();
            _drinkPrice = Convert.ToDouble(drink_dataGridView.Rows[e.RowIndex].Cells["drinkPrice"].Value);
            _itemType = "drink";
            var flag = false;
            //
            //  if the "order_datagrid" is empty, set the first row
            //
            if (order_DataGridView1.RowCount <= 0)
                order_DataGridView1.Rows.Add(_drinkName, _drinkPrice.ToString("0.00"), itemQty, _itemType);
            //
            // else, check if the item selected in the "drinks_datagrid" is already in the "order_datagrid"
            //
            else
            {
                for (var i = 0; i < order_DataGridView1.RowCount; i++)
                {
//
                    //  if the item selected is not equal to the item and item in the "order_datagrid" continue checking the item in the data grid
                    //  if the item is found, add one to the itemQty variable and set the flag variable to true.
                    //  update the quantity column in the "order_datagrid"
                    //
                    if (!order_DataGridView1.Rows[i].Cells["ItemName"].Value.Equals(_drinkName)) continue;
                    flag = true;
                    itemQty = Convert.ToInt16(order_DataGridView1.Rows[i].Cells["qty_column"].Value) + 1;
                    order_DataGridView1.Rows[i].Cells["qty_column"].Value = itemQty.ToString();
                }
                //
                //  if the variable flag is false (item is was not found) add the new item to the "order_datagrid"
                //
                if (flag == false)
                {
                    order_DataGridView1.Rows.Add(_drinkName, _drinkPrice, itemQty, _itemType);
                    _DeleteRowIndex++;
                }
            }

            //
            //  update the global variable that holds the balance
            //  add the balance variable to the balance_txt
            //  set the "itemQty" variable to one. 
            //
            _balance += _drinkPrice;
            balance_txtb.Text = "€" + _balance.ToString("0.00");
            itemQty = 1;
        }

        private void deserts_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _dessert = deserts_dataGridView.Rows[e.RowIndex].Cells["desserts"].Value.ToString();
            _dessertPrice = Convert.ToDouble(deserts_dataGridView.Rows[e.RowIndex].Cells["dPrice"].Value);
            _itemType = "dessert";
            var flag = false;


            if (order_DataGridView1.RowCount <= 0)
                order_DataGridView1.Rows.Add(_dessert, _dessertPrice.ToString("0.00"), itemQty, _itemType);
            else
            {
                for (var i = 0; i < order_DataGridView1.RowCount; i++)
                {
                    if (!order_DataGridView1.Rows[i].Cells["ItemName"].Value.Equals(_dessert)) continue;
                    flag = true;
                    itemQty = Convert.ToInt16(order_DataGridView1.Rows[i].Cells["qty_column"].Value) + 1;
                    order_DataGridView1.Rows[i].Cells["qty_column"].Value = itemQty.ToString();
                }
                if (flag == false)
                    order_DataGridView1.Rows.Add(_dessert, _dessertPrice.ToString("0.00"), itemQty, _itemType);
                _DeleteRowIndex++;
            }


            _balance += _dessertPrice;
            balance_txtb.Text = "€" + _balance.ToString("0.00");
            ;
            itemQty = 1;
        }

        private void mainCourses_dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _mainCourse = mainCourses_dataGridView3.Rows[e.RowIndex].Cells["mainCourse"].Value.ToString();
            _mainCoursePrice = Convert.ToDouble(mainCourses_dataGridView3.Rows[e.RowIndex].Cells["price"].Value);
            _itemType = "Main Course";

            var flag = false;


            if (order_DataGridView1.RowCount <= 0)
                order_DataGridView1.Rows.Add(_mainCourse, _mainCoursePrice.ToString("0.00"), itemQty, _itemType);
            else
            {
                for (var i = 0; i < order_DataGridView1.RowCount; i++)
                {
                    if (!order_DataGridView1.Rows[i].Cells["ItemName"].Value.Equals(_mainCourse)) continue;
                    flag = true;
                    itemQty = Convert.ToInt16(order_DataGridView1.Rows[i].Cells["qty_column"].Value) + 1;
                    order_DataGridView1.Rows[i].Cells["qty_column"].Value = itemQty.ToString();
                }
                if (flag == false)
                {
                    order_DataGridView1.Rows.Add(_mainCourse, _mainCoursePrice.ToString("0.00"), itemQty, _itemType);
                    _DeleteRowIndex++;
                }
            }


            _balance += _mainCoursePrice;
            balance_txtb.Text = "€" + _balance.ToString("0.00");
            ;
            itemQty = 1;
        }

        private void bites_dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _starterBites = bites_dataGridView4.Rows[e.RowIndex].Cells["starterBites"].Value.ToString();
            _starterBitesPrice = Convert.ToDouble(bites_dataGridView4.Rows[e.RowIndex].Cells["startersBitesPrice"].Value);
            _itemType = "Starters Light Bites";

            var flag = false;


            if (order_DataGridView1.RowCount <= 0)
                order_DataGridView1.Rows.Add(_starterBites, _starterBitesPrice.ToString("0.00"), itemQty, _itemType);
            else
            {
                for (var i = 0; i < order_DataGridView1.RowCount; i++)
                {
                    if (!order_DataGridView1.Rows[i].Cells["ItemName"].Value.Equals(_starterBites)) continue;
                    flag = true;
                    itemQty = Convert.ToInt16(order_DataGridView1.Rows[i].Cells["qty_column"].Value) + 1;
                    order_DataGridView1.Rows[i].Cells["qty_column"].Value = itemQty.ToString();
                }
                if (flag == false)
                {
                    order_DataGridView1.Rows.Add(_starterBites, _starterBitesPrice.ToString("0.00"), itemQty, _itemType);
                    _DeleteRowIndex++;
                }
            }


            _balance += _starterBitesPrice;
            balance_txtb.Text = "€" + _balance.ToString("0.00");
            ;
            itemQty = 1;
        }

        private void sides_dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _sides = sides_dataGridView2.Rows[e.RowIndex].Cells["sides"].Value.ToString();
            _sidesPrice = Convert.ToDouble(sides_dataGridView2.Rows[e.RowIndex].Cells["sidesPrice"].Value);
            _itemType = "Sides";

            var flag = false;

            if (order_DataGridView1.RowCount <= 0)
                order_DataGridView1.Rows.Add(_sides, _sidesPrice.ToString("0.00"), itemQty, _itemType);
            else
            {
                for (var i = 0; i < order_DataGridView1.RowCount; i++)
                {
                    if (!order_DataGridView1.Rows[i].Cells["ItemName"].Value.Equals(_sides)) continue;
                    flag = true;
                    itemQty = Convert.ToInt16(order_DataGridView1.Rows[i].Cells["qty_column"].Value) + 1;
                    order_DataGridView1.Rows[i].Cells["qty_column"].Value = itemQty.ToString();
                }
                if (flag == false)
                {
                    order_DataGridView1.Rows.Add(_sides, _sidesPrice.ToString("0.00"), itemQty, _itemType);
                    _DeleteRowIndex++;
                }
            }


            _balance += _sidesPrice;
            balance_txtb.Text = "€" + _balance.ToString("0.00");
            ;
            itemQty = 1;
        }

        //
        //  add another item to the item in the selected row
        //
        private void plus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var rowIndex = order_DataGridView1.CurrentCell.RowIndex;
                var ItemPrice = Convert.ToDouble(order_DataGridView1.Rows[rowIndex].Cells["price_column"].Value);
                var itemQty = Convert.ToInt64(order_DataGridView1.Rows[rowIndex].Cells["qty_column"].Value) + 1;

                if (itemQty == 0)
                    order_DataGridView1.Rows.RemoveAt(order_DataGridView1.Rows[rowIndex].Index);
                else
                    order_DataGridView1.Rows[rowIndex].Cells["qty_column"].Value = itemQty;


                _balance += ItemPrice;

                if (_balance < 0)
                    _balance = 0;
                else
                    balance_txtb.Text = "€" + _balance.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        //  subtract an item from a selected row
        //
        private void minus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var rowIndex = order_DataGridView1.CurrentCell.RowIndex;
                var ItemPrice = Convert.ToDouble(order_DataGridView1.Rows[rowIndex].Cells["price_column"].Value);
                var itemQty = Convert.ToInt64(order_DataGridView1.Rows[rowIndex].Cells["qty_column"].Value) - 1;

                if (itemQty == 0)
                    order_DataGridView1.Rows.RemoveAt(order_DataGridView1.Rows[rowIndex].Index);
                else
                    order_DataGridView1.Rows[rowIndex].Cells["qty_column"].Value = itemQty;


                _balance -= ItemPrice;

                if (_balance < 0)
                    _balance = 0;
                else
                    balance_txtb.Text = "€" + _balance.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        //set up the table numbers
        //
        private void t1_btn_Click(object sender, EventArgs e)
        {
            tableNumber = "T1";
            showTableNum_lbl.Text = tableNumber;


            order_DataGridView1.Enabled = true;
            drink_dataGridView.Enabled = true;
            mainCourses_dataGridView3.Enabled = true;
            deserts_dataGridView.Enabled = true;
            sides_dataGridView2.Enabled = true;
            bites_dataGridView4.Enabled = true;
            send_btn.Enabled = true;
            AddSpecialRequest_button1.Enabled = true;
            t1_btn.Enabled = true;
            t2_btn.Enabled = false;
            t3_btn.Enabled = false;
            t4_btn.Enabled = false;
            t5_btn.Enabled = false;
            t6_btn.Enabled = false;
            plus_btn.Enabled = true;
            minus_btn.Enabled = true;
            cancel_btn.Enabled = true;
            newTicket_btn.Enabled = true;
            changeTable_btn.Enabled = true;
        }

        private void t2_btn_Click(object sender, EventArgs e)
        {
            tableNumber = "T2";
            showTableNum_lbl.Text = tableNumber;

            order_DataGridView1.Enabled = true;
            drink_dataGridView.Enabled = true;
            mainCourses_dataGridView3.Enabled = true;
            deserts_dataGridView.Enabled = true;
            sides_dataGridView2.Enabled = true;
            bites_dataGridView4.Enabled = true;
            send_btn.Enabled = true;
            AddSpecialRequest_button1.Enabled = true;
            t1_btn.Enabled = false;
            t2_btn.Enabled = true;
            t3_btn.Enabled = false;
            t4_btn.Enabled = false;
            t5_btn.Enabled = false;
            t6_btn.Enabled = false;
            plus_btn.Enabled = true;
            minus_btn.Enabled = true;
            cancel_btn.Enabled = true;
            newTicket_btn.Enabled = true;
            changeTable_btn.Enabled = true;
        }

        private void t3_btn_Click(object sender, EventArgs e)
        {
            tableNumber = "T3";
            showTableNum_lbl.Text = tableNumber;

            order_DataGridView1.Enabled = true;
            drink_dataGridView.Enabled = true;
            mainCourses_dataGridView3.Enabled = true;
            deserts_dataGridView.Enabled = true;
            sides_dataGridView2.Enabled = true;
            bites_dataGridView4.Enabled = true;
            send_btn.Enabled = true;
            AddSpecialRequest_button1.Enabled = true;
            t1_btn.Enabled = false;
            t2_btn.Enabled = false;
            t3_btn.Enabled = true;
            t4_btn.Enabled = false;
            t5_btn.Enabled = false;
            t6_btn.Enabled = false;
            plus_btn.Enabled = true;
            minus_btn.Enabled = true;
            cancel_btn.Enabled = true;
            newTicket_btn.Enabled = true;
            changeTable_btn.Enabled = true;
        }

        private void t4_btn_Click(object sender, EventArgs e)
        {
            tableNumber = "T4";
            showTableNum_lbl.Text = tableNumber;


            order_DataGridView1.Enabled = true;
            drink_dataGridView.Enabled = true;
            mainCourses_dataGridView3.Enabled = true;
            deserts_dataGridView.Enabled = true;
            sides_dataGridView2.Enabled = true;
            bites_dataGridView4.Enabled = true;
            send_btn.Enabled = true;
            AddSpecialRequest_button1.Enabled = true;
            t1_btn.Enabled = false;
            t2_btn.Enabled = false;
            t3_btn.Enabled = false;
            t4_btn.Enabled = true;
            t5_btn.Enabled = false;
            t6_btn.Enabled = false;
            plus_btn.Enabled = true;
            minus_btn.Enabled = true;
            cancel_btn.Enabled = true;
            newTicket_btn.Enabled = true;
            changeTable_btn.Enabled = true;
        }

        private void t5_btn_Click(object sender, EventArgs e)
        {
            tableNumber = "T5";
            showTableNum_lbl.Text = tableNumber;


            order_DataGridView1.Enabled = true;
            drink_dataGridView.Enabled = true;
            mainCourses_dataGridView3.Enabled = true;
            deserts_dataGridView.Enabled = true;
            sides_dataGridView2.Enabled = true;
            bites_dataGridView4.Enabled = true;
            send_btn.Enabled = true;
            AddSpecialRequest_button1.Enabled = true;
            t1_btn.Enabled = false;
            t2_btn.Enabled = false;
            t3_btn.Enabled = false;
            t4_btn.Enabled = false;
            t5_btn.Enabled = true;
            t6_btn.Enabled = false;
            plus_btn.Enabled = true;
            minus_btn.Enabled = true;
            cancel_btn.Enabled = true;
            newTicket_btn.Enabled = true;
            changeTable_btn.Enabled = true;
        }

        private void t6_btn_Click(object sender, EventArgs e)
        {
            tableNumber = "T6";
            showTableNum_lbl.Text = tableNumber;


            order_DataGridView1.Enabled = true;
            drink_dataGridView.Enabled = true;
            mainCourses_dataGridView3.Enabled = true;
            deserts_dataGridView.Enabled = true;
            sides_dataGridView2.Enabled = true;
            bites_dataGridView4.Enabled = true;
            send_btn.Enabled = true;
            AddSpecialRequest_button1.Enabled = true;
            t1_btn.Enabled = false;
            t2_btn.Enabled = false;
            t3_btn.Enabled = false;
            t4_btn.Enabled = false;
            t5_btn.Enabled = false;
            t6_btn.Enabled = true;
            plus_btn.Enabled = true;
            minus_btn.Enabled = true;
            cancel_btn.Enabled = true;
            newTicket_btn.Enabled = true;
            changeTable_btn.Enabled = true;
        }

        //
        //new customer has arrived, this option cleans the grid and increments the ticket number
        //
        private void newCustomer_btn_Click(object sender, EventArgs e)
        {
            _thiscketNumCHR = "CHR" + _tichetNum;
            viewTicketNum_lbl.Text = _thiscketNumCHR;
            showTableNum_lbl.Text = "";
            order_DataGridView1.Rows.Clear();
            balance_txtb.Clear();
            _balance = 0;
            _tichetNum++;
            specialResq_textBox1.Clear();


            order_DataGridView1.Enabled = false;
            drink_dataGridView.Enabled = false;
            mainCourses_dataGridView3.Enabled = false;
            deserts_dataGridView.Enabled = false;
            sides_dataGridView2.Enabled = false;
            bites_dataGridView4.Enabled = false;
            send_btn.Enabled = false;
            AddSpecialRequest_button1.Enabled = false;
            t1_btn.Enabled = true;
            t2_btn.Enabled = true;
            t3_btn.Enabled = true;
            t4_btn.Enabled = true;
            t5_btn.Enabled = true;
            t6_btn.Enabled = true;
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            cancel_btn.Enabled = false;
            newTicket_btn.Enabled = false;
            changeTable_btn.Enabled = false;
        }

        //
        //open a virtual keyboard
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\HotelManagementSystem\ChelseaHotel_ManagementSystem\Vkeyboard\FreeVK.exe");
            specialResq_textBox1.Focus();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            //
            //  delete the selected row from the order data grid view
            //
            try
            {
                var rowIndex = order_DataGridView1.CurrentCell.RowIndex;


                var newBalance = Convert.ToDouble(order_DataGridView1.Rows[rowIndex].Cells["price_column"].Value);
                var itemQty = Convert.ToInt64(order_DataGridView1.Rows[rowIndex].Cells["qty_column"].Value);

                order_DataGridView1.Rows.RemoveAt(
                    order_DataGridView1.Rows[order_DataGridView1.CurrentCell.RowIndex].Index);
                _balance -= (newBalance*itemQty);
                if (_balance < 0)
                    _balance = 0;
                else
                    balance_txtb.Text = "€" + _balance.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"No Items To be Ordered");
            }
        }

        //
        //  send order to the kitchen 
        //      -the order will be first sent to the database. 
        //      -to the db, we ll send all items in the order
        //          * to the kitchen, we only send the item that need to be cooked
        //          * main course, side, lights bits, and the quantity for each item.
        //          * the table number will also be sent to the kitchen
        //
        private void send_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to send this order ?", "Send Order",
                MessageBoxButtons.YesNo);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    for (var i = 0; i < order_DataGridView1.RowCount; i++)
                    {
                        var itemNaToDB = Convert.ToString(order_DataGridView1.Rows[i].Cells["ItemName"].Value);
                        var itemToDBQTY = Convert.ToInt16(order_DataGridView1.Rows[i].Cells["qty_column"].Value);

                        orderToDB.Add(Convert.ToString(order_DataGridView1.Rows[i].Cells["ItemName"].Value),
                            Convert.ToInt16(order_DataGridView1.Rows[i].Cells["qty_column"].Value));

                        if ((Convert.ToString(order_DataGridView1.Rows[i].Cells["itemTypeOrder"].Value).Equals("drink")) ||
                            (Convert.ToString(order_DataGridView1.Rows[i].Cells["itemTypeOrder"].Value)
                                .Equals("dessert"))) continue;
                        orderList.Add(Convert.ToString(order_DataGridView1.Rows[i].Cells["ItemName"].Value),
                            Convert.ToInt16(order_DataGridView1.Rows[i].Cells["qty_column"].Value));
                    }

                    if (Model.SendOrder(_thiscketNumCHR, _balance))
                    {
                        MessageBox.Show("Order Saved");
                        SendOrderPdf();
                        orderToDB.Clear();
                        orderList.Clear();


                        viewTicketNum_lbl.Text = "";
                        showTableNum_lbl.Text = "";
                        _balance = 0;
                        order_DataGridView1.Rows.Clear();
                        balance_txtb.Clear();
                        specialResq_textBox1.Clear();
                    }
                    else
                        MessageBox.Show("Order was not saved");
                    orderToDB.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                orderList.Clear();
            }

//  freeze the items in the table
            try
            {
                #region disable options at start of the application

                order_DataGridView1.Enabled = false;
                drink_dataGridView.Enabled = false;
                mainCourses_dataGridView3.Enabled = false;
                deserts_dataGridView.Enabled = false;
                sides_dataGridView2.Enabled = false;
                bites_dataGridView4.Enabled = false;
                send_btn.Enabled = false;
                AddSpecialRequest_button1.Enabled = false;

                plus_btn.Enabled = false;
                minus_btn.Enabled = false;
                cancel_btn.Enabled = false;
                newTicket_btn.Enabled = false;
                changeTable_btn.Enabled = false;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Something Went Wrong\n Disabling the Buttons");
            }
        }

        private void newTicket_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Feature to be added on phase two.");
        }

        private void changeTable_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Feature to be added on phase two.");
        }
    }
}