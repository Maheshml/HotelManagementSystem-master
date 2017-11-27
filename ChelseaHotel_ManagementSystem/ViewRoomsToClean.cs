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
    public partial class ViewRoomsToClean : Form
    {
        #region Instance Attributes
        private IModel Model;
        mainContainer mc;
        #endregion

        #region Instance Properties

        #endregion
        public ViewRoomsToClean(mainContainer parent,IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.Model = Model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_AddRoom_Click(object sender, EventArgs e)
        {

        }

        private void Housekeeping_Load(object sender, EventArgs e)
        {
                Model.PopulateHousekeepingList();
                foreach (Housekeeping house in Model.HousekeepingList)
                {
                string[] row1 = new string[] { house.housekeepingId.ToString(), house.Roomid.ToString(), house.Cleaner, house.Description, house.dateOfCleaning.ToString(), house.typeOfCleaning.ToString() };
                dataGridView_Housekeeping.Rows.Add(row1);
            }

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView_Housekeeping.CurrentCell.RowIndex;
            int columnindex = dataGridView_Housekeeping.CurrentCell.ColumnIndex;

            int roomId = Convert.ToInt32(dataGridView_Housekeeping.Rows[rowindex].Cells[columnindex].Value.ToString());

            //int roomId = Convert.ToInt32(dataGridView_Housekeeping.Rows[0].Cells[0].FormattedValue.ToString());

            if (MessageBox.Show("Delete " + roomId + " ? ", "Are you sure !", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            foreach (Housekeeping house in Model.HousekeepingList)
            {

                if (house.housekeepingId == roomId)
                {
                    Model.DeleteRoomToClean(house);
                    Model.UpdateRoomStatusStatusDelete(roomId);
                    break;
                }
            }
            Model.UpdateRoomStatusToClean(roomId);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView_Housekeeping.DataSource = null;
            this.dataGridView_Housekeeping.Rows.Clear();
            foreach (Housekeeping house in Model.HousekeepingList)
            {
                string[] row1 = new string[] { house.housekeepingId.ToString(), house.Roomid.ToString(), house.Cleaner, house.Description, house.dateOfCleaning.ToString(), house.typeOfCleaning.ToString() };
                dataGridView_Housekeeping.Rows.Add(row1);
            }
        }

        private void label_TitleAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new AddRoomToHousekeeping(mc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
