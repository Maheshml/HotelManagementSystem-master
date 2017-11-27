using BusinessLayer;
using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{

    static class Program
    {
        public static mainContainer c;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDataLayer _Datalayer = DataLayer.GetInstance(); // DataLayer object is a singleton, only 1 instance allowed. With Singleton pattern use GetInstance() method to create it.
            IModel _Model = Model.GetInstance(_Datalayer); // Model object is a singleton, only 1 instance allowed. With Singleton pattern use GetInstance() method to create it.


            //Application.Exit();

            //http://stackoverflow.com/questions/29157970/winforms-flickers-when-loading-on-windows-8-1
          Application.Run(new mainContainer(_Model));
           // Application.Run(new setUpMenu(c, _Model));
       //   Application.Run(new sendOrdercsToKitchen(_Model));
    //Application.Run(new ModifyEmplyeeDetails(_Model));
               //   Application.Run(new ViewOrderInKitchen());
            //Application.Run(new getReport());
            //Application.Run(new addSupplier(_Model));
         //  Application.Run(new addStockOrder(c, _Model));
            //Application.Run(new editUser(_Model));
            //Application.Run(new RestaurantKitchenManagerAdminPanel());
            //Application.Run(new DisplayListOfAvailableRooms());
            //Application.Run(new checkIn(_Model));
        }
    }
}