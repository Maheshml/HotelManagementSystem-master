using System;
using iTextSharp.text;

namespace BusinessEntities
{
    public class MenuItem : IMenuItem
    { 
        public MenuItem() { }

        public MenuItem(int menuItemID, string itemType,  double itemPrice,string itemName, string itemDescription)
        {


            this.ItemPrice = itemPrice;
            this.ItemDescription = itemDescription;
            this.ItemType = itemType;
            this.MenuItemID = menuItemID;
            this.ItemName = itemName;

        }
        public MenuItem(string itemType)
        {
          
            this.ItemType = itemType;

        }


        public string ItemType { get; set; }
        public double ItemPrice { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int MenuItemID { get; set; }
    }
}