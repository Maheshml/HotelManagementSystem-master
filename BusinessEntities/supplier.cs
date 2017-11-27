using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Supplier : BusinessEntities.ISupplier
    {
        private int supplierID;
        private string Name;
        private string PhoneNum;
        private string Email;
        private string Street;
        private string City;
        private string County;
        private string AdditionalInfo;

        public Supplier(int supplierID, string name, string phoneNum, string email, string street, string city, string county, string additionalInfo)
        {
            this.supplierID = supplierID;
            this.Name = name;
            this.PhoneNum = phoneNum;
            this.Email = email;
            this.Street = street;
            this.City = city;
            this.County = county;
            this.AdditionalInfo = additionalInfo;
        }

        public int SupplierID
        {
            get
            {
                return supplierID;
            }

            set
            {
                this.SupplierID = value;
            }
        }

        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                this.Name = value;
            }
        }

        public string phoneNum
        {
            get
            {
                return PhoneNum;
            }

            set
            {
                this.PhoneNum = value;
            }
        
        }

        public string email
        {
            get
            {
                return Email;
            }

            set
            {
                this.Email = value;
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
                this.Street = value;
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

        public string county
        {
            get
            {
                return County;
            }

            set
            {
                this.County = value;
            }
        }

        public string additionalInfo
        {
            get
            {
                return AdditionalInfo;
            }

            set
            {
                this.AdditionalInfo = value;
            }
        }
    }
}
