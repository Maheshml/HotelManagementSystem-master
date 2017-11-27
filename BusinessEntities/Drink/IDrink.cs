namespace BusinessEntities
{
    public interface IDrink
    {
        int DrinkID { get; set; }
        string DrinkType { get; set; }
        string DrinkName { get;set; }
        double DrinkPrice { get; set; }


    }
}