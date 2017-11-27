using BusinessEntities;
using BusinessLayer;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class updateInventory: Form
    {
        #region Instance Attributes
        private IModel Model;
        int thequantity;
        int theitemID;
        bool delete;
        int theindex;

        #endregion

        #region Instance Properties

        #endregion


        #region Constructors
        public updateInventory(IModel Model)
        {


            InitializeComponent();
            this.Model = Model;
            
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateInventory_Load(object sender, EventArgs e)
        {
            Model.PopulateSupplierList();
            Model.PopulateItemList();

            supplier_combo.Items.Add("All");

            foreach(Supplier aSupplier in Model.SupplierList)
            {
                supplier_combo.Items.Add(aSupplier.name);
            }

            category_combo.Items.Add("All");
            category_combo.Items.Add("Produce");
            category_combo.Items.Add("Dairy");
            category_combo.Items.Add("Grains");
            category_combo.Items.Add("Sauces");
            category_combo.Items.Add("Meat & Poultry");
            category_combo.Items.Add("Seafood");
            category_combo.Items.Add("Frozen");

            supplier_combo.SelectedItem = "All";
            category_combo.SelectedItem = "All";

            //foreach(Item aItem in Model.ItemList)
            //{
            //    dataGridView1.Rows.Add(aItem.ItemID, aItem.name, aItem.unitPrice, aItem.category, aItem.quantity);
            //}

            string category = category_combo.SelectedItem.ToString();
            MessageBox.Show(category);

        }

        private void supplier_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category;
            string supplier;
            dataGridView1.Rows.Clear();

            try
            {
                category = category_combo.SelectedItem.ToString();
                supplier = supplier_combo.SelectedItem.ToString();
            }

            catch
            {
                category_combo.SelectedItem = "All";
                supplier_combo.SelectedItem = "All";
            }

            if (supplier_combo.SelectedItem.ToString() == "All" && category_combo.SelectedItem.ToString() == "All")
            {
                foreach (Item aItem in Model.ItemList)
                {
                    dataGridView1.Rows.Add(aItem.ItemID, aItem.name, aItem.unitPrice, aItem.category, aItem.quantity);
                }

            }

            else if (supplier_combo.SelectedItem.ToString() == "All" && category_combo.SelectedItem.ToString() != "All")
            {
                foreach (Item aItem in Model.ItemList)
                {
                    if (aItem.category == category_combo.SelectedItem.ToString())
                    {
                        dataGridView1.Rows.Add(aItem.ItemID, aItem.name, aItem.unitPrice, aItem.category, aItem.quantity);
                    }
                }
            }

            else if (supplier_combo.SelectedItem.ToString() != "All" && category_combo.SelectedItem.ToString() == "All")
            {
                supplier = supplier_combo.SelectedItem.ToString();
                int supplierID;

                foreach (Supplier aSupplier in Model.SupplierList)
                {
                    if (aSupplier.name == supplier)
                    {
                        supplierID = aSupplier.SupplierID;

                        foreach (Item aItem in Model.ItemList)
                        {
                            if (aItem.supplierID == supplierID)
                            {
                                dataGridView1.Rows.Add(aItem.ItemID, aItem.name, aItem.unitPrice, aItem.category, aItem.quantity);
                            }
                        }
                    }
                }
            }

            else
            {

                foreach (Supplier aSupplier in Model.SupplierList)
                {
                    if (aSupplier.name == supplier_combo.SelectedItem.ToString())
                    {
                        int supplierID = aSupplier.SupplierID;

                        foreach (Item aItem in Model.ItemList)
                        {
                            if (aItem.category == category_combo.SelectedItem.ToString() && aItem.supplierID == supplierID)
                            {
                                dataGridView1.Rows.Add(aItem.ItemID, aItem.name, aItem.unitPrice, aItem.category, aItem.quantity);

                            }

                        }

                    }
                }
            }
        }

        private void category_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string category = category_combo.SelectedItem.ToString();
            string supplier = supplier_combo.SelectedItem.ToString();

            if (supplier_combo.SelectedItem.ToString() == "All" && category == "All")
            {
                foreach (Item aItem in Model.ItemList)
                {
                    dataGridView1.Rows.Add(aItem.ItemID, aItem.name, aItem.unitPrice, aItem.category, aItem.quantity);
                }

            }

            else if (supplier_combo.SelectedItem.ToString() == "All" && category != "All")
            {
                foreach (Item aItem in Model.ItemList)
                {
                    if (aItem.category == category)
                    {
                        dataGridView1.Rows.Add(aItem.ItemID, aItem.name, aItem.unitPrice, aItem.category, aItem.quantity);
                    }
                }
            }

            else if (supplier_combo.SelectedItem.ToString() != "All" && category == "All")
            {
                supplier = supplier_combo.SelectedItem.ToString();
                int supplierID;

                foreach (Supplier aSupplier in Model.SupplierList)
                {
                    if (aSupplier.name == supplier)
                    {
                        supplierID = aSupplier.SupplierID;

                        foreach (Item aItem in Model.ItemList)
                        {
                            if (aItem.supplierID == supplierID)
                            {
                                dataGridView1.Rows.Add(aItem.ItemID, aItem.name, aItem.unitPrice, aItem.category, aItem.quantity);
                            }
                        }
                    }
                }
            }

            else
            {

                foreach (Supplier aSupplier in Model.SupplierList)
                {
                    if (aSupplier.name == supplier)
                    {
                        int supplierID = aSupplier.SupplierID;

                        foreach (Item aItem in Model.ItemList)
                        {
                            if (aItem.category == category && aItem.supplierID == supplierID)
                            {
                                dataGridView1.Rows.Add(aItem.ItemID, aItem.name, aItem.unitPrice, aItem.category, aItem.quantity);

                            }

                        }

                    }
                }
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1[4, index].Value = Convert.ToInt32(numericUpDown1.Value);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thequantity=Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            theitemID= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            numericUpDown1.Value = thequantity;

            
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            
            foreach(Item aItem in Model.ItemList)
            {
                if(aItem.ItemID==theitemID)
                {
                    delete=Model.DeleteItem(aItem);
                    break;
                }
            }

            if (delete)
            {
                theindex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(theindex);
                MessageBox.Show("Item deleted from inventory");
                
            }

            else
            {
                MessageBox.Show("Item not deleted");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                foreach(Item aItem in Model.ItemList)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (aItem.ItemID == Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))
                        {
                            aItem.quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                            Model.UpdateItemQuantity(aItem);
                        }
                    }
                }
            
        }
    }




        }
    

