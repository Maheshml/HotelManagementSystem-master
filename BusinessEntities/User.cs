using System;

namespace BusinessEntities
{
    public class User : IUser
    {
        #region Instance Properties
        private int userID;
        private string name;
        private string password;
        private int employeeNumber;
        private int userType;
        private Boolean status;

        #endregion

        #region Instance Properties
        public string Name
        {
            get
            {
                return name; ;
            }
            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }


       public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }
        public int EmployeeNumber
        {
            get
            {
                return employeeNumber;
            }
            set
            {
                employeeNumber = value;
            }
        }
        public int UserType
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }

        public Boolean Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        #endregion
        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(int userID, string name, string password, int employeeNumber, int userType, Boolean status)
        {
            this.userID = userID;
            this.name = name;
            this.password = password;
            this.employeeNumber = employeeNumber;
            this.userType = userType;
            this.status = status;
        }

        #endregion


       
      
    }
}