using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IDrink
    {
        int drinkId { get; set; }
        string drinkType { get; set; }
        string drinkName { get; set; }
        double drinkPrice { get; set; }
        int drinkQuantity { get; set; }
    }
}
