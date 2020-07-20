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
        
        // testing call backs

        private void button2_Click(object sender, EventArgs e)
        {
            
            var connectionString = "Data Source=south.database.windows.net; Initial Catalog = sunilGarage;User ID = thilina; Password =abcd@123;";
            try 
            {
                using (var tableDependency = new SqlTableDependency<customers>(connectionString, "dbo.customers"))
                {
                    tableDependency.OnChanged += TableDependency_Changed;
                    tableDependency.OnError += TableDependency_OnError;

                    tableDependency.Start();
                    MessageBox.Show("started");
                    Console.ReadKey();
                    tableDependency.Stop();
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            
        }

        static void TableDependency_Changed(object sender, RecordChangedEventArgs<customers> e)
        {
            if(e.ChangeType!= ChangeType.None)
            {
                var changeEntity = e.Entity;
                MessageBox.Show("" + changeEntity.name);
            }
        }

        static void TableDependency_OnError(object sender, ErrorEventArgs e)
        {
            Exception ex = e.Error;
            throw ex;
        }
    }
    
    
}

