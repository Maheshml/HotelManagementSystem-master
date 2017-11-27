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

namespace ChelseaHotel_ManagementSystem
{
    public partial class TakeOrder : Form
    {
        IModel model;
        mainContainer mc;
        int totalQuantity;
        double totalPrice;
        string currentItem;
        string orderItems;
        public TakeOrder(mainContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.model = model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);

        }

        private void TakeOrder_Load(object sender, EventArgs e)
        {
            model.PopulateOrdersList();
            model.PopulateSnacksList();
            model.PopulateDrinksList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Generate_Click(object sender, EventArgs e)
        {

            if (comboBox_Generate.SelectedItem.ToString() == "Drinks")
            {
                currentItem = "Drink";
                dataGridView_Items.DataSource = null;
                dataGridView_Items.Rows.Clear();
                foreach (Drink drink in model.DrinksList)
                {
                    string[] row1 = new string[] { drink.drinkID.ToString(), drink.drinkName.ToString(), drink.drinkPrice.ToString(), drink.drinkQuantity.ToString() };
                    dataGridView_Items.Rows.Add(row1);
                }
            }
            else if (comboBox_Generate.SelectedItem.ToString() == "Snacks")
            {
                currentItem = "Snack";
                dataGridView_Items.DataSource = null;
                dataGridView_Items.Rows.Clear();
                foreach (Snacks snack in model.SnacksList)
                {

                    string[] row1 = new string[] { snack.snackId.ToString(), snack.name, snack.price.ToString(), snack.quantity.ToString() };
                    dataGridView_Items.Rows.Add(row1);
                }

            }

            else
                MessageBox.Show("You must select a value");
        }

        private void dataGridView_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_AddToOrder_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView_Items.CurrentCell.RowIndex;
            int columnindex = dataGridView_Items.CurrentCell.ColumnIndex;

            int itemId = Convert.ToInt32(dataGridView_Items.Rows[rowindex].Cells[columnindex].Value.ToString());

            //int roomId = Convert.ToInt32(dataGridView_Housekeeping.Rows[0].Cells[0].FormattedValue.ToString());
            if (currentItem == "Drink")
            {
                foreach (Drink drink in model.DrinksList)
                {

                    if (drink.drinkID == itemId)
                    {
                        string[] row1 = new string[] { drink.drinkName, drink.drinkPrice.ToString() };
                        dataGridView_Order.Rows.Add(row1);
                        orderItems +=drink.drinkName;
                        totalQuantity += 1;
                        totalPrice += drink.drinkPrice;
                        textBox_Total.Text = totalPrice.ToString();
                        model.RemoveDrinkQuantity(itemId);
                    }

                }
            }
            else if (currentItem == "Snack")
            {
                foreach (Snacks snack in model.SnacksList)
                {

                    if (snack.snackId == itemId)
                    {
                        string[] row1 = new string[] { snack.name, snack.price.ToString() };
                        dataGridView_Order.Rows.Add(row1);
                        orderItems += snack.name;
                        totalQuantity += 1;
                        totalPrice += snack.price;
                        textBox_Total.Text = totalPrice.ToString();
                         model.RemoveSnackQuantity(itemId);

                        break;
                    }

                }
            }
            else
                MessageBox.Show("Nothing is selected");
        }

        private void button_SubmitOrder_Click(object sender, EventArgs e)
        {
            int OrderId;
            int count = 0;
            foreach(barOrder order in model.barOrderList)
            {
                count++;
            }
            if (count == 0)
            {
                OrderId = 1;
            }
            else
                OrderId = count + 1;
            DateTime orderTime;
            orderTime = DateTime.Now;
            double change = Convert.ToDouble(textBox_Payment.Text) -totalPrice;
            if(model.InsertBarOrder(OrderId, orderTime, orderItems, totalPrice, totalQuantity, change))
            {
                MessageBox.Show("Bar Order Succesfully");
            }
            OrderId = 0;
            totalPrice = 0;
            totalQuantity = 0;
            orderItems = "";

        }

        private void button_RemoveRow_Click(object sender, EventArgs e)
        {
            string name = "";
            name = dataGridView_Order.CurrentCell.Value.ToString();
            dataGridView_Order.Rows.RemoveAt(dataGridView_Order.SelectedRows[0].Index);
            foreach (Snacks snack in model.SnacksList)
            {

                if (snack.name == name)
                {
                    model.AddSnackQuantity(name);
                }
            }
            foreach (Drink drink in model.DrinksList)
            {

                if (drink.drinkName == name)
                {
                    model.AddDrinkQuantity(name);
                }
            }
        }

    }
}

