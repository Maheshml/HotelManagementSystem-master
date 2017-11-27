using BusinessLayer;
using System;
using System.Windows.Forms;

namespace ChelseaHotel_ManagementSystem
{
    public partial class viewListOfAvailableRooms : Form
    {
        #region Instance Attributes    

        private IModel Model;
        mainContainer mc;


        #endregion


        public viewListOfAvailableRooms(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;

            //initialize the form with the add booking option not visible
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
            bookRoom_btn.Visible = false;



        }


        private void addRoom_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addRoom = new addRoom();
            addRoom.ShowDialog();
        }



        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var fromDate = dateTimePickerFromDate.Value;
            var toDate = dateTimePickerToDate.Value;
            try {

                foreach (var availableRoom in Model.AvailableRoomList)
                {
                    var totalCapacity = availableRoom.SingleRoomC + availableRoom.DoubleRoomC + availableRoom.SuitRoomC; //var to hold the total of capacity


                    if ((availableRoom.AvailableDate >= fromDate) && (availableRoom.AvailableDate <= toDate))
                    {
                        availableRoomsDatagridView.Rows.Add(
                            availableRoom.AvailableDate.Year + "-" + availableRoom.AvailableDate.Month + "-" +
                            availableRoom.AvailableDate.Day, availableRoom.SingleRoomC.ToString(),
                            availableRoom.DoubleRoomC.ToString(),
                            availableRoom.SuitRoomC.ToString(), totalCapacity.ToString());

                    }
                    //if hotel has any available capacity between the give the booking button to visible do the user can book a room
                    if (availableRoomsDatagridView.Rows.Count > 0)
                        bookRoom_btn.Visible = true;


                }
            } catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            var form = new DashboardGeneralManager(mc, Model);
            this.Hide();
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void bookRoom_btn_Click(object sender, EventArgs e)
        {
            var form = new addBooking(mc, Model);
            this.Hide();
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
    }




