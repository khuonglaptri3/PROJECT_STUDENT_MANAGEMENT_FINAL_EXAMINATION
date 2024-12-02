
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Teacher : Person
    {

        private string phone;
        public string PHONE
        {
            get { return phone; }
            set
            {
                phone = value;
            }
        }
        public Teacher()
        {
            FIRSTNAME = default;
            LASTNAME = default;
            GENDER = default;
            GetDayOfBirth = default;
            PHONE = default;
            ADDRESS = default;
        }
        public Teacher(string FirstName, string LastName, string address, string gender, DateTime dateofbirth, string phone)
        {
            FIRSTNAME = FirstName;
            LASTNAME = LastName;
            GENDER = gender;
            GetDayOfBirth = dateofbirth;
            PHONE = phone;
            ADDRESS = address;
        }
        //public DataTable GetStudentList(SqlConnection connect)
        //{
        //    connect.Open();
        //    String selectData = "SELECT * FROM Student ";
        //    using (SqlCommand cmd = new SqlCommand(selectData, connect))
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable table = new DataTable();
        //        adapter.Fill(table);
        //        connect.Close();
        //        return table;
        //    }

        public Teacher(int TchId, SqlConnection connect)
        {
            connect.Open();
            String selectData = "SELECT * FROM teacher WHERE tchdId = @tchdId";
            using (SqlCommand cmd = new SqlCommand(selectData, connect))
            {
                cmd.Parameters.AddWithValue("@tchdId", TchId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                FIRSTNAME = table.Rows[0]["tchFirstName"].ToString();
                LASTNAME = table.Rows[0]["tchLastName"].ToString();
                ADDRESS = table.Rows[0]["Address"].ToString();
                GetDayOfBirth = Convert.ToDateTime(table.Rows[0]["Birthdate"]);
                GENDER = table.Rows[0]["Gender"].ToString();
                ID = TchId;
                PHONE = table.Rows[0]["Phone"].ToString();
                connect.Close();
            }
        }
        //public DataTable GetStudentList(SqlConnection connect, string selectData)
        //{
        //    connect.Open();
        //    using (SqlCommand cmd = new SqlCommand(selectData, connect))
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable table = new DataTable();
        //        adapter.Fill(table);
        //        connect.Close();
        //        return table;
        //    }

        //}
        public DataTable GetCourse(SqlConnection connect, int TchId)

        {
            string query = "SELECT * FROM Course WHERE TeachID = @tchId";

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("@tchId", TchId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connect.Close();
            return table;
        }
        public DataTable GetCourse(SqlConnection connect, int TchId, string query)

        {

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("@tchId", TchId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connect.Close();
            return table;
        }


        public bool AddCourse(Course course, SqlConnection connect)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string insertData = "INSERT INTO Course (CourseName , Coursehours ,Description , TeachID) VALUES (@courseName , @courseHour , @courseDescription , @teacherId)";
                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    cmd.Parameters.AddWithValue("@courseName", course.COURSENAME.Trim());
                    cmd.Parameters.AddWithValue("@courseHour", course.COURSEHOUR);
                    cmd.Parameters.AddWithValue("@courseDescription", course.COURSEDESCRIPTION.Trim());
                    cmd.Parameters.AddWithValue("@teacherId", course.TEACHERID);
                    cmd.ExecuteNonQuery();

                    connect.Close();
                    return true;
                }
            }
            return false;

        }
        public bool updateCourse(SqlConnection connect, Course course)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string updateData = "UPDATE Course SET CourseName = @courseName , Coursehours = @courseHour , Description = @courseDescription WHERE CourseID = @courseId AND TeachID = @TchId";
                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                {
                    cmd.Parameters.AddWithValue("@courseName", course.COURSENAME.Trim());
                    cmd.Parameters.AddWithValue("@courseHour", course.COURSEHOUR);
                    cmd.Parameters.AddWithValue("@courseDescription", course.COURSEDESCRIPTION.Trim());
                    cmd.Parameters.AddWithValue("@courseId", course.COURSEID);
                    cmd.Parameters.AddWithValue("@TchId", course.TEACHERID);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return true;
                }
            }
            return false;
        }
        public DataTable searchCourse(SqlConnection connect, string search, int TchId)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE CONCAT(CourseName, CourseID)  LIKE '%" + search + "%' AND TeachID = @TchID", connect);
            command.Parameters.AddWithValue("@TchID", TchId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connect.Close();
            return table;
        }
        public bool deleteCourse(SqlConnection connect, int courseId, int TchId)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                SqlCommand deleteGradesCommand = new SqlCommand("DELETE FROM GRADES WHERE CourseId = @courseId", connect);
                deleteGradesCommand.Parameters.AddWithValue("@courseId", courseId);
                deleteGradesCommand.ExecuteNonQuery();

                string deleteData = "DELETE FROM Course WHERE CourseID = @courseId AND TeachID = @TchId";
                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                {
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                    cmd.Parameters.AddWithValue("@TchId", TchId);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return true;
                }
            }
            return false;
        }
        // khuong get_score student 
        public DataTable Get_score_student(SqlConnection connect, string courseName, int tchId)
        {
            String selectData = "SELECT c.CourseID, g.StdId, CONCAT(s.StdFirstName, ' ', s.StdLastName) AS StdName, g.Grade " +
                    "FROM GRADES g " +
                    "JOIN Student s ON g.StdId = s.StdId " +
                    "JOIN Course c ON g.CourseId = c.CourseID " +
                    "WHERE c.TeachID = @TeachID AND c.CourseName = @CourseName";
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            
            
                SqlCommand cmd = new SqlCommand(selectData, connect);
                cmd.Parameters.AddWithValue("@TeachID", tchId);
                cmd.Parameters.AddWithValue("@CourseName", courseName.Trim());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connect.Close();
                return table;

            
        }
        public bool add_score_student(SqlConnection connect , Grade grade, int TchId)
        {
            String updateData = "UPDATE g " +
                    "SET g.Grade = @Grade " +
                    "FROM GRADES g " +
                    "JOIN Course c ON g.CourseID = c.CourseID " +
                    "WHERE c.TeachID = @TeachID AND c.CourseName = @CourseName AND g.StdId = @StdId";

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();  
            }
            if (connect.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(updateData, connect);
                cmd.Parameters.AddWithValue("@Grade", grade.GradeValue);
                cmd.Parameters.AddWithValue("@TeachID", TchId);
                cmd.Parameters.AddWithValue("@CourseName", grade.CourseName);
                cmd.Parameters.AddWithValue("@StdId", grade.StdId);
                cmd.ExecuteNonQuery();
                connect.Close();
                return true;
            }
            return false;    
        }
        public override string PrintDetails()
        {
            return $"{LASTNAME} {FIRSTNAME}";
        }
    }
}