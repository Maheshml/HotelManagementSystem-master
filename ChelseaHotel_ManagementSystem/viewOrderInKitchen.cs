using BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class ViewOrderInKitchen : Form
    {

        public Queue<string> nexOorderQ = new Queue<string>();
      //  public Queue<string> prevOrder = new Queue<string>();
        public Stack<string> prevOrderS = new Stack<string>();

        IModel Model;

        public ViewOrderInKitchen()
        {
            InitializeComponent();

            string path = @"C:\\HotelManagementSystem\\ChelseaHotel_ManagementSystem\\ChelseaHotel_ManagementSystem\\Resources\\Kitchen Order\\";


            DirectoryInfo dir = new DirectoryInfo(path);
            //
            //  get the all the files in the order directory and sort them in Descending order  
            //
            FileInfo[] files = dir.GetFiles().OrderByDescending(p => p.CreationTime).ToArray();
            //
            //  the files are stored in the files array in Descending order, Reverse the files array 
            //   and stored them in a Queue so the last files in is the first getting out of the queue
            // 
            foreach (var f in files.Reverse()) {
                nexOorderQ.Enqueue(f.FullName);
            }
          
        }

        private void NextOrder_Brn_Click(object sender, EventArgs e)
        {
           try
            {
               

                var Order = nexOorderQ.Dequeue();
                menuReader.LoadFile(Order);
                prevOrderS.Push(Order);

                //{

                //    OpenFileDialog pdf = new OpenFileDialog();

                //    if(pdf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //    {
                //        menuReader.src = pdf.FileName; 
                //    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"NEXT BUTTON ERROR");
            }

        }

        private void preveOrder_btn_Click(object sender, EventArgs e)
        {

            try
            {
                var fileName = prevOrderS.Pop();
                menuReader.LoadFile(fileName);
                prevOrderS.Push(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"PREV BUTTON ERROR: ");


            }
        }
    }
}