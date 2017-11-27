using System;

namespace BusinessEntities
{
    public  static class EmployeeFactory
    {
        private static IEmployee _employee = null;
   

        public static IEmployee GetEmployee(string title, string firstName, string middleName, string lastName, string phoneNumber, string email, Address personalAddress,
            int employeeNumber, DateTime dateOfBirth, string ppsn, double wage, int employeeCategory, int employeeCardNumber, DateTime hireDate, string photo)
        {
            if (_employee != null)
                return _employee;

            else
                return new Employee(title, firstName, middleName, lastName, phoneNumber, email, personalAddress,
            employeeNumber, dateOfBirth, ppsn, wage, employeeCategory, employeeCardNumber, hireDate, photo);
        }

        public static void SetEmployee(IEmployee aEmployee)
        {
            _employee = aEmployee;
        }
    }
}