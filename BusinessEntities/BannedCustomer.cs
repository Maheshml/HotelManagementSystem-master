using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BannedCustomer : IBannedCustomer
    {
        #region Instance Properties
        private int banId;
        private string firstName;
        private string lastName;
        private string email;
        private string photo;
        private string reasonForBan;


        #endregion

        #region Instance Properties
        public string FirstName
        {
            get
            {
                return firstName; 
            }
            set
            {
                firstName = value;
            }
        }

        public int BanId
        {
            get
            {
                return banId;
            }
            set
            {
                banId = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Photo
        {
            get
            {
                return photo;
            }
            set
            {
                photo = value;
            }
        }

        public string ReasonForBan
        {
            get
            {
                return reasonForBan;
            }
            set
            {
                reasonForBan = value;
            }
        }

   


        #endregion
        #region Constructors
        public BannedCustomer()
        {
            throw new System.NotImplementedException();
        }

        public BannedCustomer(int id,string firstName, string lastName, string email,string reasonForBan, string photo)
        {
            this.banId = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.reasonForBan = reasonForBan;
            this.photo = photo;
            
        }

        #endregion


    }
}