namespace BusinessEntities
{
    public class RestaurantMenuFactory
    {
        private static IMenuItem _menuItem = null;

        public static IMenuItem GetMenuItem(int menuItemID, string itemName, double itemPrice, string itemDescription, string itemType)
        {

            if (_menuItem != null)
                return _menuItem;
            else
            return new MenuItem(menuItemID, itemName, itemPrice, itemDescription, itemType);
        }
        public static IMenuItem GetMenuItemType(string itemType)
        {

            if (_menuItem != null)
                return _menuItem;
            else
                return new MenuItem(itemType);
        }



   }
}