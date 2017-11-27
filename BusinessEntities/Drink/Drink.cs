namespace BusinessEntities
{
    public class Drink : IDrink
    {

        public  int drinkID { get; set; }
        public string drinkType { get; set; }
        public string drinkName { get; set; }
        public double drinkPrice { get; set; }
        public int drinkQuantity { get; set; }



        public Drink(int drinkID, string drinkType, string drinkName, double drinkPrice,int drinkQuantity)
        {
            this.DrinkID = drinkID;
            this.DrinkType = drinkType;
            this.drinkName = drinkName;
            this.drinkPrice = drinkPrice;
            this.DrinkQuantity = drinkQuantity;
        }

        public int DrinkID
        {
            get { return drinkID; }
            set { drinkID = value; }
        }

        public string DrinkType
        {
            get { return drinkType; }
            set { drinkType = value; }
        }

        public string DrinkName
        {
            get { return drinkName; }
            set { drinkName = value; }
        }

        public double DrinkPrice
        {
            get { return drinkPrice; }
            set { drinkPrice = value; }
        }
        public int DrinkQuantity
        {
            get { return drinkQuantity; }
            set { drinkQuantity = value; }
        }
    }
}