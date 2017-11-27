namespace BusinessEntities
{
    public class DrinkFactory
    {

        private static readonly IDrink _drink = null;

        public static IDrink getDrink(int drinkID, string drinkType, string drinkName, double drinkPrice,int drinkQuantity)
        {
            return _drink ?? new Drink(drinkID, drinkType, drinkName, drinkPrice, drinkQuantity);
        }


    }
}
