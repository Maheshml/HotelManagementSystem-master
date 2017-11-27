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
    public partial class checkOut : Form
    {
        #region Instance Attributes
        private IModel Model;
        mainContainer mc;


        #endregion

        #region Instance Properties

        #endregion


        #region Constructors
        public checkOut(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);

        }

        string roomType;
        string roomStatus;
        int thebookingID;
        bool isPaid;
        int roomNumber;
        bool check;
        double theTotal = 0;
       

       

        #endregion

        private void checkOut_Load(object sender, EventArgs e)
        {
            Model.PopulateBookingList();
            Model.PopulateGuestList();
            

            foreach (Booking aBooking in Model.BookingList)
            {
                if (aBooking.status == "Checked In")
                {
                   foreach(Guest aGuest in Model.GuestList)
                    {
                        if(aGuest.guestID==aBooking.guestID)
                        {
                            
                            bookings.Rows.Add(aBooking.bookingID, aGuest.firstName, aGuest.surname, aBooking.roomNumber, aBooking.checkIn, aBooking.checkOut);
                            
                            
                        }
                    }

                }

            }

        }

        private void bookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            extracharges.Rows.Clear();
            
            
            thebookingID = Convert.ToInt32(bookings.Rows[e.RowIndex].Cells[0].Value);
            roomNumber= Convert.ToInt32(bookings.Rows[e.RowIndex].Cells[3].Value);

         //   Model.PopulateExtraChargeList();

            //foreach(ExtraCharge aExtraCharge in Model.ExtraChargeList)
            //{
            //    if(thebookingID==aExtraCharge.bookingChargeID)
            //    {
            //        extracharges.Rows.Add(aExtraCharge.chargeType, aExtraCharge.chargeAmount);
            //        theTotal = aExtraCharge.chargeAmount;
                   
            //    }
            //}


            total.Text = theTotal.ToString();
            
        }

        

      

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (extracharges.Rows.Count > 0)
            {
                if (!paidCheck.Checked)
                {
                    MessageBox.Show("Extra charges must be paid for");
                }

                else
                {
                    foreach (Room aRoom in Model.RoomList)
                    {
                        if (aRoom.RoomNumber == roomNumber)
                        {
                            aRoom.status = "Available";
                        }


                        foreach (Booking aBooking in Model.BookingList)
                        {
                            if (aBooking.bookingID == thebookingID)
                            {
                                aBooking.status = "Checked Out";
                                aBooking.checkOut = DateTime.Now;

                                //foreach (ExtraCharge aExtraCharge in Model.ExtraChargeList)
                                //{
                                //    if (aExtraCharge.bookingChargeID == thebookingID)
                                //    {
                                //        aExtraCharge.chargeStatus = "Paid";
                                //        Model.CheckOut(aRoom, aBooking, aExtraCharge);
                                //    }
                                //}
                            }
                        }
                    }
                }

                int rowIndex = extracharges.CurrentCell.RowIndex;
                extracharges.Rows.RemoveAt(rowIndex);
                rowIndex = bookings.CurrentCell.RowIndex;
                bookings.Rows.RemoveAt(rowIndex);

                MessageBox.Show("Checkout successful");


            }

            else
            {

            }
        }

        private void cancel_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
