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
            //stPage.Hide();

            if (isAdmin)
            {
                bunifuLable_topic.Text = "    ADMIN";
            }
            else
            {
                bunifuLable_topic.Text = "MECHANIST";
                bunifuPictureBox.Image = Properties.Resources.download1;

                
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


        //loggin button clicked
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string password = bunifuTxt_Password.Text;

            try
            {
                ID = int.Parse(bunifuTxt_ID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            if (isAdmin) //check admin details
            {
                using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                {
                    int rows = db.admins.Where(x => x.adminID == ID ^ x.password == password).Count();
                    if (rows > 0)
                    {
                        MessageBox.Show("user found");
                        adminPage ap = new adminPage();
                        this.Close();
                        ap.Show();
                    }
                    else
                    {
                        MessageBox.Show("user not found");
                    }

                }

            }
            else //check garage details
            {
                mechanistPage mp = new mechanistPage();
                mp.Show();
            }
        }
    }
}
