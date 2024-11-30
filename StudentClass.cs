using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    class StudentClass
    {
        DBconnect connect = new DBconnect();

        // Create a function to add a new student to the database
        public bool insertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address)
        {
            SqlCommand command = new SqlCommand("INSERT INTO student (StdFirstName, StdLastName, Birthdate, Gender, Phone, Address, Photo) VALUES (@fn, @ln, @bd, @gd, @ph, @adr)", connect.getconnection);

            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;
            //command.Parameters.Add("@img", SqlDbType.Image).Value = img;

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

        // Get student list
        public DataTable getStudentlist(SqlCommand command)
        {
            command.Connection = connect.getconnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Execute count query
        public string exeCount(string query)
        {
            SqlCommand command = new SqlCommand(query, connect.getconnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        // Get total students
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }

        // Get male students
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender = 'Male'");
        }

        // Get female students
        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender = 'Female'");
        }

        // Search student
        public DataTable searchStudent(string searchdata)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM student WHERE CONCAT(StdFirstName, StdLastName, Address) LIKE '%" + searchdata + "%'", connect.getconnection);
            return getStudentlist(command);
        }

        // Update student
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address)
        {
            SqlCommand command = new SqlCommand("UPDATE student SET StdFirstName=@fn, StdLastName=@ln, Birthdate=@bd, Gender=@gd, Phone=@ph, Address=@adr WHERE StdId=@id", connect.getconnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;
            //command.Parameters.Add("@img", SqlDbType.Image).Value = img;

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

        // Delete student
        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM student WHERE StdId=@id", connect.getconnection);
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

        // Get list
        public DataTable getList(SqlCommand command)
        {
            command.Connection = connect.getconnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
