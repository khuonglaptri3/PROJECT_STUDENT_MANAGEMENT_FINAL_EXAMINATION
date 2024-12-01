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
        public EnrollInCourseForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30"))
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
    }
}
