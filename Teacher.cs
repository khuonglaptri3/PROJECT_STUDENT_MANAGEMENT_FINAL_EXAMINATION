using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Teacher : Person
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        private string teacherID;
        private List<string> subjectTaught = new List<string>();

        public string GetTeacherID
        {
            get { return teacherID; }
            set { teacherID = value; }
        }


        //public bool updatecourse(SqlConnection connect, Teacher course, int CourseID, string cName, int hr, string desc)
        //{
        //    if (connect.State == ConnectionState.Open)
        //    {
        //        connect.Close();
        //    }
        //    if (connect.State != ConnectionState.Open)
        //    {
        //        connect.Open();
        //        string updateData = "UPDATE Course SET CourseName = @CourseName , Coursehours = @Coursehours , Coursehours = @Description WHERE CourseID = @CourseID";
        //        using (SqlCommand cmd = new SqlCommand(updateData, connect))
        //        {
        //            //cmd.Parameters.AddWithValue("@StdFirstName", course.FIRSTNAME.Trim());
        //            //cmd.Parameters.AddWithValue("@StdLastName", student.LASTNAME.Trim());
        //            //cmd.Parameters.AddWithValue("@Birthdate", student.GetDayOfBirth.ToString().Trim());
        //            //cmd.Parameters.AddWithValue("@Phone", student.PHONE.Trim());
        //            //cmd.Parameters.AddWithValue("@Gender", student.GENDER.Trim());
        //            //cmd.Parameters.AddWithValue("@Address", student.ADDRESS.Trim());
        //            //cmd.Parameters.AddWithValue("@StdId", StdId);
        //            //cmd.Parameters.Add("@CourseID", SqlDbType.Int).Value = courseId;
        //            cmd.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = cName;
        //            cmd.Parameters.Add("@Coursehours", SqlDbType.Int).Value = hr;
        //            cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = desc;
        //            cmd.Parameters.Add("@CourseID", SqlDbType.Int).Value = CourseID;
        //            cmd.ExecuteNonQuery();
        //            connect.Close();
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public DataTable Seachstudent(SqlConnection connect, string search)
        //{
        //    if (connect.State == ConnectionState.Closed)
        //    {
        //        connect.Open();
        //    }

        //    SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE CONCAT(CourseName, Coursehours, Coursehours) LIKE '%" + search + "%'", connect);
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    connect.Close();
        //    return table;
        //}
        //public DataTable getCourse(SqlCommand command)
        //{
        //    command.Connection = connect;
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
    }
}