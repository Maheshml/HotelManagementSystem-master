using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IPerson
    {
        string title { get; set; }
        string firstName { get; set; }
        string middleName { get; set; }
        string lastName { get; set; }
        string phoneNumber { get; set; }
        string email { get; set; }
        Address personalAddress { get; set; }
    }
}

