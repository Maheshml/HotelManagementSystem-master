using System;

namespace BusinessEntities
{
    public interface IEmployee
    {
        
        //from base class Person
        string title { get; set; }
        string firstName { get; set; }
        string middleName { get; set; }
        string lastName { get; set; }
        string phoneNumber { get; set; }
        string email { get; set; }
        Address personalAddress { get; set; }

        
        //from class Employee
        int employeeNumber { get; set; }
        DateTime dateOfBirth { get; set; }
        string ppsn { get; set; }
        double wage { get; set; }
        int employeeCategory { get; set; }
        int employeeCardNumber { get; set; }
        DateTime hireDate { get; set; }
        string photo { get; set; }

    }
}