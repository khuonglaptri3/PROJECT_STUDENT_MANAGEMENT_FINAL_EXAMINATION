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
    public partial class EnrollInCourseForm : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        private int stdId;  
        public EnrollInCourseForm(int stdId)
        {
            InitializeComponent();
            this.stdId = stdId;
            Student student = new Student(); 
            DataGridView_course.DataSource = student.GetCourses_Studied(connect , stdId);
            DataGridView_noncourse.DataSource = student.Get_course_not_study(connect, stdId);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                string query = "SELECT CourseName FROM Course WHERE CourseId = @CourseId";
                int courseId = 1;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", courseId);
                    connection.Open();
                    string courseName = (string)command.ExecuteScalar();
                    MessageBox.Show("Course Name: " + courseName);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Enrollbut_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            int courseId = int.Parse(course_IDtxt.Text.Trim());
            try
            {
                if(student.EnrollInCourse(connect, stdId, courseId))
                {
                    MessageBox.Show("Enroll course successfully");
                    DataGridView_course.DataSource = student.GetCourses_Studied(connect, stdId);
                    DataGridView_noncourse.DataSource = student.Get_course_not_study(connect, stdId);

                }
                else
                {
                    MessageBox.Show("Enroll course failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

