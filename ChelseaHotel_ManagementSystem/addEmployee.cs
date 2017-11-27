using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class addEmployee : Form
    {
        #region Instance Attributes
        IModel Model;
        mainContainer mc;
        #endregion

        #region Constructors
        public addEmployee(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);


        }

        #endregion


        private void SubmmitButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            /* Personal Details */
            
   
                String title = comboBox1.SelectedItem.ToString();
                String firstName = textBox1.Text;
                String middleName = textBox2.Text;
                String lastName = textBox3.Text;
                DateTime dateOfBirth = Convert.ToDateTime(dateTimePicker1.Text);
                String ppsn = textBox4.Text;

                int  employeeNumber = Convert.ToInt32(textBox5.Text);
                int employeeCardNumber = Convert.ToInt32(textBox6.Text);
                int position = Convert.ToInt32(textBox7.Text);
                DateTime hireDate = Convert.ToDateTime(dateTimePicker2.Text);
                Double wage = Convert.ToDouble(textBox8.Text);


                Address employeeAddress = new Address();
                employeeAddress.addressLine1 = textBox10.Text;
                employeeAddress.addressLine2 = textBox11.Text;
                employeeAddress.city = textBox12.Text;
                employeeAddress.county = comboBox2.SelectedText;

                String phoneNumber = textBox13.Text;
                String email = textBox14.Text;

                String photo = textBox15.Text;

                //MessageBox.Show(title + "\n" + firstName + "\n" + middleName + "\n" + dateOfBirth.ToLongDateString());
            //} 
            //catch (NullReferenceException error)
            //{
            //    MessageBox.Show("One of the fields is empty " + error);
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("Error occured " + error);
            //}

            //IEmployee newEmployee = new IEmployee(title,  firstName, middleName,  lastName,  phoneNumber, email,  employeeAddress,
            // employeeNumber,  dateOfBirth, ppsn, wage, position, employeeCardNumber, hireDate, photo);
            //Model.AddNewEmployeeToDb(title, firstName, middleName, lastName, phoneNumber, email, employeeAddress,
            //employeeNumber, dateOfBirth, ppsn, wage, position, employeeCardNumber, hireDate, photo);

        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Select File
        private void SelectFile_Click(object sender, EventArgs e)
        {
            //string sourcePath = @"C:\Users\Public\TestFolder";
            //string targetPath = @"C:\Users\Public\TestFolder\SubDir";

            //Open Image File DialogBOX
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            //Get the path of the file and filename of image
            string sourceFile = openFileDialog1.FileName;

            //Get only filename of image
            string file = sourceFile.Split('\\').Last();

            //Display name of the file in textbox
            textBox15.Text = file;

            //Display picture in picture box
            Image img = Image.FromFile(sourceFile);
            pictureBox2.Image = img;
            pictureBox2.Height = 110;
            pictureBox2.Width = 110;

            //Copy file from user folder to application folder
            string targetPath = @"Resources\employee_images";
            //string relativePath = Environment.CurrentDirectory;
            //string two_levels_up = Path.Combine(relativePath, @"..\..\");
            string destFile = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\employee_images\", file);
            MessageBox.Show("Source File " + sourceFile);
            MessageBox.Show("Destination File " + destFile);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);



            if (result == DialogResult.OK) // Test result.
            {
                try
                {
                    string text = File.ReadAllText(sourceFile);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
                
            }
            MessageBox.Show(size.ToString()); // <-- Shows file size in debugging mode.
           // Console.WriteLine(result); // <-- For debugging use.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewEmployeeList form = new viewEmployeeList(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
