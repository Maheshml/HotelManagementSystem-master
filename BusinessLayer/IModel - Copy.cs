using BusinessEntities;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IModel
    {

        IUser CurrentUser { get; set; }

        DataAccessLayer.IDataLayer DataLayer { get; set; }

        // Manage Users
        bool AddNewUser(string name, string password, int employeeNumber, int userType, Boolean status);
        bool EditUser(BusinessEntities.IUser user);
        bool DeleteUser(IUser user);

        bool DeleteBannedCustomer(IBannedCustomer customer);


        // Manage Employees
        bool AddNewEmployeeToDb(string title, string firstName, string middleName, string lastName, string phoneNumber, string email, Address personalAddress,
            int employeeNumber, DateTime dateOfBirth, string ppsn, double wage, int employeeCategory, int employeeCardNumber, DateTime hireDate, string photo);
        void PopulateEmployeeList();

        // Manage Suppliers
        bool AddNewSupplier(int supplierId, string name, string phoneNum, string email, string street, string city, string county, string additionalInfo);
        void PopulateSupplierList();

        //Manage StockOrders
        bool AddNewStockOrder(DateTime orderCreated, int supplierID, string deliverTo, double orderTotal, string status);
        void PopulateStockOrderList();
        bool ReceiveStockOrder(BusinessEntities.IStockOrder stockOrder);

        //Manage Stock Order Items
        bool AddNewStockOrderItem(int itemID, int quantity, double total, int orderID);
        void PopulateStockOrderItemList();
        bool ReceiveStockOrderItem(BusinessEntities.IStockOrderItem stockOrderItem);
        //Manage Items
        void PopulateItemList();
        bool UpdateItemQuantity(BusinessEntities.IItem Item);

        // Manage Banned Customers

        bool AddCustomerToBannedList(int id, string firstName, string lastName, string email, string reasonForBan, string photo);

        //Manage Bookings
        void PopulateBookingList();

        //Manage Extra Charges
        void PopulateExtraChargeList();

        //Manage Guests
        void PopulateGuestList();


        // Manage Menu
        void SetupMenu(string itemName, string itemType, double itemPrice, string itemDescrip);

        //update order status
        void updateOrderStatus(bool status);
        bool SendOrder(Dictionary<string, int> orderList, string ticketNum, double totalBalance);
        int getUserTypeForCurrentUser();

        bool Login(string name, string password);
        bool Logout();

        void TearDown();

        //Manage Special Offers


        bool addNewSpecialOffer(int id, decimal percent, DateTime startDate, DateTime endDate, string name, string description, string state);

        bool DeleteOffer(ISpecialOffer offer);

        void UpdateRoomStatus(int RoomId);

        void UpdateRoomStatusToClean(int RoomId);
        void RemoveDrinkQuantity(int drinkId);

        void RemoveSnackQuantity(int snackId);

        void AddDrinkQuantity(string drinkName);

        void AddSnackQuantity(string snackName);

        bool addRoomToHouseKeeping(int keepingId, int Roomid, string Cleaner, string Description, DateTime DateOfCleaning, string CleaningType);

        bool DeleteRoomToClean(IHousekeeping room);
        //update a menu item in the database
        //bool UpdateMenuItem(int itemID, string itemTyoe, string Name, double Price, string Description);
        bool UpdateMenuItem(IMenuItem menuItem);

        //update employee details
        //bool UpdateEmployeeDetails(IEmployee employee);
    
        //delete menu item from database
        bool DeleteMenuItem(IMenuItem menuItem);
        List<IUser> UserList { get; }
        List<IEmployee> EmployeeList { get; }
        List<IMenuItem> MenuItemList { get; }
        List<IMenuItem> MenuItemTypeList { get; }
        List<IItem> ItemList { get; }
        List<ISupplier> SupplierList { get; }

        //Stock Order List
        List<IStockOrder> StockOrderList { get; }

        //Guest List
        List<IGuest> GuestList { get; }


        //Stock Order Item List
        List<IStockOrderItem> StockOrderItemList { get; set; }
        //Booking List
        List<IBooking> BookingList { get; set; }

        //Extra Charge List
        List<IExtraCharge> ExtraChargeList { get; set; }

        //Manage Rooms
        List<IRoom> RoomList { get; set; }
        bool CheckIn(BusinessEntities.IRoom room, BusinessEntities.IBooking booking);
        bool CheckOut(BusinessEntities.IRoom room, BusinessEntities.IBooking booking, BusinessEntities.IExtraCharge extraCharge);

        //List<IHousekeeping> HousekeepingList { get; set; }

        List<IUser> BannedCustomerList { get; }
 
        //List<IRoom> AvailableRoomList { get; }

       // List<IHousekeeping> _housekeepingList { get; set; }
        List<ISpecialOffer> SpecialOfferList { get; set;}
        //void GetAvailableRooms();
        List<IDrink> DrinksList { get; set; }

        List<ISnack> SnacksList { get; set; }


        //get all drinks
        //void GetAllDrinks();

        //Manage Rooms
        void PopulateRoomList();



    }
}