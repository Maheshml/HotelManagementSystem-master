using System;

namespace BusinessEntities
{
    public interface IUser
    {
        int UserID { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        int EmployeeNumber { get; set; }
        int UserType { get; set; }
        Boolean Status { get; set; }
    }
}