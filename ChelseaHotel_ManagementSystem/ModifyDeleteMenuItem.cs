using BusinessLayer;
using DataAccessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.IO;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace ChelseaHotel_ManagementSystem
{
    public partial class editDeleteMenuItem : Form
    {
     


        #region Function to populate the  itemTypecomboBox1 combo-box

        //
        //Function to populate the  itemTypecomboBox1 combo-box
        //
        private void PopulateItemTypecomboBox1()
        {
            foreach (var itemType in _model.MenuItemTypeList)
            {
                itemTypecomboBox1.Items.Add(itemType.ItemType);
            }
        }

        #endregion

        # region Function to Populate data grid view with the item coming from the database

        //
        //Populate data grid view with the item coming from the database
        //
        private void PopulateViewMenuItem_dataGridView()
        {
            viewMenuItem_dataGridView.Refresh();
            viewMenuItem_dataGridView.Rows.Clear();
            foreach (var menuItem in _model.MenuItemList)
            {
                if (itemTypecomboBox1.Text.Equals(menuItem.ItemType))
                {
                    viewMenuItem_dataGridView.Rows.Add(menuItem.MenuItemID, menuItem.ItemName, menuItem.ItemDescription,
                        menuItem.ItemPrice);
                }
            }
        }

        #endregion

        #region Create menu PDF

        //
        //  generate a pdf wwith the items in the - joao romao
        //
        public bool CreateMenuDoc()
        {
            var table = new PdfPTable(3);
            var glue = new Chunk(new VerticalPositionMark());
            var doc = new Document();

            var bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, false);
            var times = new Font(bfTimes, 22);

            var description = new Font(bfTimes, 14);




            var itemType = BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, false);
            var itemTypeTilte = new Font(itemType, 16);


            var itemP = BaseFont.CreateFont(BaseFont.HELVETICA_OBLIQUE, BaseFont.CP1252, false);
            var itemPrice = new Font(itemP, 12);

            try
            {
                doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 25, 3);
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
                string fileName = "Menu";
                int num = rdm.Next(1, 20);
                var wri = PdfWriter.GetInstance(doc,
                    new FileStream(
                        "C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\Restaurant Menu\\"+fileName+num+".pdf",
                        FileMode.Create));


                var lineBreak =
                    new Paragraph(
                        new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.WHITE,
                            Element.ALIGN_LEFT, 10)));


                doc.Open();


                //add logo to the PDF document
                var Logo =
                    iTextSharp.text.Image.GetInstance(
                        "C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\Reports\\DailyReport\\logo.jpg");
                Logo.ScalePercent(25f);
                Logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(Logo);
                //add title to the PDF document


                var pageTitle = new Paragraph("Chelsea Hotel Restaurant Menu", times)
                {
                    Alignment = Element.ALIGN_CENTER,
                    PaddingTop = 40
                };
                doc.Add(pageTitle);


                doc.Add(hr); //add a Horizontal line separating the the title and logo from the menu items

                doc.Add(lineBreak);
              


                //Starters & Light Bits section
                var itemTypeStartersLightBite = new Paragraph("Starters & Light Bits", itemTypeTilte)
                {
                    Alignment = Element.ALIGN_CENTER,
                    PaddingTop = 2
                };
                doc.Add(itemTypeStartersLightBite);
                doc.Add(shr); //
                foreach (var menuItem in _model.MenuItemList)
                {
                    if (!menuItem.ItemType.Equals("Starters & Light Bits")) continue;
                    var p = new Paragraph(menuItem.ItemName)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        PaddingTop = 2
                    };
                 
                    p.Add(menuItem.ItemDescription);
                    p.Add(glue);
                    p.Add("€" + menuItem.ItemPrice.ToString("0.00"));
                    doc.Add(p);
                }

                //space between menu item types
                doc.Add(lineBreak);
                doc.Add(lineBreak);


                var itemTypeStartersMainCourse = new Paragraph("Main Course", itemTypeTilte)
                {
                    Alignment = Element.ALIGN_CENTER,
                    PaddingTop = 2
                };

                doc.Add(itemTypeStartersMainCourse);
                doc.Add(shr); //

                foreach (var menuItem in _model.MenuItemList)
                {
                    if (!menuItem.ItemType.Equals("Main courses")) continue;
                    var p = new Paragraph(menuItem.ItemName, itemPrice)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        PaddingTop = 2
                    };
                    p.Add(glue);
                    p.Add(menuItem.ItemDescription);
                    p.Add(glue);
                    p.Add("€" + menuItem.ItemPrice.ToString("0.00"));
                    doc.Add(p);
                }
                //space between menu item types
                doc.Add(lineBreak);
                doc.Add(lineBreak);


                var itemTypeSides = new Paragraph("Sides", itemTypeTilte)
                {
                    Alignment = Element.ALIGN_CENTER,
                    PaddingTop = 2
                };

                doc.Add(itemTypeSides);
                doc.Add(shr); //

                foreach (var menuItem in _model.MenuItemList)
                {
                    if (!menuItem.ItemType.Equals("Sides")) continue;
                    var p = new Paragraph(menuItem.ItemName, itemPrice)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        PaddingTop = 2
                    };
                    p.Add(glue);
                    p.Add(menuItem.ItemDescription);
                    p.Add(glue);
                    p.Add("€" + menuItem.ItemPrice.ToString("0.00"));
                    doc.Add(p);
                }

                //space between menu item types
                doc.Add(lineBreak);
                doc.Add(lineBreak);


                var itemTypeDesserts = new Paragraph("Desserts", itemTypeTilte)
                {
                    Alignment = Element.ALIGN_CENTER,
                    PaddingTop = 2
                };

                doc.Add(itemTypeDesserts);
                doc.Add(shr); //
                foreach (var menuItem in _model.MenuItemList)
                {
                    if (!menuItem.ItemType.Equals("Desserts")) continue;
                    var p = new Paragraph(menuItem.ItemName, itemPrice)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        PaddingTop = 2
                    };
                    p.Add(glue);
                    p.Add(menuItem.ItemDescription);
                    p.Add(glue);
                    p.Add("€" + menuItem.ItemPrice.ToString("0.00"));
                    doc.Add(p);
                }
                
                doc.Add(lineBreak);
                doc.Add(lineBreak);
                return true;
            }
            catch
                (iTextSharp.text.BadElementException ex)
            {
                MessageBox.Show("ERROR: Something went wrong when generating the Menu Documment\n"+ex.Message);
                return false;
            }

            finally
            {
                doc.Close();
                doc = null;
            }
        }

        #endregion










        private static IDataLayer DataLayer;
        private IModel _model = BusinessLayer.Model.GetInstance(DataLayer);
        private mainContainer fc;

        private int id;

        public editDeleteMenuItem(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this._model = Model;
            PopulateItemTypecomboBox1(); //call the method to populate the combo-box
            Refresh.Visible = false;
        }

        private void viewItem_btn_Click(object sender, System.EventArgs e)
        {
            PopulateViewMenuItem_dataGridView();
        }


        private void viewMenuItem_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Name = viewMenuItem_dataGridView.Rows[e.RowIndex].Cells["itemName"].Value.ToString();
            var Description = viewMenuItem_dataGridView.Rows[e.RowIndex].Cells["itemDescription"].Value.ToString();
            var Price = Convert.ToDouble(viewMenuItem_dataGridView.Rows[e.RowIndex].Cells["itemPrice"].Value.ToString());
            var itemID = Convert.ToInt16(viewMenuItem_dataGridView.Rows[e.RowIndex].Cells["ItemID"].Value.ToString());
            var itemType = itemTypecomboBox1.Text;


            foreach (var menuItem in _model.MenuItemList)
            {
                if (menuItem.MenuItemID != itemID) continue;
                menuItem.ItemName = Name;
                menuItem.ItemDescription = Description;
                menuItem.ItemPrice = Price;
                menuItem.ItemType = itemType;

                var restul = _model.UpdateMenuItem(menuItem);

                if (restul)
                {
                    MessageBox.Show(@"Item Updated");
                    viewMenuItem_dataGridView.Rows[e.RowIndex].Cells["itemName"].ReadOnly = true;
                    viewMenuItem_dataGridView.Rows[e.RowIndex].Cells["itemDescription"].ReadOnly = true;
                    viewMenuItem_dataGridView.Rows[e.RowIndex].Cells["itemPrice"].ReadOnly = true;
                    Refresh.Visible = true;
                }
                else
                    MessageBox.Show(@"Item Could Not be updated!");
            }

            //var restul = _model.UpdateMenuItem(itemID, itemType, Name, Price, Description);
           
        }

        private void setupMenuPDF_btn_Click(object sender, System.EventArgs e)
        {
            var result = CreateMenuDoc();

            MessageBox.Show(result ? @"Menu Ducument Created" : @"Something Went Wrong. Menu Documment not Created!");
        }


        private void viewMenuItem_dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            id = Convert.ToInt32(viewMenuItem_dataGridView.Rows[e.RowIndex].Cells["ItemID"].Value.ToString());
            this.contextMenuStrip1.Show(this.viewMenuItem_dataGridView, e.Location);
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = false;

            

            foreach (var menuItem in _model.MenuItemList)
            {
                if (menuItem.MenuItemID == id)
                {

                    result = _model.DeleteMenuItem(menuItem);


                }
            }

            MessageBox.Show(result ? @"Menu Item Deleted" : @"Something Went Wrong. Menu Item Not Deleted!");
            Refresh.Visible =  true;
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            var RKmanager = new DashboardKitchenManager(fc, _model);
            this.Hide();
            RKmanager.Show();
        }

        private void setupMenu_btn_Click(object sender, EventArgs e)
        {
            var addItem = new setUpMenu();
            this.Hide();
            addItem.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            viewMenuItem_dataGridView.Rows.Clear();
            viewMenuItem_dataGridView.Refresh();
            PopulateViewMenuItem_dataGridView();

        }
    }
}