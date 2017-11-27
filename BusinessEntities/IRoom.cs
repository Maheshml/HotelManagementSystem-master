using System;

namespace BusinessEntities
{
    public interface IRoom
    {
        int RoomNumber { get; set; }
        string RoomType { get; set; }
        string RoomDescription { get; set; }
        string Status { get; set; }
        int FloorNumber { get; set; }

         int HotelCapacityID { get; set; }
         DateTime AvailableDate { get; set; }
         int SingleRoomC { get; set; }
         int DoubleRoomC { get; set; }
         int SuitRoomC { get; set; }


    }
}
