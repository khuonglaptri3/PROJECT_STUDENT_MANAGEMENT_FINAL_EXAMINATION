using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    class DBconnect
    {
        //to create connection
        //MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=studentdb");
        //MySqlConnection connect = new MySqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trant\source\repos\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\School.mdf;Integrated Security=True;Connect Timeout=30");
        private SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\trant\source\repos\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SchoolSysDB.mdf;Integrated Security = True; Connect Timeout = 30");
        //to get connection
        public SqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        //create a function to Open conncetion
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //Create a fuction to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
