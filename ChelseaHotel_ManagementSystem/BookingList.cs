using System;
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

namespace ChelseaHotel_ManagementSystem
{
    public partial class BookingList : Form
    {
        IModel Model;
        mainContainer mc;
        public BookingList(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        private void BookingList_Load(object sender, EventArgs e)
        {
            Model.PopulateBookingList();
            Model.PopulateGuestList();
            foreach (Booking booking in Model.BookingList)
            {
                foreach (Guest guest in Model.GuestList)
                {
                    if (booking.guestID == guest.guestID)
                    {
                        string[] row1 = new string[] { booking.bookingID.ToString(), booking.checkIn.ToString(), booking.checkOut.ToString(), booking.noOfGuests.ToString(), guest.firstName, guest.surname };
                        dataGridView_Bookings.Rows.Add(row1);
                    }
                }
            }
        }
    }


    }

