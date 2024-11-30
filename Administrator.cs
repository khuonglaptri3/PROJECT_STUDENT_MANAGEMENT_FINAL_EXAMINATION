using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
        public string  insertstudent(SqlConnection connect , Student student )
            
        {
            if (connect.State == ConnectionState.Open )
            {
                connect.Close(); 
            }
            if (connect.State != ConnectionState.Open)
            {
                
                    connect.Open();
                    string insertData = "INSERT INTO Student ( StdFirstName , StdLastName , Birthdate , Phone , Gender ,Address) VALUES (@StdFirstName , @StdLastName , @Birthdate , @Phone , @Gender ,@Address)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@StdFirstName", student.FIRSTNAME.Trim());
                        cmd.Parameters.AddWithValue("@StdLastName", student.LASTNAME.Trim());
                        cmd.Parameters.AddWithValue("@Birthdate", student.GetDayOfBirth.ToString().Trim());
                        cmd.Parameters.AddWithValue("@Phone", student.PHONE.Trim());
                        cmd.Parameters.AddWithValue("@gender", student.GENDER.Trim());
                        cmd.Parameters.AddWithValue("@Address", student.ADDRESS.Trim());

                        cmd.ExecuteNonQuery();
                    connect.Close();
                    return "True"; 

                    }
            }
            return "False"; 
        }
    }
}