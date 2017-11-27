using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class PrintStokOrder : Form
    {

        public Stack<string> stockOrderStack = new Stack<string>();
        public PrintStokOrder()
        {
            InitializeComponent();



            string path = @"C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\ChelseaHotel_ManagementSystem\\Resources\\StockOrder\\";


            DirectoryInfo dir = new DirectoryInfo(path);

            FileInfo[] files = dir.GetFiles().OrderByDescending(p => p.CreationTime).ToArray();


            try
            {

                foreach (var f in files)
                {
                    stockOrderStack.Push(f.ToString());
                }


                string fromStack = stockOrderStack.Pop();


               printDocBox.LoadFile(@"C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\StockOrder\\" + fromStack);


                stockOrderStack.Clear();


            }
                catch(Exception ex)
            {
                MessageBox.Show("No Files in the Given Directory!");
            }
        }

        private void PrintStokOrder_Load(object sender, EventArgs e)
        {

        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }
}
