﻿using System;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB.ConnectDB();
        }
    }
    
    
}

