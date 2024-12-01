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
    public partial class ManagerCourseForm : Form

    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        private int TchId;
        public ManagerCourseForm(int tchId)
        {
            InitializeComponent();
            this.TchId = tchId;
            Teacher teacher = new Teacher(tchId, connect);
            DataGridView_course.DataSource = teacher.GetCourse(connect, tchId);
        }
        private bool verify()
        {
            if (textBox_id.Text.Trim() == "" || textBox_Chour.Text.Trim() == "" || textBox_Cname.Text.Trim() == "" || textBox_description.Text.Trim() == "")
            {
                return false;
            }
            else
                return true;
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(TchId, connect);
            DataGridView_course.DataSource = teacher.searchCourse(connect, textBox_search.Text.Trim(), TchId);

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (!int.TryParse(textBox_Chour.Text, out int CourseHour))
            {
                MessageBox.Show("Invalid Course Hour. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(textBox_id.Text, out int courseId))
            {
                MessageBox.Show("Invalid Course ID. Please enter a valid number.");
                return;
            }

            Course course = new Course(textBox_Cname.Text.Trim(), courseId, TchId, CourseHour, textBox_description.Text.Trim());
            Teacher teacher = new Teacher(TchId, connect);

            if (teacher.updateCourse(connect, course))
            {
                MessageBox.Show("Update course successfully");
                DataGridView_course.DataSource = teacher.GetCourse(connect, TchId);
            }
            else
            {
                MessageBox.Show("Update course failed");
            }
        }

        private void DataGridView_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            connect.Close();
            int courseId = Int32.Parse(textBox_id.Text);
            if (textBox_id.Text.Trim() == "")
            {
                MessageBox.Show("Enter The Course ID to delete");
            }
            else
            {
                try
                {

                    Teacher teacher = new Teacher(TchId, connect);
                    if (teacher.deleteCourse(connect, courseId, TchId))
                    {
                        MessageBox.Show("Delete course successfully");
                        DataGridView_course.DataSource = teacher.GetCourse(connect, TchId);
                    }
                    else
                    {
                        MessageBox.Show("Delete course failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Chour.Text = "";
            textBox_Cname.Text = "";
            textBox_description.Text = "";
            textBox_id.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm teacherForm = new TeacherForm(TchId);
            teacherForm.ShowDialog();
        }
    }
}
