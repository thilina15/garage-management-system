using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace myFirstApp
{
   public static class DB

    {
        static SqlConnection con;

       
        public static void ConnectDB()  //build database connection
        {

            //string conString = "SERVER=localhost;DATABASE= unreal;UID=root;PASSWORD=1234";
            try
            {
                //string conString = @"Data Source=localhost;Initial Catalog=garageManagement;Integrated Security=True";
                string conString = @"Data Source=192.168.8.1,1433;Network Library=DBMSSOCN;Initial Catalog=garageManagement;Integrated Security=True";
                con = new SqlConnection(conString);
                con.Open();
                MessageBox.Show("connected");
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            
        }

       
        public static void closeDB()  //close database connection
        {
            con.Close();
        }

        public static void addAdmin(int adminID, string userName, string password) //add admin user to database
        {
            ConnectDB();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "insert into admin values(" + adminID + ",'" + userName + "','" + password + "')";
            command = new SqlCommand(sql, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();


            
            
            command.Dispose();
        }

        public static SqlDataReader readQuery(string query) //read MySQL query
        {
            ConnectDB();

            try
            {
                SqlCommand command;
                SqlDataReader dataReader;



                command = new SqlCommand(query, con);
                dataReader = command.ExecuteReader();


                return dataReader;
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            
            
        }



        public static void loginAdmin(string name, string pass)
        {
            readQuery("select adminID, password from admin");


            
        }
    }
}
