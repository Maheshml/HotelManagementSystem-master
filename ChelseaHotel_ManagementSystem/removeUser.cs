using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessEntities;
using BusinessLayer;

namespace ChelseaHotel_ManagementSystem
{
    public partial class removeUser : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Instance Properties

        #endregion

        public removeUser(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        public removeUser() { }


        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView_User.CurrentCell.RowIndex;
            int columnindex =  dataGridView_User.CurrentCell.ColumnIndex;

            int userId = Convert.ToInt32(dataGridView_User.Rows[rowindex].Cells[columnindex].Value.ToString());
            if (MessageBox.Show("Delete " + userId + " ? ", "Are you sure !", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            return;
            foreach (User user in Model.UserList)
            {

                if (user.UserID == userId)
                {
                    Model.DeleteUser(user);                    break;
                }
            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            foreach (User user in Model.UserList)
            {
                    string[] row1 = new string[] {user.UserID.ToString(),user.Name,user.EmployeeNumber.ToString()  };
                    dataGridView_User.Rows.Add(row1);
                }
            }
        }
    }

