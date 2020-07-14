using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace myFirstApp
{
   public static class DB

    {
        static MySqlConnection con;

       
        public static void ConnectDB()  //build database connection
        {

            //string conString = "SERVER=localhost;DATABASE= unreal;UID=root;PASSWORD=1234";
            try
            {
                string conString = "SERVER=localhost;DATABASE= unreal;UID=root;PASSWORD=1234";
                con = new MySqlConnection(conString);
                con.Open();
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

            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "";

            sql = "insert into admin values(" + adminID + ",'" + userName + "','" + password + "')";
            command = new MySqlCommand(sql, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();


            
            
            command.Dispose();
        }

        public static MySqlDataReader readQuery(string query) //read MySQL query
        {
            ConnectDB();

            try
            {
                MySqlCommand command;
                MySqlDataReader dataReader;



                command = new MySqlCommand(query, con);
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
