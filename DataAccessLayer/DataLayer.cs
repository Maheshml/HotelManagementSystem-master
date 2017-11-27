using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        #region Instance Attributes

        private SqlConnection _con; // DB Connection
        private DataSet _ds; //Declare the DataSet object
        private SqlDataAdapter _da; //Declare the DataAdapter object
        private int _maxRows;
        private SqlCommandBuilder _cb;
        int totSuppliers;
        int totItems;
        int totStockOrders;
        int totStockOrderItems;
        int _totItems;

        #endregion

        #region Static Attributes

        private static IDataLayer _dataLayerSingletonInstance;
        // DataLayer object is a singleton so only one instance allowed

        private static readonly object Padlock = new object();
        // Need this for thread safety on the DataLayer singleton creation. ie in GetInstance () method

        #endregion

        #region Constructors

        public static IDataLayer GetInstance() // With Singleton pattern this method is used rather than constructor
        {
            lock (Padlock) //   only one thread can entry this block of code
            {
                if (_dataLayerSingletonInstance == null)
                    _dataLayerSingletonInstance = new DataLayer();
                return _dataLayerSingletonInstance;
            }
        }

        private DataLayer()
        // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            OpenConnection();
        }

        #endregion

        public void OpenConnection()
        {
            _con = new SqlConnection();
            //con.ConnectionString = "Data Source=alpha-coders-srv.database.windows.net ;Initial Catalog=chelsea_hms;Integrated Security=True";


            _con.ConnectionString =
                "Server=tcp:alpha-coders-srv.database.windows.net; Database=chelsea; User ID =admin1617@alpha-coders-srv.database.windows.net;Password=SD20162017.;Trusted_Connection=False; Encrypt=False;";

            //_con.ConnectionString = "Data Source = sql3.student.litdom.lit.ie\\Team6; Initial Catalog = chelsea; Integrated Security = True";
            //Server=tcp:[serverName].database.windows.net;Database=myDataBase;
            //User ID =[LoginForDb]@[serverName];Password=myPassword;Trusted_Connection=False;
            //Encrypt=True;
            try
            {
                _con.Open();
            }
            catch (Exception excep)
            {
                //MessageBox.Show(excep.Message);
                Console.Write(excep.Message);
                Environment.Exit(0); //Force the application to close
            }
        }

        public void CloseConnection()
        {
            _con.Close();
        }

        public SqlConnection GetConnection()
        {
            return _con;
        }

        public List<IMenuItem> MenuItemList { get; set; }
        //Grace
        public List<IStockOrder> getAllOrders()
        {
            List<IStockOrder> StockOrderList = new List<IStockOrder>();
            try
            {

                var ds = new DataSet();
                string sql = "SELECT * From StockOrder";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "StockOrders");
                totStockOrders = ds.Tables["StockOrders"].Rows.Count;
                for (int i = 0; i < totStockOrders; i++)
                {
                    DataRow dRow = ds.Tables["StockOrders"].Rows[i];
                    IStockOrder stockOrder = StockOrderFactory.GetStockOrder(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                     Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()),

                                                                     Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()),
                                                                     dRow.ItemArray.GetValue(5).ToString(),
                                                                    Convert.ToDouble(dRow.ItemArray.GetValue(6).ToString()),
                                                                     dRow.ItemArray.GetValue(7).ToString());

                    if (stockOrder.status == "Sent")
                    {
                        stockOrder.orderSent = Convert.ToDateTime(dRow.ItemArray.GetValue(2).ToString());
                    }

                    StockOrderList.Add(stockOrder);
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return StockOrderList;
        }
        //Grace
        public List<IStockOrderItem> getAllStockOrderItems()
        {
            List<IStockOrderItem> StockOrderItems = new List<IStockOrderItem>();
            try
            {

                var ds = new DataSet();
                string sql = "SELECT * From StockOrderItem";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "StockOrderItems");
                totStockOrderItems = ds.Tables["StockOrderItems"].Rows.Count;
                for (int i = 0; i < totStockOrderItems; i++)
                {
                    DataRow dRow = ds.Tables["StockOrderItems"].Rows[i];
                    IStockOrderItem stockOrderItem = StockOrderItemFactory.GetOrderItem(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                     Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()),
                                                                     Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()),
                                                                     Convert.ToDouble(dRow.ItemArray.GetValue(3).ToString()),
                                                                     Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()));



                    StockOrderItems.Add(stockOrderItem);
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return StockOrderItems;
        }

        //Grace
        public void AddNewStockOrderItemToDB(IStockOrderItem aItem)
        {

            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From StockOrderItem";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "ItemData");
                _maxRows = ds.Tables["ItemData"].Rows.Count;
                var dRow = ds.Tables["ItemData"].NewRow();

                dRow[0] = aItem.OrderItemID;
                dRow[1] = aItem.ItemID;
                dRow[2] = aItem.Quantity;
                dRow[3] = aItem.Total;
                dRow[4] = aItem.OrderID;



                ds.Tables["ItemData"].Rows.Add(dRow);
                da.Update(ds, "ItemData");
            }
            catch (Exception e3)
            {
                if (_con.State.ToString() == "Open")
                    _con.Close();
                MessageBox.Show(e3.ToString());
                //Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }

        }

        //Grace
        public void AddNewStockOrderToDB(IStockOrder aStockOrder)
        {

            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From StockOrder";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "OrderData");
                _maxRows = ds.Tables["OrderData"].Rows.Count;
                var dRow = ds.Tables["OrderData"].NewRow();

                dRow[0] = aStockOrder.orderID;
                dRow[1] = aStockOrder.orderCreated;
                dRow[4] = aStockOrder.supplierID;
                dRow[5] = aStockOrder.deliverTo;
                dRow[6] = aStockOrder.orderTotal;
                dRow[7] = aStockOrder.status;


                ds.Tables["OrderData"].Rows.Add(dRow);
                da.Update(ds, "OrderData");
            }
            catch (Exception e3)
            {
                if (_con.State.ToString() == "Open")
                    _con.Close();
                MessageBox.Show(e3.ToString());
                //Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }

        }
        //Grace
        //Populating inventory items list.
        public List<IItem> getAllItems()
        {
            List<IItem> ItemList = new List<IItem>();
            try
            {
                var ds = new DataSet();
                string sql = "SELECT * From Item";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "ItemData");
                totItems = ds.Tables["ItemData"].Rows.Count;
                for (int i = 0; i < totItems; i++)
                {
                    DataRow dRow = ds.Tables["ItemData"].Rows[i];
                    IItem item = ItemFactory.GetItem(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                        dRow.ItemArray.GetValue(1).ToString(),
                        Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()),
                        Convert.ToDouble(dRow.ItemArray.GetValue(3).ToString()),
                        Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()),
                        dRow.ItemArray.GetValue(5).ToString()
                    );

                    ItemList.Add(item);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return ItemList;
        }

        //Grace
        public List<IUser> GetAllUsers()
        {
            var userList = new List<IUser>();
            try
            {
                _ds = new DataSet();
                var sql = "SELECT * From Users";
                _da = new SqlDataAdapter(sql, _con);
                _cb = new SqlCommandBuilder(_da); //Generates
                _da.Fill(_ds, "UsersData");
                _maxRows = _ds.Tables["UsersData"].Rows.Count;
                for (var i = 0; i < _maxRows; i++)
                {
                    var dRow = _ds.Tables["UsersData"].Rows[i];
                    var user = UserFactory.GetUser(
                         Convert.ToInt16(dRow.ItemArray.GetValue(0)), //userID
                        dRow.ItemArray.GetValue(1).ToString(), //name
                        dRow.ItemArray.GetValue(2).ToString(), //password
                        Convert.ToInt16(dRow.ItemArray.GetValue(3)), //employeeNum
                        Convert.ToInt16(dRow.ItemArray.GetValue(4)), // userType
                        Convert.ToBoolean(dRow.ItemArray.GetValue(5))); //status

                    //IUser user = new User(dRow.ItemArray.GetValue(0).ToString(),
                    //                                    dRow.ItemArray.GetValue(1).ToString(),
                    //                                    dRow.ItemArray.GetValue(2).ToString());


                    userList.Add(user);
                }
            }
            catch (Exception excep)
            {
                //MessageBox.Show(excep.Message);  //Anna
                Console.WriteLine(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                // Application.Exit();              
                //Environment.Exit(0); //Force the application to close
            }
            return userList;
        }

        public List<IBannedCustomer> GetAllBannedCustomers()
        {
            List<IBannedCustomer> bannedCustomerList = new List<IBannedCustomer>(); // create local version of list 
            try
            {
                //MessageBox.Show("Getting All Banned Customers");
                var ds = new DataSet(); // create new dataset object
                const string sql = "SELECT * FROM BannedCustomer"; // create string with sql embeded
                var da = new SqlDataAdapter(sql, _con);
                // create data adapter object pass in the sql string and the connection
                new SqlCommandBuilder(da); //pass the data adapter into the sqlcommand builder 
                da.Fill(ds, "BannedCustomerDATA");
                var totalNumRows = ds.Tables["BannedCustomerDATA"].Rows.Count;

                for (var i = 0; i < totalNumRows; i++)
                {
                    //MessageBox.Show(i.ToString());
                    DataRow dRow = ds.Tables["BannedCustomerDATA"].Rows[i];

                    IBannedCustomer customer =
                        BannedCustomerFactory.GetBannedCustomer(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                    dRow.ItemArray.GetValue(1).ToString(),
                                    dRow.ItemArray.GetValue(2).ToString(),
                                    dRow.ItemArray.GetValue(3).ToString(),
                                    dRow.ItemArray.GetValue(4).ToString(),
                                    dRow.ItemArray.GetValue(5).ToString());


                    bannedCustomerList.Add(customer);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
            }

            return bannedCustomerList;
        }
        public List<ISpecialOffer> GetAllOffers()
        {
            var offersList = new List<ISpecialOffer>();
            try
            {
                _ds = new DataSet();
                var sql = "SELECT * From SpecialOffer";
                _da = new SqlDataAdapter(sql, _con);
                _cb = new SqlCommandBuilder(_da); //Generates
                _da.Fill(_ds, "OffersData");
                _maxRows = _ds.Tables["OffersData"].Rows.Count;
                for (var i = 0; i < _maxRows; i++)
                {
                    var dRow = _ds.Tables["OffersData"].Rows[i];
                    var offer = SpecialOfferFactory.GetOffer(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                        Convert.ToDecimal(dRow.ItemArray.GetValue(1)),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(2)),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(3)),
                        dRow.ItemArray.GetValue(4).ToString(),
                        dRow.ItemArray.GetValue(5).ToString(),
                        dRow.ItemArray.GetValue(6).ToString()
                        );


                    offersList.Add(offer);
                }
            }
            catch (Exception excep)
            {
                //MessageBox.Show(excep.Message);  //Anna
                Console.WriteLine(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                // Application.Exit();              /Anna
                //Environment.Exit(0); //Force the application to close
            }
            return offersList;
        }

        public List<iBarOrder> GetAllBarOrders()
        {
            var barOrderList = new List<iBarOrder>();
            try
            {
                _ds = new DataSet();
                var sql = "SELECT * From BarOrder";
                _da = new SqlDataAdapter(sql, _con);
                _cb = new SqlCommandBuilder(_da); //Generates
                _da.Fill(_ds, "BarOrderData");
                _maxRows = _ds.Tables["BarOrderData"].Rows.Count;
                for (var i = 0; i < _maxRows; i++)
                {
                    var dRow = _ds.Tables["BarOrderData"].Rows[i];
                    var barOrder = barOrderFactory.getBarOrders(
                        Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(1)),
                        dRow.ItemArray.GetValue(2).ToString(),
                        Convert.ToDouble(dRow.ItemArray.GetValue(3)),
                        Convert.ToInt32(dRow.ItemArray.GetValue(4)),
                        Convert.ToDouble(dRow.ItemArray.GetValue(5))
                        );


                    barOrderList.Add(barOrder);
                }
            }
            catch (Exception excep)
            {
                //MessageBox.Show(excep.Message);  //Anna
                Console.WriteLine(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                // Application.Exit();              /Anna
                //Environment.Exit(0); //Force the application to close
            }
            return barOrderList;
        }

        public List<ISnack> DisplaySnacks()
        {
            var SnacksList = new List<ISnack>();
            try
            {
                _ds = new DataSet();
                var sql = "SELECT * From Snack";
                _da = new SqlDataAdapter(sql, _con);
                _cb = new SqlCommandBuilder(_da); //Generates
                _da.Fill(_ds, "SnacksData");
                _maxRows = _ds.Tables["SnacksData"].Rows.Count;
                for (var i = 0; i < _maxRows; i++)
                {
                    var dRow = _ds.Tables["SnacksData"].Rows[i];
                    var snacks = SnacksFactory.getSnacks(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                        dRow.ItemArray.GetValue(1).ToString(),
                        Convert.ToDouble(dRow.ItemArray.GetValue(2)),
                        Convert.ToInt32(dRow.ItemArray.GetValue(3))
                        );


                    SnacksList.Add(snacks);
                }
            }
            catch (Exception excep)
            {
                //MessageBox.Show(excep.Message);  //Anna
                Console.WriteLine(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                // Application.Exit();              /Anna
                //Environment.Exit(0); //Force the application to close
            }
            return SnacksList;
        }
        public List<IHousekeeping> GetAllRoomsToClean()
        {
            var housekeepingList = new List<IHousekeeping>();
            try
            {
                _ds = new DataSet();
                var sql = "SELECT * From Housekeeping";
                _da = new SqlDataAdapter(sql, _con);
                _cb = new SqlCommandBuilder(_da); //Generates
                _da.Fill(_ds, "HousekeepingData");
                _maxRows = _ds.Tables["HousekeepingData"].Rows.Count;
                for (var i = 0; i < _maxRows; i++)
                {
                    var dRow = _ds.Tables["HousekeepingData"].Rows[i];
                    var housekeeping = HousekeepingFactory.getHousekeeping(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                        Convert.ToInt32(dRow.ItemArray.GetValue(1)),
                        dRow.ItemArray.GetValue(2).ToString(),
                        dRow.ItemArray.GetValue(3).ToString(),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(4)),
                        dRow.ItemArray.GetValue(5).ToString()
                        );


                    housekeepingList.Add(housekeeping);
                }
            }
            catch (Exception excep)
            {
                //MessageBox.Show(excep.Message);  //Anna
                Console.WriteLine(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                // Application.Exit();              /Anna
                //Environment.Exit(0); //Force the application to close
            }
            return housekeepingList;
        }

        public void addRoomToClean(int keepingId, int Roomid, string Cleaner, string Description, DateTime DateOfCleaning, string CleaningType)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From Housekeeping";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da);
                da.Fill(ds, "HousekeepingData");
                _maxRows = ds.Tables["HousekeepingData"].Rows.Count;
                var dRow = ds.Tables["HousekeepingData"].NewRow();
                dRow[0] = keepingId;
                dRow[1] = Roomid;
                dRow[2] = Cleaner;
                dRow[3] = Description;
                dRow[4] = DateOfCleaning;
                dRow[5] = CleaningType;
                ds.Tables["HousekeepingData"].Rows.Add(dRow);
                da.Update(ds, "HousekeepingData");

            }

            catch (Exception e)
            {
                if (_con.State.ToString() == "Open")
                    _con.Close();
                MessageBox.Show(e.ToString());

            }
        }

        public bool deleteRoomToCleanFromDB(IHousekeeping room)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From Housekeeping";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "HousekeepingData");
                var findRow = ds.Tables["HousekeepingData"].Rows.Find(room.housekeepingId);
                if (findRow != null)
                    findRow.Delete(); //mark row as deleted
                da.Update(ds, "HousekeepingData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }




        public List<IRoom> GetAllRooms()
        {
            var roomList = new List<IRoom>();
            try
            {
                _ds = new DataSet();
                var sql = "SELECT * From Room";
                _da = new SqlDataAdapter(sql, _con);
                _cb = new SqlCommandBuilder(_da); //Generates
                _da.Fill(_ds, "RoomData");
                _maxRows = _ds.Tables["RoomData"].Rows.Count;
                for (var i = 0; i < _maxRows; i++)
                {
                    var dRow = _ds.Tables["RoomData"].Rows[i];
                    var room = RoomFactory.GetRoom(Convert.ToInt32(dRow.ItemArray.GetValue(0)),
                        dRow.ItemArray.GetValue(1).ToString(),
                        dRow.ItemArray.GetValue(2).ToString(),
                        dRow.ItemArray.GetValue(3).ToString(),
                        Convert.ToInt32(dRow.ItemArray.GetValue(4)
                        ));


                    roomList.Add(room);
                }
            }
            catch (Exception excep)
            {
                //MessageBox.Show(excep.Message);  //Anna
                Console.WriteLine(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                // Application.Exit();              /Anna
                //Environment.Exit(0); //Force the application to close
            }
            return roomList;
        }

        public void UpdateRoomStatusInDb(int roomID)
        {
            var ds = new DataSet();
            var sql = "UPDATE Room SET roomStatus = 'CleaningInProgress' WHERE roomNumber =" + roomID + ";";
            var da = new SqlDataAdapter(sql, _con);
            var cb = new SqlCommandBuilder(da); //Generates
            da.Fill(ds, "RoomData");
        }

        public void UpdateRoomStatusStatusDelete(int RoomId)
        {
            var ds = new DataSet();
            var sql = "UPDATE Room SET roomStatus = 'Available' WHERE roomNumber =" + RoomId + ";";
            var da = new SqlDataAdapter(sql, _con);
            var cb = new SqlCommandBuilder(da); //Generates
            da.Fill(ds, "RoomData");
        }

        public void RemoveDrinkQuantity(int drinkId)
        {
            var ds = new DataSet();
            var sql = "UPDATE Drink SET drinkQty=drinkQty-1 WHERE drinkId=" + drinkId + ";";
            var da = new SqlDataAdapter(sql, _con);
            var cb = new SqlCommandBuilder(da); //Generates
            da.Fill(ds, "DrinkData");
        }
        public void RemoveSnackQuantity(int snackId)
        {
            var ds = new DataSet();
            var sql = "UPDATE Snack SET Quantity=Quantity-1 WHERE SnackId =" + snackId + ";";
            var da = new SqlDataAdapter(sql, _con);
            var cb = new SqlCommandBuilder(da); //Generates
            da.Fill(ds, "SnacksData");
        }

        public void AddDrinkQuantity(string drinkName)
        {
            var ds = new DataSet();
            var sql = "UPDATE Drink SET drinkQty=drinkQty+1 WHERE drinkName ='" + drinkName + "';";
            var da = new SqlDataAdapter(sql, _con);
            var cb = new SqlCommandBuilder(da); //Generates
            da.Fill(ds, "DrinkData");
        }
        public void AddSnackQuantity(string snackName)
        {
            var ds = new DataSet();
            var sql = "UPDATE Snack SET Quantity=Quantity+1 WHERE Name ='" + snackName + "';";
            var da = new SqlDataAdapter(sql, _con);
            var cb = new SqlCommandBuilder(da); //Generates
            da.Fill(ds, "SnacksData");
        }

        public void UpdateRoomStatusToCleanInDb(int roomId)
        {
            var ds = new DataSet();
            var sql = "UPDATE Room SET roomStatus = 'Available' WHERE roomNumber =" + roomId + ";";
            var da = new SqlDataAdapter(sql, _con);
            var cb = new SqlCommandBuilder(da); //Generates
            da.Fill(ds, "RoomData");
        }

        //public List<IMenuItem> MenuItemList { get; set; }

        public void AddNewUserToDb(IUser theUser)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From Users";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "UsersData");
                _maxRows = ds.Tables["UsersData"].Rows.Count;
                var dRow = ds.Tables["UsersData"].NewRow();

                dRow[0] = theUser.UserID;
                dRow[1] = theUser.Name;
                dRow[2] = theUser.Password;
                dRow[3] = theUser.EmployeeNumber;
                dRow[4] = theUser.UserType;
                dRow[5] = theUser.Status;


                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (Exception e3)
            {
                if (_con.State.ToString() == "Open")
                    _con.Close();
                MessageBox.Show(e3.ToString());
                //Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public void AddNewBannedCustomerToDb(string firstName, string lastName, string email, string reasonForBan,
            string photo)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From BannedCustomer";
                SqlDataAdapter da = new SqlDataAdapter(sql, _con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "UsersData");
                int totBannedCustomers = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = totBannedCustomers + 1;
                dRow[1] = firstName;
                dRow[2] = lastName;
                dRow[3] = email;
                dRow[4] = reasonForBan;
                dRow[5] = photo;

                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public void AddSpecialOffer(int id, decimal percent, DateTime startDate, DateTime endDate, string name,
            string description, string state)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From SpecialOffer";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da);
                da.Fill(ds, "OffersData");
                _maxRows = ds.Tables["OffersData"].Rows.Count;
                var dRow = ds.Tables["OffersData"].NewRow();
                dRow[0] = id;
                dRow[1] = percent;
                dRow[2] = startDate;
                dRow[3] = endDate;
                dRow[4] = name;
                dRow[5] = description;
                dRow[6] = state;
                ds.Tables["OffersData"].Rows.Add(dRow);
                da.Update(ds, "OffersData");

            }

            catch (Exception e)
            {
                if (_con.State.ToString() == "Open")
                    _con.Close();
                MessageBox.Show(e.ToString());

            }
        }

        public bool deleteOffer(ISpecialOffer offer)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From SpecialOffer";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "OffersData");
                var findRow = ds.Tables["OffersData"].Rows.Find(offer.Id);
                if (findRow != null)
                    findRow.Delete(); //mark row as deleted
                da.Update(ds, "OffersData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;

        }



        public bool deleteUserFromDB(IUser user)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From Users";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "UsersData");
                var findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                    findRow.Delete(); //mark row as deleted
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }

        public bool deleteBannedCustomerFromDB(IBannedCustomer customer)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From BannedCustomers";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "UsersData");
                var findRow = ds.Tables["UsersData"].Rows.Find(customer.BanId);
                if (findRow != null)
                    findRow.Delete(); //mark row as deleted
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }

        public bool editUserInDB(IUser user)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From Users";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "UsersData");
                var findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow[1] = user.Name;
                    findRow[2] = user.Password;
                    findRow[4] = user.UserType;
                }


                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }

        public bool ReceiveStockOrderInDB(IStockOrder stockOrder)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From StockOrder";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "StockOrderData");
                var findRow = ds.Tables["StockOrderData"].Rows.Find(stockOrder.orderID);
                if (findRow != null)
                {

                    findRow[1] = stockOrder.orderCreated;

                    findRow[3] = stockOrder.orderReceived;
                    findRow[4] = stockOrder.supplierID;
                    findRow[5] = stockOrder.deliverTo;
                    findRow[6] = stockOrder.orderTotal;
                    findRow[7] = stockOrder.status;



                }


                da.Update(ds, "StockOrderData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }

        public bool CheckInDB(IRoom room, IBooking booking)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From Room";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "RoomData");
                var findRow = ds.Tables["RoomData"].Rows.Find(room.RoomNumber);
                if (findRow != null)
                {



                    findRow[3] = room.Status;




                }


                da.Update(ds, "RoomData"); //remove row from database table

                ds = new DataSet();
                sql = "SELECT * From Booking";
                da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "BookingData");
                findRow = ds.Tables["BookingData"].Rows.Find(booking.bookingID
                    );
                if (findRow != null)
                {

                    findRow[9] = booking.paid;
                    findRow[8] = booking.status;
                    findRow[7] = booking.roomNumber;
                    findRow[1] = booking.checkIn;




                }


                da.Update(ds, "RoomData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }

        public bool ReceiveStockOrderItemInDB(IStockOrderItem stockOrderItem)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From StockOrderItem";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "StockOrderItemData");
                var findRow = ds.Tables["StockOrderItemData"].Rows.Find(stockOrderItem.OrderItemID);
                if (findRow != null)
                {



                    findRow[3] = stockOrderItem.Total;

                    findRow[5] = stockOrderItem.QtyReceived;




                }


                da.Update(ds, "StockOrderItemData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }

        public bool UpdateItemInDB(IItem anItem)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From Item";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "ItemData");
                var findRow = ds.Tables["ItemData"].Rows.Find(anItem.ItemID);
                if (findRow != null)
                {



                    findRow[2] = anItem.quantity;






                }


                da.Update(ds, "ItemData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }

        //Deletes item from inventory-Grace
        public bool DeleteItemFromDB(IItem item)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From Item";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "ItemsData");
                var findRow = ds.Tables["ItemsData"].Rows.Find(item.ItemID);
                if (findRow != null)
                    findRow.Delete(); //mark row as deleted
                da.Update(ds, "ItemsData"); //remove row from database table
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }

        public bool AddNewEmployeeToDb(IEmployee employee)
        {
            // Get last Employee ID from Employee Table
            try
            {
                DataSet ds = new DataSet();

                //create new query 
                string sqlQuery = "SELECT TOP 1 * FROM Employee ORDER BY employeeNumber DESC LIMIT 1;";

                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                da.Fill(ds, "EmployeeData");
                _maxRows = ds.Tables["EmployeeData"].Rows.Count;
                var dRow = ds.Tables["EmployeeData"].NewRow();

                dRow[0] = null; // employeeNumber set to null to update seed auto increament in DB
                dRow[1] = employee.employeeCategory;
                dRow[2] = employee.title;
                dRow[3] = employee.firstName;
                dRow[4] = employee.middleName;
                dRow[5] = employee.lastName;
                dRow[6] = employee.dateOfBirth;
                dRow[7] = employee.ppsn;
                dRow[8] = employee.phoneNumber;
                dRow[9] = employee.email;

                Address address = employee.personalAddress;
                dRow[10] = address.addressLine1;
                dRow[11] = address.addressLine2;
                dRow[12] = address.city;
                dRow[13] = address.county;

                dRow[14] = employee.photo;
                dRow[15] = employee.wage;
                dRow[16] = employee.employeeCardNumber;
                dRow[17] = employee.hireDate;

                ds.Tables["EmployeeData"].Rows.Add(dRow);
                da.Update(ds, "EmployeeData");
                return true;
            }
            catch (Exception)
            {
                if (_con.State.ToString() == "Open")
                    _con.Close();
                return false;
            }
        }
        //method to fetch all the employee from the employee table. 
        //When fetched from the DB, the employee details will be stored in a list
        public List<IEmployee> GetAllEmployees()
        {
            var employeesList = new List<IEmployee>();
            try
            {
                var ds = new DataSet();
                const string sql = "SELECT * FROM Employee";
                var da = new SqlDataAdapter(sql, _con);
                new SqlCommandBuilder(da);
                da.Fill(ds, "EmployeeDATA");
                var totalNumRows = ds.Tables["EmployeeDATA"].Rows.Count;

                for (var i = 0; i < totalNumRows; i++)
                {
                    var dRow = ds.Tables["EmployeeDATA"].Rows[i];


                    string title = dRow.ItemArray.GetValue(1).ToString(); // title
                    string firstName = dRow.ItemArray.GetValue(2).ToString(); // firstName
                    string middleName = dRow.ItemArray.GetValue(3).ToString(); // middleName
                    string lastName = dRow.ItemArray.GetValue(4).ToString(); // lastName
                    string phoneNumber = dRow.ItemArray.GetValue(7).ToString(); // phoneNumber
                    string email = dRow.ItemArray.GetValue(8).ToString(); // email

                    Address address = new Address(); // ADDRESS  
                    address.addressLine1 = dRow.ItemArray.GetValue(9).ToString(); // addressLine1
                    address.addressLine2 = dRow.ItemArray.GetValue(10).ToString(); // addressLine2
                    address.city = dRow.ItemArray.GetValue(11).ToString(); // city
                    address.county = dRow.ItemArray.GetValue(12).ToString(); // country

                    int employeeNumber = Convert.ToInt16(dRow.ItemArray.GetValue(0)); // employeeNumber
                    DateTime dob = Convert.ToDateTime(dRow.ItemArray.GetValue(5)); // dateOfBirth
                    string ppsn = dRow.ItemArray.GetValue(6).ToString(); // ppsn
                    double wage = Convert.ToDouble(dRow.ItemArray.GetValue(14)); // wage
                    int employeeCategory = Convert.ToInt16(dRow.ItemArray.GetValue(17)); // employeeCategory
                    int employeeCardNumber = Convert.ToInt16(dRow.ItemArray.GetValue(15)); // employeeCardNumber
                    DateTime hireDate = Convert.ToDateTime(dRow.ItemArray.GetValue(16)); // hireDate
                    string photo = dRow.ItemArray.GetValue(13).ToString(); // photo


                    var employee = EmployeeFactory.GetEmployee(title, firstName, middleName, lastName, phoneNumber,
                        email,
                        address, employeeNumber, dob, ppsn, wage, employeeCategory, employeeCardNumber, hireDate, photo);



                    employeesList.Add(employee);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
            }

            return employeesList;
        }

        // method to setup the menu
        public bool SetupMenu(string itemName, string itemType, double itemPrice, string itemDescrip)
        {
            try
            {
                var ds = new DataSet();
                const string sql1 = "execute SelectAllMenuItems";
                const int itemId = 0;
                var da = new SqlDataAdapter(sql1, _con);
                da = new SqlDataAdapter(sql1, _con);
                var cmb = new SqlCommandBuilder(da);

                da.Fill(ds, "MenuData");

                _maxRows = ds.Tables["MenuData"].Rows.Count;
                var dRow = ds.Tables["MenuData"].NewRow();
                dRow[0] = itemId;
                dRow[1] = itemType;
                dRow[2] = itemPrice;
                dRow[3] = itemName;
                dRow[4] = itemDescrip;

                ds.Tables["MenuData"].Rows.Add(dRow);
                da.Update(ds, "MenuData");
            }
            catch
                (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        //get types in the list
        public List<IMenuItem> PopulateComboboxItemType()
        {
            var menuItemTypeList = new List<IMenuItem>();
            try
            {
                var ds = new DataSet();
                const string sql = "execute SelectMenuItemType";
                var da = new SqlDataAdapter(sql, _con);
                new SqlCommandBuilder(da);
                da.Fill(ds, "MenuItemDATA");
                var totalNumRows = ds.Tables["MenuItemDATA"].Rows.Count;

                for (var i = 0; i < totalNumRows; i++)
                {
                    var dRow = ds.Tables["menuItemDATA"].Rows[i];
                    var menuItemType = RestaurantMenuFactory.GetMenuItemType(dRow.ItemArray.GetValue(0).ToString());

                    menuItemTypeList.Add(menuItemType);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
            }

            return menuItemTypeList;
        }

        public List<IMenuItem> GetMenuItems()
        {
            var menuItemList = new List<IMenuItem>();


            try
            {
                var ds = new DataSet();
                //const string sql1 = "SELECT * FROM  MenuItem";
                const string sql1 = "execute SelectAllMenuItems";
                var da = new SqlDataAdapter(sql1, _con);
                new SqlCommandBuilder(da);
                da.Fill(ds, "MenuItemDATA");
                var totalNumRows = ds.Tables["MenuItemDATA"].Rows.Count;

                for (var i = 0; i < totalNumRows; i++)
                {
                    var dRow = ds.Tables["menuItemDATA"].Rows[i];


                    var menuItem =
                        RestaurantMenuFactory.GetMenuItem(Convert.ToInt32(dRow.ItemArray.GetValue(0).ToString()),
                            dRow.ItemArray.GetValue(1).ToString(),
                            Convert.ToDouble(dRow.ItemArray.GetValue(2).ToString()),
                            dRow.ItemArray.GetValue(3).ToString(), dRow.ItemArray.GetValue(4).ToString());

                    menuItemList.Add(menuItem);
                }
            }

            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
            }

            return menuItemList;
        }

        //Grace
        public bool AddNewSupplierToDB(int supplierID, string name, string phoneNum, string email, string street,
            string city,
            string county, string additionalInfo)
        {
            try
            {
                var ds = new DataSet();
                var sqlQuery = "SELECT * FROM Supplier";

                var da = new SqlDataAdapter(sqlQuery, _con);
                da = new SqlDataAdapter(sqlQuery, _con);
                var cb = new SqlCommandBuilder(da);

                da.Fill(ds, "SupplierData");
                _maxRows = ds.Tables["SupplierData"].Rows.Count;
                var dRow = ds.Tables["SupplierData"].NewRow();
                dRow[0] = supplierID;
                dRow[1] = name;
                dRow[2] = phoneNum;
                dRow[3] = email;
                dRow[4] = street;
                dRow[5] = city;
                dRow[6] = county;
                dRow[7] = additionalInfo;


                ds.Tables["SupplierData"].Rows.Add(dRow);
                da.Update(ds, "SupplierData");
                return true;
            }
            catch (Exception)
            {
                if (_con.State.ToString() == "Open")
                    _con.Close();
                return false;
            }
        }

        public List<ISupplier> getAllSuppliers()
        {
            List<ISupplier> SupplierList = new List<ISupplier>();
            try
            {
                var ds = new DataSet();
                string sql = "SELECT * From Supplier";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "SupplierData");
                totSuppliers = ds.Tables["SupplierData"].Rows.Count;
                for (int i = 0; i < totSuppliers; i++)
                {
                    DataRow dRow = ds.Tables["SupplierData"].Rows[i];
                    ISupplier supplier =
                        SupplierFactory.GetSupplier(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                            dRow.ItemArray.GetValue(1).ToString(),
                            dRow.ItemArray.GetValue(2).ToString(),
                            dRow.ItemArray.GetValue(3).ToString(),
                            dRow.ItemArray.GetValue(4).ToString(),
                            dRow.ItemArray.GetValue(5).ToString(),
                            dRow.ItemArray.GetValue(6).ToString(),
                            dRow.ItemArray.GetValue(7).ToString());

                    SupplierList.Add(supplier);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return SupplierList;
        }

        //Populate items list-Grace
        //public List<IItem> GetAllItems()
        //{
        //    List<IItem> itemList = new List<IItem>();
        //    try
        //    {
        //        var ds = new DataSet();
        //        string sql = "SELECT * From Item";
        //        var da = new SqlDataAdapter(sql, _con);
        //        var cb = new SqlCommandBuilder(da); //Generates
        //        da.Fill(ds, "ItemData");
        //        _totItems = ds.Tables["ItemData"].Rows.Count;
        //        for (int i = 0; i < _totItems; i++)
        //        {
        //            DataRow dRow = ds.Tables["ItemData"].Rows[i];
        //            IItem item = ItemFactory.GetItem(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
        //                dRow.ItemArray.GetValue(1).ToString(),
        //                Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()),
        //                Convert.ToDouble(dRow.ItemArray.GetValue(3).ToString()),
        //                Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString())
        //            );

        //            itemList.Add(item);
        //        }
        //    }
        //    catch (System.Exception excep)
        //    {
        //        MessageBox.Show(excep.Message);
        //        if (_con.State.ToString() == "Open")
        //            _con.Close();
        //        Application.Exit();
        //        //Environment.Exit(0); //Force the application to close
        //    }
        //    return itemList;
        //}

        public bool CheckOutDB(IRoom room, IBooking booking, IExtraCharge extraCharge)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From Room";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "RoomData");
                var findRow = ds.Tables["RoomData"].Rows.Find(room.RoomNumber);
                if (findRow != null)
                {



                    findRow[3] = room.Status;




                }


                da.Update(ds, "RoomData"); //remove row from database table

                ds = new DataSet();
                sql = "SELECT * From Booking";
                da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "BookingData");
                findRow = ds.Tables["BookingData"].Rows.Find(booking.bookingID
                    );
                if (findRow != null)
                {


                    findRow[8] = booking.status;

                    string sqlFormattedDate = booking.checkOut.ToString("yyyy-MM-dd HH:mm:ss");
                    findRow[1] = sqlFormattedDate;




                }


                da.Update(ds, "BookingData"); //remove row from database table

                ds = new DataSet();
                sql = "SELECT * From ExtraCharge";
                da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "ChargeData");
                findRow = ds.Tables["ChargeData"].Rows.Find(extraCharge.chargeID
                    );
                if (findRow != null)
                {

                    findRow[3] = extraCharge.chargeStatus;
                }


                da.Update(ds, "ChargeData"); //remove row from database table


            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (GetConnection().ToString() == "Open")
                    CloseConnection();
                Application.Exit();
            }
            return true;
        }

        public List<IBooking> GetAllBookings()
        {
            List<IBooking> bookingList = new List<IBooking>();
            try
            {
                var ds = new DataSet();
                string sql = "SELECT * From Booking";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "BookingData");
                _totItems = ds.Tables["BookingData"].Rows.Count;
                for (int i = 0; i < _totItems; i++)
                {
                    DataRow dRow = ds.Tables["BookingData"].Rows[i];
                    IBooking booking = BookingFactory.GetBooking(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(2).ToString()),
                        Convert.ToInt32(dRow.ItemArray.GetValue(3).ToString()),
                        Convert.ToDouble(dRow.ItemArray.GetValue(4).ToString()),
                        Convert.ToInt32(dRow.ItemArray.GetValue(5).ToString()),
                        (dRow.ItemArray.GetValue(8).ToString()),
                        (dRow.ItemArray.GetValue(9).ToString()),
                        Convert.ToInt16(dRow.ItemArray.GetValue(7).ToString())
                    );

                    //  bookingList.Add(booking);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return bookingList;
        }

        public List<IGuest> GetAllGuests()
        {
            List<IGuest> guestList = new List<IGuest>();
            try
            {
                var ds = new DataSet();
                string sql = "SELECT * From Guest";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "GuestData");
                _totItems = ds.Tables["GuestData"].Rows.Count;
                for (int i = 0; i < _totItems; i++)
                {
                    DataRow dRow = ds.Tables["GuestData"].Rows[i];
                    IGuest guest = GuestFactory.GetGuest(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                        (dRow.ItemArray.GetValue(1).ToString()),
                        (dRow.ItemArray.GetValue(2).ToString()),
                        (dRow.ItemArray.GetValue(3).ToString()),
                        (dRow.ItemArray.GetValue(4).ToString()),
                        (dRow.ItemArray.GetValue(5).ToString()),
                        (dRow.ItemArray.GetValue(6).ToString()),
                        (dRow.ItemArray.GetValue(7).ToString())
                    );

                    guestList.Add(guest);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return guestList;
        }

        //
        //   update employee details 
        //

        public bool UpdateEmployeeDetails(IEmployee Employee)
        {
            try
            {
                var ds = new DataSet();
                string sql1 = "SELECT * FROM Employee";


                var da = new SqlDataAdapter(sql1, _con);
                da = new SqlDataAdapter(sql1, _con);
                var cmb = new SqlCommandBuilder(da);

                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                da.Fill(ds, "EmployeeData");

                DataRow findRow = ds.Tables["EmployeeData"].Rows.Find(Employee.employeeNumber);

                if (findRow != null)
                {
                    findRow[2] = Employee.firstName;
                    findRow[3] = Employee.middleName;
                    findRow[4] = Employee.lastName;
                    findRow[7] = Employee.phoneNumber;
                    findRow[8] = Employee.email;
                    findRow[9] = Employee.personalAddress.addressLine1;
                    findRow[10] = Employee.personalAddress.addressLine2;
                    findRow[11] = Employee.personalAddress.city;
                    findRow[12] = Employee.personalAddress.county;
                    findRow[14] = Employee.employeeCardNumber;
                    findRow[17] = Employee.employeeCategory;


                }
                da.Update(ds, "EmployeeData");
            }
            catch (Exception ex)
            {
                MessageBox.Show("UPDATE EMPLOYEE: " + ex.Message);
                return false;
            }


            return true;
        }
        //
        //method to update an item in the database
        //
        public bool UpdateMenuItem(IMenuItem menuItem)
        {
            try
            {
                //SELECT * FROM menuItem

                const string sql1 = "execute SelectAllMenuItems";
                var ds = new DataSet();
                const int itemId = 0;
                var da = new SqlDataAdapter(sql1, _con);
                da = new SqlDataAdapter(sql1, _con);
                var cmb = new SqlCommandBuilder(da);

                da.Fill(ds, "MenuData");

                _maxRows = ds.Tables["MenuData"].Rows.Count;
                var dRow = ds.Tables["MenuData"].NewRow();
                dRow[0] = itemId;
                dRow[1] = menuItem.ItemType;
                dRow[2] = menuItem.ItemPrice;
                dRow[3] = menuItem.ItemName;
                dRow[4] = menuItem.ItemDescription;

                ds.Tables["MenuData"].Rows.Add(dRow);
                da.Update(ds, "MenuData");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


            return true;
        }

        //method to delete an item in the database
        public bool DeletMenuItem(IMenuItem menuItem)
        {
            try
            {
                var ds = new DataSet();
                string sql = "execute SelectAllMenuItems";
                var da = new SqlDataAdapter(sql, _con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                var cb = new SqlCommandBuilder(da); //Generates
                da.Fill(ds, "MenuData");
                var findRow = ds.Tables["MenuData"].Rows.Find(menuItem.MenuItemID);

                findRow?.Delete(); //mark row as deleted
                ds.Tables["MenuData"].Rows[0].Delete();

                da.Update(ds, "MenuData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);

            }
            return true;
        }
        //
        //Method to get the available rooms from the DB
        //
        public List<IRoom> DisplayAvailableRooms()
        {
            var roomsList = new List<IRoom>();
            try
            {
                var ds = new DataSet();
                var sql = "select * from hotelCapacity";
                var da = new SqlDataAdapter(sql, _con);


                var cb = new SqlCommandBuilder(da); //Generates


                da.Fill(ds, "RoomData");
                _totItems = ds.Tables["RoomData"].Rows.Count;



                for (var i = 0; i < _totItems; i++)
                {
                    var dRow = ds.Tables["RoomData"].Rows[i];
                    var room = RoomFactory.GetAvailableRomm(Convert.ToInt32(dRow.ItemArray.GetValue(0).ToString()),
                                                            Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()),
                                                            Convert.ToInt32(dRow.ItemArray.GetValue(2).ToString()),
                                                            Convert.ToInt32(dRow.ItemArray.GetValue(3).ToString()),
                                                            Convert.ToInt32(dRow.ItemArray.GetValue(4).ToString()));

                    roomsList.Add(room);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
             //   Application.Exit();

            }


            return roomsList;
        }
        //
        //Method to fetch all the drinks from the drinks table
        //
        public List<IDrink> GetAlDrinks()
        {
            var drinkList = new List<IDrink>();


            try
            {
                var ds = new DataSet();
                var sql = "select * from Drink";
                var da = new SqlDataAdapter(sql, _con);


                var cb = new SqlCommandBuilder(da); //Generates


                da.Fill(ds, "DrinkData");
                _totItems = ds.Tables["DrinkData"].Rows.Count;



                for (var i = 0; i < _totItems; i++)
                {
                    var dRow = ds.Tables["DrinkData"].Rows[i];
                    var drink = DrinkFactory.getDrink(Convert.ToInt32(dRow.ItemArray.GetValue(0).ToString()),
                        dRow.ItemArray.GetValue(1).ToString(),
                        dRow.ItemArray.GetValue(2).ToString(),
                        Convert.ToDouble(dRow.ItemArray.GetValue(3).ToString()),
                        Convert.ToInt32(dRow.ItemArray.GetValue(4).ToString()));

                    drinkList.Add(drink);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (_con.State.ToString() == "Open")
                    _con.Close();
                Application.Exit();

            }



            return drinkList;
        }

        public bool EditUserInDb(IUser user)
        {
            throw new NotImplementedException();
        }


        //
        //  send order to the kitchen method
        //
        public bool Order(string ticketNum, double totalBalance)

        {

            try
            {

                var ds2 = new DataSet();
                const string sql2 = "SELECT * FROM Restaurant_Order";

                var da2 = new SqlDataAdapter(sql2, _con);
                da2 = new SqlDataAdapter(sql2, _con);
                var cmb2 = new SqlCommandBuilder(da2);

                da2.Fill(ds2, "OrderData");
                _maxRows = ds2.Tables["OrderData"].Rows.Count;
                var dRow2 = ds2.Tables["OrderData"].NewRow();

                dRow2[0] = ticketNum;
                dRow2[1] = totalBalance;
                dRow2[2] = false;


                ds2.Tables["OrderData"].Rows.Add(dRow2);
                da2.Update(ds2, "OrderData");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;

        }

        public void InsertBarOrder(int Orderid, DateTime orderTime, string orderItems, double orderPrice, int orderQuantity, double orderChange)
        {
            try
            {
                var ds = new DataSet();
                var sql = "SELECT * From BarOrder";
                var da = new SqlDataAdapter(sql, _con);
                var cb = new SqlCommandBuilder(da);
                da.Fill(ds, "BarOrderData");
                _maxRows = ds.Tables["BarOrderData"].Rows.Count;
                var dRow = ds.Tables["BarOrderData"].NewRow();
                dRow[0] = Orderid;
                dRow[1] = orderTime;
                dRow[2] = orderItems;
                dRow[3] = orderPrice;
                dRow[4] = orderQuantity;
                dRow[5] = orderChange;
                ds.Tables["BarOrderData"].Rows.Add(dRow);
                da.Update(ds, "BarOrderData");

            }

            catch (Exception e)
            {
                if (_con.State.ToString() == "Open")
                    _con.Close();
                MessageBox.Show(e.ToString());

            }
        }

        public void updateOrderStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserFromDb(IUser user)
        {
            throw new NotImplementedException();
        }

        public List<IExtraCharge> GetAllExtraCharges()
        {
            throw new NotImplementedException();
        }
    }
}