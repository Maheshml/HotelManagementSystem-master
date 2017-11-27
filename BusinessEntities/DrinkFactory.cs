namespace BusinessEntities
{
    public class DrinkFactory
    {

        private static IDrink drink = null;

        public static IDrink getDrink(int DrinkId, string DrinkType, string DrinkName, double DrinkPrice, int DrinkQuantity)
        {
            if (drink != null) // ie is Hotel is primed with an object. 
                return drink;
            else
                return new Drink( DrinkId,  DrinkType,  DrinkName,  DrinkPrice,  DrinkQuantity); // Factory coughs up a regular user (for production code) 
        }

        public static void setDrink(IDrink aDrink)
        // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            drink = aDrink;
        }


    }
}
