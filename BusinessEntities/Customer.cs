using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class Customer : ICustomer
    {
        #region Instance Properties
        private int customerId;
        private string firstName;
        private string lastName;
        private string email;
        private string copyOfId;
        


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

        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
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

        public string CopyOfId
        {
            get
            {
                return copyOfId;
            }
            set
            {
                copyOfId = value;
            }
        }

        




        #endregion
        #region Constructors
        public Customer()
        {
            throw new System.NotImplementedException();
        }

        public Customer(int id, string firstName, string lastName, string email,  string copyOfId)
        {
            this.customerId = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
           
            this.copyOfId = copyOfId;

        }

        #endregion


    }
}
