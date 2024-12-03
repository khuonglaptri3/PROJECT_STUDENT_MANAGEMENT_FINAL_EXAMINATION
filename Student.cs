using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.CodeDom;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Student : Person
    {


        private string phone;

        public string PHONE
        {
            get { return phone; }
            set { phone = value; }
        }
        public Student()
        {
            FIRSTNAME = default;
            LASTNAME = default;
            GENDER = default;
            GetDayOfBirth = default;
            PHONE = default;
            ADDRESS = default;
        }
        public Student(string FirstName, string LastName, string address, string gender, DateTime dateofbirth, string phone)
        {
            FIRSTNAME = FirstName;
            LASTNAME = LastName;
            GENDER = gender;
            GetDayOfBirth = dateofbirth;
            PHONE = phone;
            ADDRESS = address;
        }
        //public Teacher(int TchId, SqlConnection connect)
        //{
        //    connect.Open();
        //    String selectData = "SELECT * FROM teacher WHERE tchdId = @tchdId";
        //    using (SqlCommand cmd = new SqlCommand(selectData, connect))
        //    {
        //        cmd.Parameters.AddWithValue("@tchdId", TchId);
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable table = new DataTable();
        //        adapter.Fill(table);
        //        FIRSTNAME = table.Rows[0]["tchFirstName"].ToString();
        //        LASTNAME = table.Rows[0]["tchLastName"].ToString();
        //        ADDRESS = table.Rows[0]["Address"].ToString();
        //        GetDayOfBirth = Convert.ToDateTime(table.Rows[0]["Birthdate"]);
        //        GENDER = table.Rows[0]["Gender"].ToString();
        //        ID = TchId;
        //        PHONE = table.Rows[0]["Phone"].ToString();
        //        connect.Close();
        //    }
        //}
        public Student (SqlConnection connect , int Stdid)
        {
          if(connect.State  != ConnectionState.Open)
            {
                connect.Open(); 
            }
            String selectData = "SELECT * FROM Student WHERE StdId = @Stdid "; 
            using (SqlCommand cmd = new SqlCommand(selectData , connect))
            {
                cmd.Parameters.AddWithValue("@Stdid", Stdid); 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                FIRSTNAME = table.Rows[0]["StdFirstName"].ToString();
                LASTNAME = table.Rows[0]["StdLastName"].ToString();
                ADDRESS = table.Rows[0]["Address"].ToString();
                GetDayOfBirth = Convert.ToDateTime(table.Rows[0]["Birthdate"]); 
                GENDER = table.Rows[0]["Gender"].ToString();
                ID = Stdid;
                PHONE = table.Rows[0]["Phone"].ToString();
                connect.Close();



            }
        }
        public bool EnrollInCourse(SqlConnection connect, int Stdid, int CourseId)
        {
            string query = "INSERT INTO GRADES (StdId, CourseId) VALUES (@StdId, @CourseId)";
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            using (SqlCommand command = new SqlCommand(query, connect))
            {
                command.Parameters.AddWithValue("@StdId", Stdid);
                command.Parameters.AddWithValue("@CourseId", CourseId);
                int result = command.ExecuteNonQuery();
                connect.Close();
                return result > 0;
            }
        }

        public DataTable Get_course_not_study(SqlConnection connect, int stdId)
        {
            string query = "SELECT " +
               "c.CourseID, " +
               "c.CourseName, " +
               "t.tchFirstName, " +
               "t.tchLastName, " +
               "t.tchdId " +
               "FROM Course c " +
               "INNER JOIN teacher t ON c.TeachID = t.tchdId " +
               "WHERE c.CourseID NOT IN (" +
               "SELECT g.CourseId " +
               "FROM GRADES g " +
               "WHERE g.StdId = @StdId" +
               ");";
           
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            using (SqlCommand command = new SqlCommand(query, connect))
            {
                command.Parameters.AddWithValue("@StdId", stdId);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    connect.Close();
                    return resultTable;
                }
            }
        }


        public DataTable GetCourses_Studied(SqlConnection connection, int stdId)
        {
            string query = "SELECT c.CourseID, c.CourseName, t.tchFirstName , t.tchLastName , t.tchdId " +
                 "FROM GRADES g " +
                 " JOIN Course c ON g.CourseId = c.CourseID " +
                 " JOIN [teacher] t ON c.TeachID = t.tchdId " +
                 "WHERE g.StdId = @StdId";



            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StdId", stdId);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    connection.Close();
                    return resultTable;
                }
            }
        }
        public override string PrintDetails()
        {
            return $" ID: {ID} Name:  {FIRSTNAME} {LASTNAME}  "; 
        }

    }
}