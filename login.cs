using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace myFirstApp
{
    public partial class login : Form
    {
        bool isAdmin;
        startPage stPage;

        public login(bool b, startPage sPage)
        {
            InitializeComponent();
             isAdmin =b;
            stPage = sPage;
            stPage.Hide();

            if (isAdmin)
            {
                lableName.Text = "login as Admin";
            }
            else
            {
                lableName.Text = "login as Garage";
            }


           
        }

        private void button1_Click(object sender, EventArgs e)  //login button click
        {
            int ID=0;
            string password = textPassword.Text;

            try {
                ID = int.Parse(txtUserName.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

            if (isAdmin) //check admin details
            {
                MySqlDataReader loginDetails =   DB.readQuery("select adminID, password from admin where adminID = "+ID+" and password= '"+password+"'");
                if (loginDetails.HasRows)
                {
                    MessageBox.Show("user found");
                }
                else
                {
                    MessageBox.Show("user not found");
                }
            }
            else //check garage details
            {
                MySqlDataReader loginDetails = DB.readQuery("select garageID, password from garage where garageID = " + ID + " and password= '" + password + "'");
                if (loginDetails.HasRows)
                {
                    MessageBox.Show("user found");
                }
                else
                {
                    MessageBox.Show("user not found");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)//back
        {
            this.Close();
            stPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)//exit
        {
            stPage.Close();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e) //controlling user input from ID field
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("you can only input digits");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
