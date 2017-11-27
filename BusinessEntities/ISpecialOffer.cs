using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ISpecialOffer
    {
        int Id { get; set; }
        Decimal discount { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string State { get; set; }
    }
}
