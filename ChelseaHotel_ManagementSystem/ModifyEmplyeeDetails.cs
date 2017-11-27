using BusinessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class ModifyEmplyeeDetails : Form
    {
        IModel _Model;
        private int _EMployeeID;
        Address address = new Address(); // ADDRESS  
        public ModifyEmplyeeDetails(IModel _Model)
        {
            InitializeComponent();
            this._Model = _Model;

            foreach (var employee in _Model.EmployeeList)
            {
                SelectEmployee_comboBox.Items.Add(employee.firstName + "" + employee.lastName);
            }

        }
        //
        //   update employee details Joao Filipe Romao
        //
        private void UpdateEmpluyee()
        {
            var title = title_comboBox1.Text; ;
            var firstName = FirstName_textBox1.Text;
            var middleName = middleName_textBox.Text;
            var lastName = lastName_textBox.Text;
            var DoB = Convert.ToDateTime(DoB_dateTimePicker.Text);
            var PPSN = PPSN_textBox.Text;
            var PhoneNumber = phoneNum_textBox.Text;
            var Email = Email_textBox.Text;
            var StreetLine1 = StreetLine1_textBox.Text;
            var StreetLine2 = StreetLine2_textBox.Text;
            var City = City_textBox.Text;
            var County = County_comboBox.Text;
            var Wage = wage_textBox.Text;
            var DateHired = Convert.ToDateTime(DateHired_dateTimePicker.Text);
            var EmployeePosition = positiontextBox.Text;
            var EmployeeCartNum = ECardNum_textBox.Text;

            foreach (var employee in _Model.EmployeeList)
            {
                if (employee.employeeNumber == _EMployeeID)
                {
                    employee.title = title;
                    employee.firstName = firstName;
                    employee.middleName = middleName;
                    employee.lastName = lastName;
                    employee.dateOfBirth = Convert.ToDateTime(DoB);
                    employee.ppsn = PPSN;
                    employee.phoneNumber = PhoneNumber;
                    employee.email = Email;
                    //address.addressLine1 = StreetLine1;
                    //------- do not know how to solve this yet------------------------------
                    //employee.personalAddress.addressLine2 = StreetLine2;
                    //employee.personalAddress.city = City;
                    //employee.personalAddress.county = County;
                    //------------------------------------------------------------------------
                    employee.wage = Convert.ToDouble(Wage);
                    employee.hireDate = Convert.ToDateTime(DateHired);
                    employee.employeeCardNumber = Convert.ToInt32(EmployeeCartNum);

                    switch (EmployeePosition)
                    {
                        case "General Manager":
                            employee.employeeCategory = 2;
                            break;
                        case "Receptionist":
                            employee.employeeCategory = 1;
                            break;
                        default:
                            employee.employeeCategory = 0;
                            break;
                    }


                    //var result = _Model.UpdateEmployeeDetails(employee);

                    //MessageBox.Show(result ? @"Employee Details Updated" : @"Something Went Wrong. Employee Details Not Updated");



                }
            }
        }

        private void selectEmployee_btn_Click(object sender, EventArgs e)
        {


            foreach (var employee in _Model.EmployeeList)
            {

                if (SelectEmployee_comboBox.Text.Equals(employee.firstName + "" + employee.lastName))
                {


                    _EMployeeID = Convert.ToInt32(employee.employeeNumber.ToString());

                    title_comboBox1.Text = employee.title;
                    FirstName_textBox1.Text = employee.firstName;
                    middleName_textBox.Text = employee.middleName;
                    lastName_textBox.Text = employee.lastName;
                    DoB_dateTimePicker.Text = employee.dateOfBirth.ToString();
                    PPSN_textBox.Text = employee.ppsn;
                    phoneNum_textBox.Text = employee.phoneNumber;
                    Email_textBox.Text = employee.email;
                    StreetLine1_textBox.Text = employee.personalAddress.addressLine1;
                    StreetLine2_textBox.Text = employee.personalAddress.addressLine2;
                    City_textBox.Text = employee.personalAddress.city;
                    County_comboBox.Text = employee.personalAddress.county;

                    wage_textBox.Text = employee.wage.ToString();
                    EmployeeNum_textBox.Text = employee.employeeNumber.ToString();
                    DateHired_dateTimePicker.Text = employee.hireDate.ToString();
                    ECardNum_textBox.Text = employee.employeeCardNumber.ToString();
                    var EmployeePosition = employee.employeeCategory;
                    switch (EmployeePosition)
                    {
                        case 1:
                            positiontextBox.Text = "General Manager";
                            break;
                        case 2:
                            positiontextBox.Text = "Receptionist";
                            break;
                        default:
                            positiontextBox.Text = "Position Not Available!";
                            break;
                    }
                }
            }
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UpdateEmpluyee();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
                      

            title_comboBox1.Text = " "; 
            FirstName_textBox1.Text = " ";
            middleName_textBox.Text = " ";
            lastName_textBox.Text = " ";
            DoB_dateTimePicker.Value = DateTime.Today.AddYears(-100); ;
            PPSN_textBox.Text = " ";
            phoneNum_textBox.Text = " ";
            Email_textBox.Text = " ";
            StreetLine1_textBox.Text = " ";
            StreetLine2_textBox.Text = " ";
            City_textBox.Text = " ";
            County_comboBox.Text = " ";
            wage_textBox.Text = " ";
            EmployeeNum_textBox.Text = " ";
            DateHired_dateTimePicker.Value = DateTime.Today.AddYears(-100);
            ECardNum_textBox.Text = " ";
            positiontextBox.Text = " ";
             
        }
    }
}
   
