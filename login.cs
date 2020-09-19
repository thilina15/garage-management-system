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

        public login(bool b,startPage st)
        {
            InitializeComponent();
            isAdmin =b;
            stPage = st;

            if (isAdmin)
            {
                bunifuCustomLabel1.Text = "    ADMIN";
            }
            else
            {
                bunifuCustomLabel1.Text = "MECHANIST";

                
            }


           
        }

        //login click
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

            //saving input details
            string userName = txtUserName.Text;
            string password = textPassword.Text;
            try
            {
                using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                {
                    //get effected rows
                    int n = db.users.Where(x => x.password == password && x.name == userName && x.isAdmin == isAdmin).Count();
                    if (n > 0)//has rows
                    {
                        if (isAdmin)
                        {
                            adminPage ad = new adminPage(stPage);
                            ad.Show();
                            this.Hide();
                        }
                        else
                        {
                            mechanistPage mc = new mechanistPage();
                            mc.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        throw new Exception("input details are invalid");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

           
        }

        //exit
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            stPage.Show();
            this.Close();
        }
    }
}
