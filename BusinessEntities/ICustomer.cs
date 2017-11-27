using System;

namespace BusinessEntities
{
    public interface ICustomer
    {

        int CustomerId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string CopyOfId { get; set; }

    }
}