using System;
using System.Data;
using System.Data.SqlClient;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Course
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");

        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int CourseHours { get; set; }
        public string Description { get; set; }

        public bool InsertCourse(string cName, int hr, string desc)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string insertData = "INSERT INTO Course (CourseName, Coursehours, Description) VALUES (@CourseName, @Coursehours, @Description)";
                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    cmd.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = cName;
                    cmd.Parameters.Add("@Coursehours", SqlDbType.Int).Value = hr;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = desc;
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteCourse(int courseID)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string deleteData = "DELETE FROM Course WHERE CourseID = @CourseID";
                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                {
                    cmd.Parameters.AddWithValue("@CourseID", courseID);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return true;
                }
            }
            return false;
        }

        public bool UpdateCourse(int courseID, string cName, int hr, string desc)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string updateData = "UPDATE Course SET CourseName = @CourseName, Coursehours = @Coursehours, Description = @Description WHERE CourseID = @CourseID";
                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                {
                    cmd.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = cName;
                    cmd.Parameters.Add("@Coursehours", SqlDbType.Int).Value = hr;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = desc;
                    cmd.Parameters.Add("@CourseID", SqlDbType.Int).Value = courseID;
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return true;
                }
            }
            return false;
        }

        public DataTable GetCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [course]", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}