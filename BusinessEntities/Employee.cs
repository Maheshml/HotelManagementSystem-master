using System;

namespace BusinessEntities
{
    public class Employee : Person, IEmployee
    {
        //private int employeeNum;

        public Employee(string title, string firstName, string middleName, string lastName, string phoneNumber, string email, Address personalAddress,
            int employeeNumber, DateTime dateOfBirth, string ppsn, double wage, int employeeCategory, int employeeCardNumber,DateTime hireDate,string photo)
            : base(title, firstName, middleName, lastName, phoneNumber, email, personalAddress)
           
        {
         
            this.employeeNumber = employeeNumber;
            this.dateOfBirth = dateOfBirth;
            this.ppsn = ppsn;
            this.wage = wage;
            this.employeeCategory = employeeCategory;
            this.employeeCardNumber = employeeCardNumber;
            this.hireDate = hireDate;
            this.photo = photo;
        }

        public int employeeNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string ppsn { get; set; }
        public double wage { get; set; }
        public int employeeCategory { get; set; }
        public int employeeCardNumber { get; set; }
        public DateTime hireDate { get; set; }
        public string photo { get; set; }
      
    }
}