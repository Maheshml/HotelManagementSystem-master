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
    public partial class AddRoomToHousekeeping : Form
    {
        #region Instance Attributes
        private IModel Model;
        mainContainer mc;
        #endregion

        #region Instance Properties

        #endregion
        public AddRoomToHousekeeping(mainContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        private void groupBox_AddRoom_Enter(object sender, EventArgs e)
        {

        }

        private void label_TitleAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void AddRoomToHousekeeping_Load(object sender, EventArgs e)
        {
            Model.PopulateRoomList();
            foreach (Room room in Model.RoomList)
            {
                if (room.Status == "CleaningRequired")
                    comboBox_Room.Items.Add(room.RoomNumber);
            }
        }

       

        private void dateTimePicker_CleaningDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new ViewRoomsToClean(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void button_Submit_Click_1(object sender, EventArgs e)
        {
            int HousekeepingId = 0;
            foreach (Housekeeping house in Model.HousekeepingList)
            {
                HousekeepingId++;
            }
            if (HousekeepingId == 0)
            {
                HousekeepingId = 1;
            }
            else
                HousekeepingId += 1;
            int Roomid = Convert.ToInt32(comboBox_Room.SelectedItem.ToString());
            string Cleaner = comboBox_Cleaner.SelectedItem.ToString();
            string Description = textBox_Description.Text;
            DateTime cDate = Convert.ToDateTime(dateTimePicker_CleaningDate.Value.ToString("yyyy-MM-dd"));
            string CleaningType = comboBox_CleaningType.SelectedItem.ToString();

            bool Result = Model.addRoomToHouseKeeping(HousekeepingId, Roomid, Cleaner, Description, cDate, CleaningType);

            if (Result == true)
            {
                MessageBox.Show("Room will be cleaned");
            }
            else
            {
                MessageBox.Show("Can't clean this room");
            }

            Model.UpdateRoomStatus(Roomid);
        }
    }
}
