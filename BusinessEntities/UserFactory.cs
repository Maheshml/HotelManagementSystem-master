using System;

namespace BusinessEntities
{
    public static class UserFactory // Only concern of user factory is to create objects. 
    {
        private static IUser user = null;


        public static IUser GetUser(int userID, string name, string password, int employeeNumber, int userType, Boolean status)
        {
            if (user != null) // ie is Hotel is primed with an object. 
                return user;
            else
                return new User(userID, name, password, employeeNumber, userType, status); // Factory coughs up a regular user (for production code) 
        }

        public static void SetUser(IUser aUser)
            // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            user = aUser;
        }

    }
}