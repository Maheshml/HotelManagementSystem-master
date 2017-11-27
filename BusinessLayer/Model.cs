using BusinessEntities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class Model : IModel
    {
        #region Static Attributes

        private static IModel _modelSingletonInstance; // Model object is a singleton so only one instance allowed

        static readonly object Padlock = new object();
            // Need this for thread safety on the Model singleton creation. ie in GetInstance () method

        #endregion

        #region Instance Attributes

        private IDataLayer _dataLayer;
        private IUser _currentUser;
        private List<IUser> _userList;
        private List<ISpecialOffer> _offerList;
        private List<iBarOrder> _barOrderList;
        private List<ISnack> _snackList;
        private List<IEmployee> _employeeList;
        private List<IMenuItem> _menuItemList;
        private List<IHousekeeping> _housekeepingList;
        private List<ISupplier> _supplierList;
        private List<IMenuItem> _menuItemTypeList;
        private List<IBannedCustomer> _bannedCustomerList;
        private List<IItem> _itemList;
        private List<IRoom> _AvailableRoomList;
        private List<IDrink> _drinkList;
        private List<IStockOrder> _stockOrderList;
        private List<IStockOrderItem> _stockOrderItemList;
        private List<IBooking> _bookingList;
        private List<IGuest> _guestList;
        private List<IRoom> _roomList;

        #endregion

        #region Instance Properties

        public IDataLayer DataLayer
        {
            get { return _dataLayer; }
            set { _dataLayer = value; }
        }

        public IUser CurrentUser
        {
            get { return _currentUser; }

            set { _currentUser = value; }
            }




        public List<IUser> UserList
        {
            get { return _userList; }

            }


        public List<IRoom> RoomList
        {
            get { return _roomList; }
            set { _roomList = value; }
        }


        public List<IBannedCustomer> BannedCustomerList
        {
            get { return _bannedCustomerList; }
            set { _bannedCustomerList = value; }
            }

        public List<IEmployee> EmployeeList
        {
            get { return _employeeList; }
            set { _employeeList = value; }
        }

        public List<IMenuItem> MenuItemList
        {
            get { return _menuItemList; }
            set { _menuItemList = value; }
        }



        public List<IHousekeeping> HousekeepingList
        {
            get { return _housekeepingList; }
            set { _housekeepingList = value; }

        }

        public List<ISupplier> SupplierList
        {
            get { return _supplierList; }
            set { _supplierList = value; }
        }

        public List<IItem> ItemList
        {
            get { return _itemList; }
            set { _itemList = value; }
        }

        public List<IMenuItem> MenuItemTypeList
        {
            get { return _menuItemTypeList; }
            set { _menuItemTypeList = value; }
        }

        List<IUser> IModel.BannedCustomerList
        {
            get { return _modelSingletonInstance.BannedCustomerList; }
            }

        public List<ISpecialOffer> SpecialOfferList
        {
            get { return _offerList; }
            set { _offerList = value; }

        }

        public List<iBarOrder> barOrderList
        {
            get { return _barOrderList; }
            set { _barOrderList = value; }
        }


        public List<ISnack> SnacksList
        {
            get { return _snackList; }
            set { _snackList = value; }

        }


        public List<IDrink> DrinksList
        {
            get { return _drinkList; }
            set { _drinkList = value; }
        }

        public List<IStockOrder> StockOrderList
        {
            get { return _stockOrderList; }
            set { _stockOrderList = value; }
        }

        public List<IStockOrderItem> StockOrderItemList
        {
            get { return _stockOrderItemList; }
            set { _stockOrderItemList = value; }
        }

        public List<IBooking> BookingList
        {
            get { return _bookingList; }
            set { _bookingList = value; }
        }

        public List<IGuest> GuestList
        {
            get { return _guestList; }
            set { _guestList = value; }
        }

        public List<IRoom> AvailableRoomList
        {
            get
            {
                return _AvailableRoomList;
            }
        }

        #endregion

        #region Constructors/Destructor

        public static IModel GetInstance(IDataLayer _DataLayer)
            // With Singleton pattern this method is used rather than constructor
        {
            lock (Padlock) //   only one thread can entry this block of code
            {
                if (_modelSingletonInstance == null)
                {
                    _modelSingletonInstance = new Model(_DataLayer);
                }
                return _modelSingletonInstance;
            }
        }

        public Model(IDataLayer _DataLayer)
            // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            _userList = new List<IUser>();
            this.BannedCustomerList = new List<IBannedCustomer>();

            
            _dataLayer = _DataLayer;
            this.BannedCustomerList = _dataLayer.GetAllBannedCustomers();
            _userList = _dataLayer.GetAllUsers(); // setup Models userList so we can login
            _employeeList = _DataLayer.GetAllEmployees();
            _menuItemTypeList = _DataLayer.PopulateComboboxItemType();
            _menuItemList = _DataLayer.GetMenuItems();
            _AvailableRoomList = _DataLayer.DisplayAvailableRooms();

        }

        ~Model()
        {
            TearDown();
        }

        #endregion


        public bool Login(string name, string password)
        {
            foreach (User user in _userList)
            {
                if (name == user.Name && password == user.Password)
                {
                    CurrentUser = user;
                    return true;
                }
            }
            return false;
        }

        public bool Logout()
        {
            CurrentUser = null;
            if (CurrentUser == null)
                return true;
            return false;
        }


        public bool AddNewUser(string name, string password, int employeeNumber, int userType, Boolean status)
        {
            try
            {
                int maxId = 0;
                // need some code to avoid dulicate usernames
                // maybe add some logic (busiess rules) about password policy
                //      IUser user = new User(name, password, userType); // Construct a User Object
                foreach (User user in UserList)
                {
                    if (user.UserID > maxId)
                        maxId = user.UserID;
                }
                IUser theUser = UserFactory.GetUser(maxId + 1, name, password, employeeNumber, userType, status);
                    // Using a Factory to create the user entity object. ie seperating object creation from business logic
                _userList.Add(theUser); // Add a reference to the newly created object to the Models UserList
                //DataLayer.AddNewUserToDb(theUser); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        //public bool AddCustomerToBannedList(int id, string firstName, string lastName, string email, string reasonForBan, string photo)
        public bool AddCustomerToBannedList(int i, string firstName, string lastName, string email, string reasonForBan,
            string photo)
        {

            try
            {
                // need some code to avoid dulicate usernames
                // maybe add some logic (busiess rules) about password policy
                //      IUser user = new User(name, password, userType); // Construct a User Object
                MessageBox.Show("Firstname passed");
                MessageBox.Show(firstName);

                IBannedCustomer customer = BannedCustomerFactory.GetBannedCustomer(i, firstName, lastName, email, reasonForBan, photo);
                // Using a Factory to create the user entity object. ie seperating object creation from business logic
              //  IBannedCustomer aCust = new BannedCustomer(firstName, lastName, email, reasonForBan, photo);
                _bannedCustomerList.Add(customer);
         //       MessageBox.Show("customer object received from factory and added to list"); // Add a reference to the newly created object to the Models UserList
                //  DataLayer.AddNewBannedCustomerToDb(firstName, lastName, email, reasonForBan, photo);
                //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
                return false;           
            }
        }


        public bool AddNewEmployeeToDb(string title, string firstName, string middleName, string lastName,
            string phoneNumber, string email, Address personalAddress,
            int employeeNumber, DateTime dateOfBirth, string ppsn, double wage, int employeeCategory,
            int employeeCardNumber, DateTime hireDate, string photo)
        {
            try
            {
                int maxId = 0;
                // need some code to avoid dulicate usernames
                // maybe add some logic (busiess rules) about password policy
                //      IUser user = new User(name, password, userType); // Construct a User Object
                foreach (Employee employee in EmployeeList)
                {
                    if (employee.employeeNumber > maxId)
                        maxId = employee.employeeNumber;
                }
                IEmployee theEmployee = EmployeeFactory.GetEmployee(title, firstName, middleName, lastName, phoneNumber,
                        email, personalAddress, employeeNumber, dateOfBirth, ppsn, wage, employeeCategory,
                        employeeCardNumber, hireDate, photo);
                    // Using a Factory to create the user entity object. ie seperating object creation from business logic
                EmployeeList.Add(theEmployee); // Add a reference to the newly created object to the Models UserList
                DataLayer.AddNewEmployeeToDb(theEmployee); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

       


        public bool AddNewSpecialOffer(int id,decimal percent, DateTime startDate, DateTime endDate, string name, string description, string state)
        {
            try
            {
                var specialoffer = SpecialOfferFactory.GetOffer(id,percent, startDate, endDate, name, description, state);
                _offerList.Add(specialoffer);
                DataLayer.AddSpecialOffer(id,percent, startDate, endDate, name, description, state);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public bool DeleteOffer(ISpecialOffer offer)
        {
            DataLayer.deleteOffer(offer);
            SpecialOfferList.Remove(offer);
            return true;
        }
        public bool addRoomToHouseKeeping(int keepingId, int Roomid, string Cleaner, string Description, DateTime DateOfCleaning, string CleaningType)
        {
            try
            {
                IHousekeeping houseKeeping = HousekeepingFactory.getHousekeeping(keepingId, Roomid, Cleaner, Description, DateOfCleaning, CleaningType);
                _housekeepingList.Add(houseKeeping);
              //  DataLayer.addRoomToClean(keepingId, Roomid, Cleaner, Description, DateOfCleaning, CleaningType);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public bool DeleteRoomToClean(IHousekeeping room)
        {
            //DataLayer.deleteRoomToCleanFromDB(room);
            HousekeepingList.Remove(room);
            return true;
        }
        public void  UpdateRoomStatus(int RoomId)
        {
            try
            {
                DataLayer.UpdateRoomStatusInDb(RoomId);
                
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }
        public void UpdateRoomStatusStatusDelete(int RoomId)
        {
            try
            {
            //    DataLayer.UpdateRoomStatusStatusDelete(RoomId);

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }

        public void RemoveDrinkQuantity(int drinkId)
        {
            try
            {
                DataLayer.RemoveDrinkQuantity(drinkId);

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }
        public void RemoveSnackQuantity(int snackId)
        {
            try
            {
                DataLayer.RemoveSnackQuantity(snackId);

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }
        public void AddDrinkQuantity(string drinkName)
        {
            try
            {
                DataLayer.AddDrinkQuantity(drinkName);

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }
        public void AddSnackQuantity(string snackName)
        {
            try
            {
                DataLayer.AddSnackQuantity(snackName);

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }

        public bool InsertBarOrder(int Orderid, DateTime orderTime, string orderItems, double orderPrice, int orderQuantity, double orderChange)
        {
            try
            {
                iBarOrder barorder = barOrderFactory.getBarOrders(Orderid, orderTime, orderItems, orderPrice, orderQuantity, orderChange);
                _barOrderList.Add(barorder);
               // DataLayer.InsertBarOrder(Orderid, orderTime, orderItems, orderPrice, orderQuantity, orderChange);
                return true;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
                return false;
            }
        }
        public void UpdateRoomStatusToClean(int RoomId)
        {
            try
            {
                DataLayer.UpdateRoomStatusToCleanInDb(RoomId);

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }
        public bool DeleteUser(IUser user)
        {
            DataLayer.deleteUserFromDB(user);
            UserList.Remove(user); 
            return true;
        }
        public bool DeleteBannedCustomer(IBannedCustomer customer)
        {
            DataLayer.deleteBannedCustomerFromDB(customer);
            BannedCustomerList.Remove(customer);
            return true;
        }

        //Edits user details in the DB-Grace
        public bool EditUser(IUser user)
        {
            DataLayer.editUserInDB(user);
            return true;
        }

        //Edits stock order details in the DB-Grace
        public bool ReceiveStockOrder(IStockOrder stockOrder)
        {
            DataLayer.ReceiveStockOrderInDB(stockOrder);
            return true;
        }

        public bool CheckIn(IRoom room, IBooking booking)
        {
            DataLayer.CheckInDB(room, booking);
            return true;
        }
        public bool ReceiveStockOrderItem(IStockOrderItem stockOrderItem)
        {
            DataLayer.ReceiveStockOrderItemInDB(stockOrderItem);
            return true;
        }

        //Updates the quantity of an item-Grace
        public bool UpdateItemQuantity(IItem Item)
        {
            DataLayer.UpdateItemInDB(Item);
            return true;
        }

        //Deletes an item from the inventory-Grace
        public bool DeleteItem(Item item)
        {
            DataLayer.DeleteItemFromDB(item);
            ItemList.Remove(item);
            return true;
        }



        //Adds a new supplier to the DB-Grace
        public bool AddNewSupplier(int supplierID, string name, string phoneNum, string email, string street, string city, string county, string additionalInfo)
        {
            SupplierList = DataLayer.getAllSuppliers();
            ISupplier supplier;
            DataLayer.AddNewSupplierToDB(supplierID, name, phoneNum, email, street, city, county, additionalInfo);
            supplier = SupplierFactory.GetSupplier(supplierID, name, phoneNum, email, street, city, county, additionalInfo);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
            SupplierList.Add(supplier);
            // Add a reference to the newly created object to the Models UserList
            //Gets the DataLayer to add the new user to the DB. 
            return true;



        }

        //Adds a new stock order to the database-Grace
        public bool AddNewStockOrder(DateTime orderCreated, int supplierID, string deliverTo, double orderTotal, string status)
        {

            try
            {

                StockOrderList = DataLayer.getAllOrders();
                int maxId = 0;

                foreach (StockOrder order in StockOrderList)
                {
                    if (order.orderID > maxId)
                        maxId = order.orderID;
                }
                IStockOrder theOrder = StockOrderFactory.GetStockOrder(maxId + 1, orderCreated, supplierID, deliverTo, orderTotal, status);
                // Using a Factory to create the user entity object. ie seperating object creation from business logic
                _stockOrderList.Add(theOrder); // Add a reference to the newly created object to the Models UserList
                DataLayer.AddNewStockOrderToDB(theOrder); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        //Adds a new stock order item to the stock order item table-Grace
        public bool AddNewStockOrderItem(int itemID, int quantity, double total, int orderID)
        {

            try
            {

                StockOrderItemList = DataLayer.getAllStockOrderItems();
                int maxId = 0;

                foreach (StockOrderItem item in StockOrderItemList)
                {
                    if (item.OrderItemID > maxId)
                        maxId = item.OrderItemID;
            }

                IStockOrderItem theItem = StockOrderItemFactory.GetOrderItem(maxId + 1, itemID, quantity, total, orderID);
                // Using a Factory to create the user entity object. ie seperating object creation from business logic
                _stockOrderItemList.Add(theItem); // Add a reference to the newly created object to the Models UserList
                DataLayer.AddNewStockOrderItemToDB(theItem); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }


        public bool addNewSpecialOffer(int id,decimal percent, DateTime startDate, DateTime endDate, string name, string description, string state)
        {
            try
            {
                ISpecialOffer specialoffer = SpecialOfferFactory.GetOffer(id,percent, startDate, endDate, name, description, state);
                _offerList.Add(specialoffer);
                DataLayer.AddSpecialOffer(id,percent, startDate, endDate, name, description, state);
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }



        public bool SetupMenu(string itemName, string itemType, double itemPrice, string itemDescrip)
        {
            return (_dataLayer.SetupMenu(itemName, itemType, itemPrice, itemDescrip));
          

        }

    

        public void PopulateMenuItem()
        {
            MenuItemList = _dataLayer.GetMenuItems();
        }

        public void PopulateEmployee() //get all the employee in the database
            
        {
            EmployeeList = _dataLayer.GetAllEmployees();
        }

        public void PopulateItemTypeList()
        {
            MenuItemTypeList = _dataLayer.PopulateComboboxItemType();
        }

     //   get all drinks
        public void GetAllDrinks()
        {
            DrinksList = _dataLayer.GetAlDrinks();
        }


       // get available rooms
        public void GetAvailableRooms()
        {
            _AvailableRoomList = _dataLayer.DisplayAvailableRooms();
        }


        //Populates a list with all the suppliers-Grace
        public void PopulateSupplierList()
        {
            _supplierList = _dataLayer.getAllSuppliers();
        }

        //Populates a list with all the stock orders-Grace
        public void PopulateStockOrderList()
        {
            _stockOrderList = _dataLayer.getAllOrders();
        }

        //Populates a list with all the stock order items-Grace
        public void PopulateStockOrderItemList()
        {
            _stockOrderItemList = _dataLayer.getAllStockOrderItems();
        }


        //Populates a list with all the inventory items-Grace
        public void PopulateItemList()
        {
            _itemList = _dataLayer.getAllItems();
        }

        public void TearDown()
        {
            DataLayer.CloseConnection();
        }


        public bool UpdateMenuItem(IMenuItem menuItem)
        {
            var result = _dataLayer.UpdateMenuItem(menuItem);

            return result;
        }
        //method to delete menu item from database
        public bool DeleteMenuItem(IMenuItem menuItem)

        {
            var result = _dataLayer.DeletMenuItem(menuItem);


            return result;
        }
        public void PopulateEmployeeList()//get all the employee in the database

        {
            EmployeeList = _dataLayer.GetAllEmployees();

        }

        public int getUserTypeForCurrentUser()
         {
            return _currentUser.UserType;
        }


        public bool AddCustomerToBannedList(string firstName, string lastName, string email, string reasonForBan, string photo)
        {
            throw new NotImplementedException();
        }
        //
        //  send order to DB
        //
        public bool SendOrder(string tickenNum, double totalBalance)

        {
            var result = _dataLayer.Order(tickenNum, totalBalance);

            return result;
        }




        public void PopulateBookingList()
        {
            _bookingList = _dataLayer.GetAllBookings();
        }

        public void PopulateGuestList()
        {
            _guestList = _dataLayer.GetAllGuests();
        }

        public void PopulateRoomList()
        {
            _roomList = _dataLayer.GetAllRooms();
        }

        public void PopulateOfferList()
        {
            _offerList = _dataLayer.GetAllOffers();
        }
            public void PopulateHousekeepingList()
        {
            _housekeepingList = _dataLayer.GetAllRoomsToClean();
        }
        public void PopulateOrdersList()
        {
         //   _barOrderList = _dataLayer.GetAllBarOrders();
        }
        public void PopulateSnacksList()
        {
            _snackList = _dataLayer.DisplaySnacks();
        }
        public void PopulateDrinksList()
        {
            _drinkList = _dataLayer.GetAlDrinks();
        }

        public void updateOrderStatus(bool status)
        {
            throw new NotImplementedException();
        }
    }
}

