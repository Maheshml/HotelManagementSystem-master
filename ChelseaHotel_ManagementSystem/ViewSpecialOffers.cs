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
    public partial class ViewSpecialOffers : Form
    {
        IModel model;
        mainContainer mc;
        public ViewSpecialOffers(mainContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            mc = parent;
            this.model = model;
            panel3.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - panel3.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - panel3.Height) / 2);
        }

        private void ViewSpecialOffers_Load(object sender, EventArgs e)
        {
            model.PopulateOfferList();
            foreach (SpecialOffer offer in model.SpecialOfferList)
            {
                string[] row1 = new string[] { offer.id.ToString(), offer.discount.ToString(), offer.startDate.ToString(), offer.endDate.ToString(), offer.Name, offer.description, offer.state };
                dataGridView_SpecialOffers.Rows.Add(row1);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView_SpecialOffers.CurrentCell.RowIndex;
            int columnindex = dataGridView_SpecialOffers.CurrentCell.ColumnIndex;

            int offerId = Convert.ToInt32(dataGridView_SpecialOffers.Rows[rowindex].Cells[columnindex].Value.ToString());

            if (MessageBox.Show("Delete " + offerId + " ? ", "Are you sure !", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            foreach (SpecialOffer offer in model.SpecialOfferList)
            {

                if (offer.id == offerId)
                {
                    model.DeleteOffer(offer);
                    break;
                }

            }
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            addSpecialOffer so = new addSpecialOffer(mc,model);
            so.Show();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            this.dataGridView_SpecialOffers.DataSource = null;
            this.dataGridView_SpecialOffers.Rows.Clear();
            foreach (SpecialOffer offer in model.SpecialOfferList)
            {
                string[] row1 = new string[] { offer.id.ToString(), offer.discount.ToString(), offer.startDate.ToString(), offer.endDate.ToString(), offer.Name, offer.description, offer.state };
                dataGridView_SpecialOffers.Rows.Add(row1);
            }

        }

        private void label_TitleAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new addSpecialOffer(mc, model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
