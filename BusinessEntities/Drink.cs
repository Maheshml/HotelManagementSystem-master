using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Drink:IDrink
    {
        public Drink(int DrinkId,string DrinkType, string DrinkName, double DrinkPrice, int DrinkQuantity)
        {
            this.drinkId = DrinkId;
            this.drinkType = DrinkType;
            this.drinkName = DrinkName;
            this.drinkPrice = DrinkPrice;
            this.drinkQuantity = DrinkQuantity;
        }
        public int drinkId { get; set; }
        public string drinkType { get; set; }
        public string drinkName { get; set; }
        public double drinkPrice { get; set; }
        public int drinkQuantity { get; set; }

       
    }
}
