using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class ManageSuppliers : Form
    {
        public ManageSuppliers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void mainMenu_btn_Click(object sender, EventArgs e)
        {
            ManageSuppliers mainMenu = new ManageSuppliers();

            mainMenu.ShowDialog();
        }

        private void editSupplier_btn_Click(object sender, EventArgs e)
        {
            editSupplier editSupplier = new editSupplier();

            editSupplier.ShowDialog();
        }

        private void viewSuppliers_Click(object sender, EventArgs e)
        {
           
        }
    }
}
