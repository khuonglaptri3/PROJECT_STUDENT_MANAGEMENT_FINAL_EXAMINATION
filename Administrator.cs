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
        private string phone; 
        public string PHONE
        {
            get { return phone; }
            set { phone = value; }
        }

        public Administrator() { }
        public Administrator(SqlConnection connect, int adminid)
        {
            string Selectdata = "SELECT * FROM users WHERE Idadmin = @id ";
            if(connect.State != ConnectionState.Open) {
                connect.Open();
            }
            using (SqlCommand cmd = new SqlCommand(Selectdata, connect))
            {
                cmd.Parameters.AddWithValue("@id", adminid);
                SqlDataAdapter adatper = new SqlDataAdapter(cmd);
                DataTable table = new DataTable(); 
                adatper.Fill(table);
                FIRSTNAME = table.Rows[0]["adFirstName"].ToString();
                LASTNAME = table.Rows[0]["adLastName"].ToString();
                ADDRESS = table.Rows[0]["Address"].ToString();
                GetDayOfBirth = Convert.ToDateTime(table.Rows[0]["Birthdate"]);
                GENDER = table.Rows[0]["Gender"].ToString();
                ID = adminid;
                PHONE = table.Rows[0]["Phone"].ToString();
                connect.Close();

            }


        }
        public DataTable GetStdList(SqlConnection connect)
        {
            connect.Open();
            String selectData = "SELECT * FROM teacher ";
            using (SqlCommand cmd = new SqlCommand(selectData, connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connect.Close();
                return table;
            }

        }

        public DataTable getCourse(SqlConnection connect, string query)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connect.Close();
            return table;
        }
        public DataTable GetStudentList(SqlConnection connect)
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
        public DataTable GetStudentList(SqlConnection connect, string selectData)
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
        public bool updatestudent(SqlConnection connect, Student student, int StdId)
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

            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE CONCAT(StdFirstName, StdLastName ,StdId) LIKE '%" + search + "%'", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            connect.Close();
            return table;
        }
        public int coutstudent(SqlConnection connect, string query)
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
        public int coutstudent(SqlConnection connect, string query, string courseName)
        {
            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@CourseName", courseName);
                connect.Open();
                int count = (int)cmd.ExecuteScalar();
                connect.Close();
                return count;
            }
        }
        public string insertteacher(SqlConnection connect, Teacher teacher)

        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {

                connect.Open();
                string insertData = "INSERT INTO teacher ( tchFirstName , tchLastName , Birthdate , Phone , Gender ,Address) VALUES (@tchFirstName , @tchLastName , @Birthdate , @Phone , @Gender ,@Address)";
                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    cmd.Parameters.AddWithValue("@tchFirstName", teacher.FIRSTNAME.Trim());
                    cmd.Parameters.AddWithValue("@tchLastName", teacher.LASTNAME.Trim());
                    cmd.Parameters.AddWithValue("@Birthdate", teacher.GetDayOfBirth.ToString().Trim());
                    cmd.Parameters.AddWithValue("@Phone", teacher.PHONE.Trim());
                    cmd.Parameters.AddWithValue("@Gender", teacher.GENDER.Trim());
                    cmd.Parameters.AddWithValue("@Address", teacher.ADDRESS.Trim());

                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return "True";

                }
            }
            return "False";
        }

        public bool deleteteacher(SqlConnection connect, int id)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string deleteData = "DELETE FROM teacher WHERE tchdId = @id";
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
        public bool updateteacher(SqlConnection connect, Teacher teacher, int tchdId)
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                string updateData = "UPDATE teacher SET tchFirstName = @tchFirstName , tchLastName = @tchLastName , Birthdate = @Birthdate , Phone = @Phone , Gender = @Gender , Address = @Address WHERE StdId = @StdId";
                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                {
                    cmd.Parameters.AddWithValue("@tchFirstName", teacher.FIRSTNAME.Trim());
                    cmd.Parameters.AddWithValue("@tchLastName", teacher.LASTNAME.Trim());
                    cmd.Parameters.AddWithValue("@Birthdate", teacher.GetDayOfBirth.ToString().Trim());
                    cmd.Parameters.AddWithValue("@Phone", teacher.PHONE.Trim());
                    cmd.Parameters.AddWithValue("@Gender", teacher.GENDER.Trim());
                    cmd.Parameters.AddWithValue("@Address", teacher.ADDRESS.Trim());
                    cmd.Parameters.AddWithValue("@tchdId", tchdId);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    return true;
                }
            }
            return false;
        }
        public DataTable Seachteacher(SqlConnection connect, string search)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM teacher WHERE CONCAT(tchFirstName, tchLastName, Address, Phone) LIKE '%" + search + "%'", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            connect.Close();
            return table;
        }
        public int coutteacher(SqlConnection connect, string query)
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
        public int coutteacher(SqlConnection connect, string query, string courseName)
        {
            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@CourseName", courseName);
                connect.Open();
                int count = (int)cmd.ExecuteScalar();
                connect.Close();
                return count;
            }
        }
        public DataTable GetTeacherList(SqlConnection connect)
        {
            connect.Open();
            String selectData = "SELECT * FROM teacher ";
            using (SqlCommand cmd = new SqlCommand(selectData, connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connect.Close();
                return table;
            }

        }
        public DataTable GetTeacherList(SqlConnection connect, string selectData)
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
        public override string PrintDetails()
        {
            return $" Welome {FIRSTNAME} {LASTNAME} ";
         }
    }
    
}