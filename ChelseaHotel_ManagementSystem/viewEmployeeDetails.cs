using BusinessLayer;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class viewEmployeeDetails : Form
    {

        mainContainer fc;

        private static IDataLayer DataLayer;
        private IModel Model = BusinessLayer.Model.GetInstance(DataLayer);

        public viewEmployeeDetails(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;


        }

        public viewEmployeeDetails()
        {
            InitializeComponent();


        }


        private void displayEmployeeDetails_Load(object sender, EventArgs e)
        {
            foreach (var employee in Model.EmployeeList)
            {
                //display employee details in a datagrid view
               // viewEmployeesDataGridView.Rows.Add(employee.employeeNumber.ToString(), employee.,employee.MiddleName, employee.Surname, employee.PhoneNum,employee.Email, employee.Street, employee.City,employee.County, employee.Wage.ToString());
            }
        }

        private void viewEmployeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
