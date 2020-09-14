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
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace myFirstApp
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            login admin = new login(true, this);
            admin.Show();
            MessageBox.Show("kad");
            //this.Hide();
        }

        private void btnGarage_Click(object sender, EventArgs e)
        {
            login admin = new login(false, this);
            admin.Show();
            //this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB.ConnectDB();
            

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startPage_Load(object sender, EventArgs e)
        {
          
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}

