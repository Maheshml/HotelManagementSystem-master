using BusinessLayer;
using DataAccessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace ChelseaHotel_ManagementSystem
{
    public partial class SetUpMenu : Form 
    {
        private readonly mainContainer fc;
        private static IDataLayer DataLayer;
        private readonly IModel Model;
        public SetUpMenu(mainContainer parent, IModel Model){
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            if (Screen.PrimaryScreen != null)
                panel3.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width)/2,
                    (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height)/2);
        }
        private void home_btn_Click(object sender, EventArgs e){
            Hide();
            var rkManagerHome = new DashboardKitchenManager(fc, Model);
            rkManagerHome.Show();
        }
        private void button4_Click(object sender, EventArgs e){
            var itemPrice = 0.0;

            try{//validating the values being inserted into the database
                TextBox[] validation ={
                                    itemName_txt,
                                    itemDescription_txtA,
                                    itemPrice_txt
                };
                foreach (var t in validation){
                    if (t.Text != string.Empty) continue;
                    MessageBox.Show(@"Please fill the text box");
                    t.Focus();
                    return;
                }
                if (itemTypeCheckedListBox.SelectedItem.ToString() == string.Empty){
                    MessageBox.Show(@"Please Select Item Type!");
                    itemTypeCheckedListBox.Focus();
                }
                else{
                    var itemName = itemName_txt.Text;
                    var itemDescroption = itemDescription_txtA.Text;
                    var itemType = itemTypeCheckedListBox.SelectedItem.ToString();

                    try{ //validating the values inserted in the price text box
                        itemPrice = double.Parse(itemPrice_txt.Text);
                    }
                    catch (Exception h){
                        MessageBox.Show(@"Price must contain numeric values, only!");
                    }
                    //if everything is correct, send the values to the database
                    var result = Model.SetupMenu(itemName, itemType, itemPrice, itemDescroption);
                    if (result)
                        MessageBox.Show(@"New Item added successfully");
                    else
                        MessageBox.Show(@"Something went wrong when adding the item");
                }
            }
            catch (Exception exp){
                MessageBox.Show(exp.Message);
            }
            //clear fields 
            itemName_txt.Clear();
            itemPrice_txt.Clear();
            itemDescription_txtA.Clear();
            itemTypeCheckedListBox.ClearSelected();
        }
        private void itemTypeCheckedListBox_SelectedIndexChanged(object sender, EventArgs e){
            var selectedIndex = itemTypeCheckedListBox.SelectedIndex;

            foreach (int cbNdx in itemTypeCheckedListBox.CheckedIndices)
                if (cbNdx != selectedIndex)
                    itemTypeCheckedListBox.SetItemChecked(cbNdx, false);
        }
        private void button1_Click(object sender, EventArgs e){
            Hide();
            var modifyDeleteItem = new editDeleteMenuItem(fc, Model){
                Dock = DockStyle.Fill
            };
            modifyDeleteItem.Show();
        }

    }
}