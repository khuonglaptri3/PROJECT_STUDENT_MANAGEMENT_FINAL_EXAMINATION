using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public partial class ViewStudentDetailForm : Form
    {
        private int studentID;

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        public ViewStudentDetailForm(int studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void LoadStudentDetails(int studentId)//XT
        {
            //try
            //{
            //    connect.Open();

            //    SqlCommand studentCommand = new SqlCommand("SELECT * FROM Student WHERE StdId = @StdId", connect);
            //    studentCommand.Parameters.AddWithValue("@StdId", studentId);
            //    SqlDataAdapter studentAdapter = new SqlDataAdapter(studentCommand);
            //    DataTable studentTable = new DataTable();
            //    studentAdapter.Fill(studentTable);

            //    SqlCommand gradeCommand = new SqlCommand("SELECT * FROM GRADES WHERE StdId = @StdId", connect);
            //    gradeCommand.Parameters.AddWithValue("@StdId", studentId);
            //    SqlDataAdapter gradeAdapter = new SqlDataAdapter(gradeCommand);
            //    DataTable gradeTable = new DataTable();
            //    gradeAdapter.Fill(gradeTable);

            //    connect.Close();

            //    if (studentTable.Rows.Count > 0)
            //    {
            //        DataRow studentRow = studentTable.Rows[0];
            //        StringBuilder studentInfo = new StringBuilder();
            //        studentInfo.AppendLine($"Name: {studentRow["StdFirstName"]} {studentRow["StdLastName"]}");
            //        studentInfo.AppendLine($"Birthdate: {studentRow["Birthdate"]}");
            //        studentInfo.AppendLine($"Phone: {studentRow["Phone"]}");
            //        studentInfo.AppendLine($"Gender: {studentRow["Gender"]}");
            //        studentInfo.AppendLine($"Address: {studentRow["Address"]}");

            //        if (gradeTable.Rows.Count > 0)
            //        {
            //            int totalGrades = 0;
            //            foreach (DataRow row in gradeTable.Rows)
            //            {
            //                totalGrades += Convert.ToInt32(row["GradeValue"]);
            //            }
            //            double averageGrade = totalGrades / gradeTable.Rows.Count;
            //            string gradeJudgment = GetGradeJudgment(averageGrade);

            //            studentInfo.AppendLine($"Average Grade: {averageGrade}");
            //            studentInfo.AppendLine($"Judgment: {gradeJudgment}");

            //            DataGridView_student.DataSource = gradeTable;
            //        }
            //        else
            //        {
            //            studentInfo.AppendLine("Average Grade: N/A");
            //            studentInfo.AppendLine("Judgment: N/A");
            //        }

            //        textBox_studentInfo.Text = studentInfo.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Student not found.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //}
            //    studentID = studentId;
            //    string query = @"
            //SELECT 
            //    c.CourseID, 
            //    c.CourseName, 
            //    g.Grade 

            //FROM 
            //    GRADES g
            //JOIN 
            //    Course c ON g.CourseId = c.CourseID
            //WHERE 
            //    g.StdId = @StudentId";

            //    using (SqlCommand cmd = new SqlCommand(query, connect))
            //    {
            //        cmd.Parameters.AddWithValue("@StudentId", studentId);
            //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        adapter.Fill(dt);

            //        DataGridView_student.DataSource = dt;

            //        if (dt.Rows.Count > 0)
            //        {
            //            double averageGrade = dt.AsEnumerable().Average(row => row.Field<int>("Grade"));
            //            string judgment = GetGradeJudgment(averageGrade);
            //            textBox_studentInfo.Text = $"Average Grade: {averageGrade:F2}\nJudgment: {judgment}";
            //        }
            //        else
            //        {
            //            textBox_studentInfo.Text = "No courses found for this student.";
            //        }
            //    }
            string query = @"SELECT 
                            c.CourseID, 
                            c.CourseName, 
                            g.Grade 
                        FROM 
                            GRADES g
                        INNER JOIN 
                            Course c ON g.CourseId = c.CourseID
                        WHERE 
                            g.StdId = @StudentId";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataGridView_student.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    double averageGrade = dt.AsEnumerable().Average(row => row.Field<int>("Grade"));
                    string judgment = GetGradeJudgment(averageGrade);
                    textBox_studentInfo.Text = $"Average Grade: {averageGrade:F2}\r\nJudgment: {judgment}";
                }
                else
                {
                    textBox_studentInfo.Text = "No courses found for this student.";
                }
            }
        }
        private string GetGradeJudgment(double averageGrade)//XT
        {
            if (averageGrade >= 9) return "Excellent";
            if (averageGrade >= 7.5) return "Good";
            if (averageGrade >= 5) return "Average";
            return "Poor";
        }
        private void LoadStudentData()//XT
        {
            //if (connect.State == ConnectionState.Closed)
            //{
            //    connect.Open();
            //}
            //SqlCommand command = new SqlCommand("SELECT * FROM Student", connect);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //DataGridView_student.DataSource = table;
            //connect.Close();
            //string query = "SELECT CourseID, CourseName, Teacher FROM Courses WHERE CourseID = @CourseID";
            //using (SqlCommand command = new SqlCommand(query, connect))
            //{
            //    //command.Parameters.AddWithValue("@StdId", 1); // Replace with the actual student ID
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    DataGridView_student.DataSource = table;
            //}
            string query = @"
        SELECT 
            c.CourseID, 
            c.CourseName, 
            c.TeachID 
        FROM 
            GRADES g
        JOIN 
            Course c ON g.CourseId = c.CourseID
        WHERE 
            g.StdId = @StdId";
            using (SqlCommand command = new SqlCommand(query, connect))
            {
                command.Parameters.AddWithValue("@StdId", studentID); // Replace with the actual student ID
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView_student.DataSource = table;
            }
        }
        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView_student.Rows[e.RowIndex];
                //int studentId = Convert.ToInt32(row.Cells["StdId"].Value);
                //int studentId = int(ID_textBox.Text)
                int studentId = int.Parse(ID_textBox.Text);

                LoadStudentDetails(studentId);
                //LoadStudentData(studentId);
            }
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ID_textBox.Text, out int studentId))
            {
                LoadStudentDetails(studentId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
            }
        }
        private void button_print_Click(object sender, EventArgs e)
        {
            LoadStudentDetails(studentID);
            GenerateStudentInfoText(studentID);
            GenerateEvaluationText(studentID);
            if (DataGridView_student.Columns.Contains("CourseID") &&
                DataGridView_student.Columns.Contains("CourseName") &&
                DataGridView_student.Columns.Contains("Grade"))
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Student Course Details";
                printer.SubTitle = $"Printed on: {DateTime.Now.ToString("MM/dd/yyyy")}";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Student Management System";
                printer.FooterSpacing = 15;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                //DataGridView_student.Columns["CourseID"].HeaderText = "Course ID";
                //DataGridView_student.Columns["CourseName"].HeaderText = "Course Name";
                //DataGridView_student.Columns["Grade"].HeaderText = "Grade";
                printer.PrintDataGridView(DataGridView_student);
            }
            else
            {
                MessageBox.Show("The DataGridView does not contain the required columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerateStudentInfoText(int studentId)
        {
            //string query = "SELECT StdFirstName, StdLastName, Birthdate, Phone, Gender, Address FROM Student WHERE StdId = @StdId";
            //using (SqlCommand command = new SqlCommand(query, connect))
            //{
            //    command.Parameters.AddWithValue("@StdId", studentId);
            //    connect.Open();
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            StringBuilder studentInfo = new StringBuilder();
            //            studentInfo.AppendLine($"Name: {reader["StdFirstName"]} {reader["StdLastName"]}");
            //            studentInfo.AppendLine($"Birthdate: {reader["Birthdate"]}");
            //            studentInfo.AppendLine($"Phone: {reader["Phone"]}");
            //            studentInfo.AppendLine($"Gender: {reader["Gender"]}");
            //            studentInfo.AppendLine($"Address: {reader["Address"]}");
            //            return studentInfo.ToString();
            //        }
            //    }
            //    connect.Close();
            //}
            //return string.Empty;
            string studentInfo = string.Empty;
            string query = "SELECT * FROM Student WHERE StdId = @StdId";

            using (SqlCommand command = new SqlCommand(query, connect))
            {
                command.Parameters.AddWithValue("@StdId", studentId);
                try
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            studentInfo = $"ID: {reader["StdId"]}, Name: {reader["StdFirstName"]} {reader["StdLastName"]}, BirthDate: {reader["Birthdate"]},Gender: {reader["Gender"]}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }

            return studentInfo;
        }
        private string GenerateEvaluationText(int studentId)
        {
            string query = "SELECT AVG(Grade) AS AverageGrade FROM GRADES WHERE StdId = @StdId";
            using (SqlCommand command = new SqlCommand(query, connect))
            {
                command.Parameters.AddWithValue("@StdId", studentId);
                connect.Open();
                object result = command.ExecuteScalar();
                connect.Close();

                if (result != DBNull.Value)
                {
                    double averageGrade = Convert.ToDouble(result);
                    string gradeJudgment = GetGradeJudgment(averageGrade);
                    return $"Average Grade: {averageGrade:F2}\r\nJudgment: {gradeJudgment}";
                }
            }
            return "No grades available.";
        }

        private void PrintEvaluationText(string evaluationText)
        {
            MessageBox.Show(evaluationText, "Evaluation");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }






    }
}
