using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Guest : BusinessEntities.IGuest
    {
        private int GuestID;
        private string FirstName;
        private string MiddleName;
        private string Surname;
        private string PhoneNumber;
        private string Street;
        private string City;
        private string Country;





        public Guest(int guestID, string firstName, string middleName, string surname, string phoneNumber, string street, string city, string country)
        {
            this.GuestID = guestID;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
            this.Street = street;
            this.City = city;
            this.Country = country;
    }


        public int guestID
        {
            get
            {
                return GuestID;
            }

            set
            {
                this.GuestID = value;
            }
        }

        public string firstName
        {
            get
            {
                return FirstName;
            }

            set
            {
                this.FirstName= firstName;
            }
        }

        public string middleName
        {
            get
            {
                return MiddleName;
            }

            set
            {
                this.MiddleName = value;
            }
        }


        public string surname
        {
            get
            {
                return Surname;
            }

            set
            {
                this.Surname = value;
            }
        }

        public string phoneNumber
        {
            get
            {
                return PhoneNumber;
            }

            set
            {
                this.PhoneNumber = value;
            }
        }
        public string street
        {
            get
            {
                return Street;
            }

            set
            {
                this.Street= value;
            }
        }

        public string city
        {
            get
            {
                return City;
            }

            set
            {
                this.City = value;
            }
        }

        public string country
        {
            get
            {
                return Country;
            }

            set
            {
                this.Country = value;
            }
        }



    }

}



