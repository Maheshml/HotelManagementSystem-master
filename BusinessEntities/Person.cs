using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Address
{
    public string addressLine1;
    public string addressLine2;
    public string postCode;
    public string city;
    public string county;

    public void getValues(string addressLine1, string addressLine2, string postCode,string city, string county)
    {
        this.addressLine1 = addressLine1;
        this.addressLine2 = addressLine2;
        this.postCode = postCode;
        this.city = city;
        this.county = county;
    }
}

namespace BusinessEntities
{
    public class Person
    {
        public string title { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set;}
        public string email { get; set; }
        public Address personalAddress { get; set; }
   

        public Person(string title, string firstName, string middleName, string lastName,
             string phoneNumber, string email, Address personalAddress)
        {
            this.title = title;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName; 
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.personalAddress = personalAddress;
        }
    }
}
