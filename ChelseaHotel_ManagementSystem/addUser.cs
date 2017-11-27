using BusinessEntities;
using BusinessLayer;
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
    public partial class addUser : Form
    {

        #region Instance Attributes
        IModel Model;
        mainContainer mc;
        #endregion

        public addUser(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }


        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
           //get username and password        
            string username = username_textbox.Text;
            string password = password_textbox.Text;

            //get currently selected employee
            int row = employeeList_grid.CurrentCell.RowIndex;
            int employeeNumber = Convert.ToInt16(employeeList_grid.Rows[row].Cells[0].Value.ToString().Trim());



            int userRole = 0;
            switch (userRole_combo.SelectedText)
            {
                case "System Administrator":
                    userRole = 1;
                    break;
                case "General Manager":
                    userRole = 2;
                    break;
                case "Receptionist":
                    userRole = 3;
                    break;
                case "Kitchen Manager":
                    userRole = 4;
                    break;
                case "Kitchen Staff":
                    userRole = 5;
                    break;
                case "Bar Manager":
                    userRole = 6;
                    break;
                case "Bar Staff":
                    userRole = 7;
                    break;
                case "Restaurant Staff":
                    userRole = 8;
                    break;
                default:
                    userRole = 0;
                    break;
            }

            //By default select user state false;
            Boolean userState = false;

            //Should user be settet as active or inactive?
            if (userEnabled_checkBox.CheckState.ToString().Equals("Checked"))
                userState = true;
            else if (userEnabled_checkBox.CheckState.ToString().Equals("Unchecked"))
                userState = false;

            //password validation
            //TO-DO 

            // string name, string password, int employeeNumber, int userType, Boolean status
            if (Model.AddNewUser(username, password, employeeNumber, userRole, userState))
            {
                MessageBox.Show("User created");
                username_textbox.Text = "";
                password_textbox.Text = "";
                confirmPassword_textbox.Text = "";
                userRole_combo.SelectedIndex = -1;
            }
            else { 
            MessageBox.Show("User not created");
            }

            //if (listBoxUserType.SelectedIndex != -1)
            //{ // some validation on userName, we won't allow duplicate usernames
            //    IUser duplicateUser = Model.UserList.FirstOrDefault(user => user.Name == textBoxName.Text.Trim());
            //    /* provides a shortcut to accessing the element that occurs first in the collection or query,
            //    while protecting against invalid accesses if there are no elements.It'sa linq query. FirstOrDefault is a generic method which means it accepts a type parameter that indicates what types it acts upon. 
            //    The => is a lambda operator. Anything before the => are the input parameters, and anything after is the expression. You can have multiple input parameters.
            //    Think of a lambda expression as"given x, do something with x"                                                                                          * */
            //    if (duplicateUser == null)
            //    {
            //        if (Model.addNewUser(textBoxName.Text, textBoxPassword.Text, listBoxUserType.SelectedItem.ToString()))
            //        {
            //            MessageBox.Show("User created");
            //            textBoxName.Text = "";
            //            textBoxPassword.Text = "";
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Duplicate User name, enter a different name!");
            //        MessageBox.Show(duplicateUser.Name + " " + duplicateUser.Password);  // just to show directOrDefault returns the matching user where there is one. 
            //        textBoxName.Text = "";
            //        textBoxPassword.Text = "";
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("You must select a user type!");
            //    textBoxName.Text = "";
            //    textBoxPassword.Text = "";

            //}




        }

        private void addUser_Load(object sender, EventArgs e)
        {
            foreach (Employee emp in Model.EmployeeList)
            {
                string[] row1 = new string[] { emp.employeeNumber.ToString(),emp.lastName , emp.firstName,emp.middleName,emp.employeeCategory.ToString()};
                employeeList_grid.Rows.Add(row1);
            }      
        }



        private void employeeList_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // create username
            int row = employeeList_grid.CurrentCell.RowIndex;
            string firstName = employeeList_grid.Rows[row].Cells[3].Value.ToString().Trim();
            string lastName = employeeList_grid.Rows[row].Cells[1].Value.ToString().Trim();
            username_textbox.Text = firstName + '.' + lastName;

            //populatele list of user types
        }



        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (confirmPassword_textbox.Text.Equals(password_textbox.Text))
            {
                pass_msg_label.Text = "Passwords match.";
                pass_msg_label.ForeColor = Color.FromArgb(237, 209, 144);
            }
            else
            {
                pass_msg_label.Text = "Passwords don't match.";
                pass_msg_label.ForeColor = Color.FromArgb(255, 105, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            editUser form1 = new editUser(mc, Model);
            form1.Dock = DockStyle.Fill;
            form1.Show();
            this.Hide();
        }

        private void addUser_SizeChanged(object sender, EventArgs e)
        {
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
