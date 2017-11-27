using System;

namespace BusinessEntities
{
    public class Room : IRoom
    {
        public Room(int RoomNumb, string RoomT, string RoomDesc, string Status, int RoomFloor)
        {
            roomNumber = RoomNumb;
            roomType = RoomT;
            roomDescription = RoomDesc;
            status = Status;
            floorNumber = RoomFloor;
        }


        public Room(int HotelCapacityID, DateTime AvailableDate, int SingleRoomC, int DoubleRoomC, int SuitRoomC)
        {
            hotelCapacityID = HotelCapacityID;
            availableDate = AvailableDate.Date;
            singleRoomC = SingleRoomC;
            doubleRoomC = DoubleRoomC;
            suitRoomC = SuitRoomC;
        }


        private int roomNumber { get; set; }
        private string roomType { get; set; }
        private string roomDescription { get; set; }
        public string status { get; set; }
        public int floorNumber { get; set; }
        public int hotelCapacityID { get; set; }
        public DateTime availableDate { get; set; }
        public int singleRoomC { get; set; }
        public int doubleRoomC { get; set; }
        public int suitRoomC { get; set; }


        //override the variable in the interface "IROOM"

        public int RoomNumber
        {
            get { return roomNumber; }

            set { roomNumber = value; }
        }

        public string RoomType
        {
            get { return roomType; }

            set { roomType = value; }
        }

        public string RoomDescription
        {
            get { return roomDescription; }

            set { roomDescription = value; }
        }

        public string Status {
            get {return status;}
            set { status = value; }
        }

        public int FloorNumber
        {
            get { return floorNumber; }
            set { floorNumber = value; }
        }

        public int HotelCapacityID
        {
            get {return hotelCapacityID;}
            set { hotelCapacityID = value; }
        }

        public DateTime AvailableDate
        {
            get { return availableDate; }
            set { availableDate = value; }
        }

        public int SingleRoomC
        {
            get {return singleRoomC;}
            set { singleRoomC = value; }
        }

        public int DoubleRoomC
        {
            get { return doubleRoomC; }
            set { doubleRoomC = value; }
        }
        public int SuitRoomC {
            get { return suitRoomC; }
            set { suitRoomC = value; }
        }
    }
}
