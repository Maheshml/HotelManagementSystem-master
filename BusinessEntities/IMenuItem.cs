using iTextSharp.text;

namespace BusinessEntities

{
    public interface IMenuItem
    {

        string ItemName { get; set; }
        double ItemPrice { get; set; }
        string ItemDescription { get; set; }
        string ItemType { get; set; }

        int MenuItemID { get; set; }






    }
}