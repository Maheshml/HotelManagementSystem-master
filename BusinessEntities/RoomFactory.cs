using System;

namespace BusinessEntities
{
    public static class RoomFactory
    {
        private static IRoom room = null;

        public static IRoom GetRoom(int roomNumber, string roomType, string roomDescription, string status, int roomFloor)
        {
            if (room != null) // ie is Hotel is primed with an object. 
                return room;
            else
                return new Room(roomNumber, roomType,  roomDescription, status, roomFloor); // Factory coughs up a regular user (for production code) 
        }

        public static void SetRoom(IRoom aRoom)
        // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            room = aRoom;
        }

        //get available room 

        public static IRoom GetAvailableRomm(int hotelCapacityID, DateTime availableDate, int singleRoomC, int doubleRoomC, int suitRoomC)
        {
            return room ?? new Room(hotelCapacityID, availableDate, singleRoomC, doubleRoomC, suitRoomC);
        }







    }
}
