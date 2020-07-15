using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstApp
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReader;
            string output = "";


            try
            {
                dataReader = DB.readQuery("select * from admin");
                if (dataReader != null)
                {
                    while (dataReader.Read())
                    {
                        output = output + dataReader.GetValue(0) + " \t- " + dataReader.GetValue(1) + " \t- " + dataReader.GetValue(2) + "\n";
                    }
                    MessageBox.Show(output);

                    dataReader.Close();

                    DB.closeDB();
                }

            }

            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



            
            

            
            
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            try
            {
                int ID;
                string name;
                string pass;
                ID = int.Parse(txtID.Text);
                name = txtUserName.Text;
                pass = txtPass.Text;

                DB.addAdmin(ID, name, pass);
                DB.closeDB();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
           

            txtID.Clear();
            txtPass.Clear();
            txtUserName.Clear();
            
           





        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("you can only input digits");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            login admin = new login(true, this);
            admin.Show();
            //this.Hide();
        }

        private void btnGarage_Click(object sender, EventArgs e)
        {
            login admin = new login(false, this);
            admin.Show();
            //this.Hide();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB.ConnectDB();
        }
    }
    
    
}

