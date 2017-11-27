using BusinessEntities;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        List<IMenuItem> MenuItemList { get; }
        // Manage Users
        void AddNewUserToDb(IUser theUser);
        bool editUserInDB(IUser user);
        bool deleteUserFromDB(IUser user);

        bool Order(string ticketNum, double totalBalance);
        // Manage Employees
        bool AddNewEmployeeToDb(IEmployee theEmployee);

        bool deleteBannedCustomerFromDB(IBannedCustomer customer);
        void AddNewBannedCustomerToDb(string firstName, string lastName, string email, string reasonForBan, string photo);

        // Manage Special Offer
        void AddSpecialOffer(int id,decimal percent, DateTime startDate, DateTime endDate, string name, string description, string state);

        bool deleteOffer(ISpecialOffer offer);
        void UpdateRoomStatusInDb(int roomID);
        void UpdateRoomStatusToCleanInDb(int roomId);
        void RemoveDrinkQuantity(int drinkId);
        void RemoveSnackQuantity(int snackId);
        void AddDrinkQuantity(string drinkName);
        void AddSnackQuantity(string snackName);
        // Manage Menu
        bool SetupMenu(string itemName, string itemType, double itemPrice, string itemDescrip);
        //Manage Suppliers
        bool AddNewSupplierToDB(int supplierID, string name, string phoneNum, string email, string street, string town, string county, string additionalInfo);

        //manage rooms

        //manage houseKeeping

        //void AddRoomToClean(int keepingId, int roomid, string cleaner, string description);
        void updateOrderStatus(bool status);
        void CloseConnection();
        void OpenConnection();
        System.Data.SqlClient.SqlConnection GetConnection();
        // Manage Lists
        List<IUser> GetAllUsers();
        List<IEmployee> GetAllEmployees();
        List<ISupplier> getAllSuppliers();
        List<IItem> getAllItems();
        List<IBannedCustomer> GetAllBannedCustomers();        
        List<IHousekeeping> GetAllRoomsToClean();
        List<IBooking> GetAllBookings();
        List<IExtraCharge> GetAllExtraCharges();
        List<IGuest> GetAllGuests();
        List<IRoom> GetAllRooms();
        List<ISpecialOffer> GetAllOffers();
        List<IMenuItem> PopulateComboboxItemType();
        List<IMenuItem> GetMenuItems();
        //method to update the menu item
        bool UpdateMenuItem(IMenuItem menuItem);
        bool DeletMenuItem(IMenuItem menuItem);
        //get all room from the database
        List<IRoom> DisplayAvailableRooms();
        List<ISnack> DisplaySnacks();
        //Fetch All drinks fron the drink table
        List<IDrink> GetAlDrinks();
        //Manage Stock Orders
        void AddNewStockOrderToDB(IStockOrder aStockOrder);
        List<IStockOrder> getAllOrders();
        bool ReceiveStockOrderInDB(IStockOrder stockOrder);
        List<IStockOrderItem> getAllStockOrderItems();
        void AddNewStockOrderItemToDB(IStockOrderItem aItem);
        bool ReceiveStockOrderItemInDB(IStockOrderItem stockOrderItem);
        //Manage Inv. Items
        bool UpdateItemInDB(IItem anItem);
        bool DeleteItemFromDB(IItem item);

        //Manage check ins
        bool CheckInDB(IRoom room, IBooking booking);

        bool DeleteUserFromDb(IUser user);
        //Manage checkouts
        bool CheckOutDB(IRoom room, IBooking booking, IExtraCharge extraCharge);

        //update employee Details
        bool UpdateEmployeeDetails(IEmployee Employee);
    }
}