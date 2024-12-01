using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Administrator : Person
    {

        public  DataTable GetStudentList(SqlConnection connect)
        {
            connect.Open();
            String selectData = "SELECT * FROM Student ";
            using (SqlCommand cmd = new SqlCommand(selectData, connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connect.Close();
                return table;
            }
              
        }
        public DataTable GetStudentList(SqlConnection connect , string selectData) 
        {
            connect.Open();
            using (SqlCommand cmd = new SqlCommand(selectData, connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connect.Close();
                return table;
            }
            
        }
        public string insertstudent(SqlConnection connect, Student student)

        {
            if (connect.State == ConnectionState.Open)
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
                    cmd.Parameters.AddWithValue("@Gender", student.GENDER.Trim());
                    cmd.Parameters.AddWithValue("@Address", student.ADDRESS.Trim());

                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return "True";

                }
            }
            return "False";
        }

        public bool deletestudent(SqlConnection connect, int id)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string deleteData = "DELETE FROM Student WHERE StdID = @id";
                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return true;
                }
            }
            return false;
        }
        public bool updatestudent(SqlConnection connect, Student student , int StdId )
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string updateData = "UPDATE Student SET StdFirstName = @StdFirstName , StdLastName = @StdLastName , Birthdate = @Birthdate , Phone = @Phone , Gender = @Gender , Address = @Address WHERE StdId = @StdId";
                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                {
                    cmd.Parameters.AddWithValue("@StdFirstName", student.FIRSTNAME.Trim());
                    cmd.Parameters.AddWithValue("@StdLastName", student.LASTNAME.Trim());
                    cmd.Parameters.AddWithValue("@Birthdate", student.GetDayOfBirth.ToString().Trim());
                    cmd.Parameters.AddWithValue("@Phone", student.PHONE.Trim());
                    cmd.Parameters.AddWithValue("@Gender", student.GENDER.Trim());
                    cmd.Parameters.AddWithValue("@Address", student.ADDRESS.Trim());
                    cmd.Parameters.AddWithValue("@StdId", StdId);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return true;
                }
            }
            return false;
        }
        public DataTable Seachstudent(SqlConnection connect, string search)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE CONCAT(StdFirstName, StdLastName, Address, Phone) LIKE '%" + search + "%'", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            connect.Close();
            return table;
        }
        public int coutstudent(SqlConnection connect , string query)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand(query, connect);
            int count = (int)command.ExecuteScalar();
            connect.Close();
            return count;
        }
    }
}