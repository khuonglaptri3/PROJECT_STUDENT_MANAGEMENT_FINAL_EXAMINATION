using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Administrator : Person
    {

        public DataTable GetStudentList(SqlConnection connect)
        {
            connect.Open();
            String selectData = "SELECT * FROM Student ";
            using (SqlCommand cmd = new SqlCommand(selectData, connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}