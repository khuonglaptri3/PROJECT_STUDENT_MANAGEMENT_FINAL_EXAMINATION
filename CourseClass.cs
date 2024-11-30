using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    class CourseClass
    {
        DBconnect connect = new DBconnect();
        public bool insertCourse(string cName, int hr, string desc)
        {
            SqlCommand command = new SqlCommand("INSERT INTO course (CourseName, CourseHour, Description) VALUES (@cn, @ch, @desc)", connect.getconnection);
            //@cn, @ch, @desc
            command.Parameters.Add("@cn", SqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch", SqlDbType.Int).Value = hr;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        public DataTable getCourse(SqlCommand command)
        {
            command.Connection = connect.getconnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateCourse(int id, string cName, int hr, string desc)
        {
            SqlCommand command = new SqlCommand("UPDATE course SET CourseName=@cn, CourseHour=@ch, Description=@desc WHERE CourseId=@id", connect.getconnection);
            //@id, @cn, @ch, @desc
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cn", SqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch", SqlDbType.Int).Value = hr;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        public bool deleteCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM course WHERE CourseId=@id", connect.getconnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
    }
}
