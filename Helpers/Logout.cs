using BusinessLayer;
using ChelseaHotel_ManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpers
{
    public class Logout
    {

        #region Instance Attributes
        private IModel Model;
        mainContainer mc;
        #endregion

        public Logout(mainContainer mc, IModel Model)
        {
            
            Login formLogin = new Login(Model);

            formLogin.ShowDialog();

            int currentUserType = Model.getUserTypeForCurrentUser();

            switch (currentUserType)
            {
                case 1:
                //System Administrator

                case 2:
                    //General Manager               
                    ManagmentBoard form2 = new ManagmentBoard(mc, Model); // All forms get passed the formContainer and a reference to the model object. 
                                                                          //this.Text = this.Text + "-Manager";
                    form2.Dock = DockStyle.Fill;
                    form2.Show();
                    break;
                case 3:
                    //Receptionist
                    ReceptionistBoard form3 = new ReceptionistBoard(mc, Model);
                    form3.Dock = DockStyle.Fill;
                    form3.Show();
                    break;
                case 4:
                    //Kitchen Manager
                    break;
                case 5:
                    // Kitchen Staff
                    break;
                case 6:
                    // Bar Manager
                    break;
                case 7:
                    // Bar Staff
                    break;
                case 8:
                // Restaurant Staff

                default:
                    //Logo
                    //ManagmentBoard form2 = new ManagmentBoard(this, Model); // All forms get passed the formContainer and a reference to the model object. 
                    //this.Text = this.Text + "-Manager";
                    //form2.Dock = DockStyle.Fill;
                    //form2.Show();

                    break;

            }
        }
    }
}