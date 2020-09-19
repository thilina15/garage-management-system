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

        
        //admin login
        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            login ad = new login(true,this);
            this.Hide();
            ad.Show();
        }

        //mechanic login
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            login ad = new login(false, this);
            this.Hide();
            ad.Show();
        }


        //exit button
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
    
}

