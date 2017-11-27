using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;
using System;

namespace ChelseaHotel_ManagementSystem
{
    public partial class checkIn : Form
    {
        #region Instance Attributes
        private IModel Model;
        mainContainer mc;


        #endregion

        #region Instance Properties

        #endregion


        #region Constructors
        public checkIn(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        string roomType;
        string roomStatus;
        int bookingID;
        bool isPaid;
        int roomNumber;
        bool check;

        #endregion

        private void checkIn_Load(object sender, EventArgs e)
        {
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;

            Model.PopulateBookingList();
            Model.PopulateGuestList();
            
            foreach(Booking aBooking in Model.BookingList)
            {
                if ((aBooking.checkIn == date) && (aBooking.status == "Booked"))
                {
                    foreach (Guest aGuest in Model.GuestList)
                    {
                        if ((aBooking.guestID == aGuest.guestID))
                        {
                            bookings.Rows.Add(aBooking.bookingID, aGuest.firstName, aGuest.surname, aBooking.checkIn.ToString("dd/MM/yyyy"), aBooking.checkOut.ToString("dd/MM/yyyy"), aGuest.street, aGuest.city, aGuest.country, aBooking.noOfGuests);
                        }
                    }
                }

                
            }
        }

        private void bookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           rooms.Rows.Clear();

            int noOfGuests = Convert.ToInt32(bookings.Rows[e.RowIndex].Cells[8].Value);
            bookingID= Convert.ToInt32(bookings.Rows[e.RowIndex].Cells[0].Value);

            foreach(Booking aBooking in Model.BookingList)
            {
                if(aBooking.bookingID==bookingID)
                {
                    amountDue.Text = aBooking.totalCost.ToString();
                    if(aBooking.paid=="Yes")
                    {
                        isPaid = true;
                    }

                    else if(aBooking.paid=="No")
                    {
                        isPaid = false;
                    }
                }

                
            }

            switch (noOfGuests)
            {
                case 1:
                    roomType = "single";
                    break;
                case 2:
                    roomType = "double";
                    break;
                case 3:
                    roomType = "suite";
                    break;
                case 4:
                    roomType = "suite";
                    break;
            }

            Model.PopulateRoomList();

            foreach(Room aRoom in Model.RoomList)
            {
                if(aRoom.RoomType==roomType && aRoom.Status!="Occupied")
                {
                    rooms.Rows.Add(aRoom.RoomNumber, aRoom.RoomType, aRoom.Status, aRoom.FloorNumber);
                    
                }
            }

            roomStatus = rooms.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (roomStatus != "Available")
            {
                MessageBox.Show("This room has a status of " + roomStatus + ", try again later or select another room");
            }

        }

        private void rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomStatus= rooms.Rows[e.RowIndex].Cells[2].Value.ToString();
           roomNumber = Convert.ToInt32(rooms.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (roomStatus!="Available")
            {
                MessageBox.Show("This room has a status of " + roomStatus + ", try again later or select another room");
            }

        }

       

        private void rooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void checkin_btn_Click_1(object sender, EventArgs e)
        {

            if (bookings.SelectedCells.Count == 0)
            {
                MessageBox.Show("No booking selected");
            }

            else if (rooms.SelectedCells.Count == 0)
            {
                MessageBox.Show("No room selected");
            }

            else if (roomStatus != "Available")
            {
                MessageBox.Show("This room has a status of " + roomStatus + ", try again later or select another room");
            }

            else
            {

                if (paid.Checked == false)
                {
                    MessageBox.Show("Booking must be paid for on check in");
                }

                else if (paid.Checked == true)
                {

                    foreach (Booking aBooking in Model.BookingList)
                    {
                        if (aBooking.bookingID == bookingID)
                        {
                            aBooking.paid = "Yes";
                            aBooking.status = "Checked In";
                            aBooking.roomNumber = roomNumber;
                            aBooking.checkIn = DateTime.Now;

                            foreach (Room aRoom in Model.RoomList)
                            {
                                if (aRoom.RoomNumber == roomNumber)
                                {
                                    aRoom.Status = "Occupied";

                                    check = Model.CheckIn(aRoom, aBooking);
                                }
                            }

                            if (check == true)
                            {
                                MessageBox.Show("Check in successful");
                            }
                        }
                    }
                }
            }
        }

        private void cancel_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
