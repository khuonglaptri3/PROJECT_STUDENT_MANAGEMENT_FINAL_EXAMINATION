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
    public partial class Addcourse : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        private int tchId;
        public Addcourse(int tchId)
        {
            InitializeComponent();
            this.tchId = tchId;
            Teacher teacher = new Teacher(tchId, connect);
            DataGridView_course.DataSource = teacher.GetCourse(connect, tchId);
            string query = "SELECT DISTINCT CourseName FROM Course WHERE TeachID IS NULL OR TeachID <> @tchId";
            comboBox_course.DataSource = teacher.GetCourse(connect, tchId, query);
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName";
        }

        bool verify()
        {
            if (string.IsNullOrEmpty(textBox_Chour.Text) || string.IsNullOrEmpty(textBox_description.Text) || string.IsNullOrEmpty(comboBox_course.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int Chour = int.Parse(textBox_Chour.Text);
            Course course = new Course(comboBox_course.Text.Trim(), tchId, tchId, Chour, textBox_description.Text.Trim());
            Teacher teacher1 = new Teacher(tchId, connect);
            if (verify())
            {
                if (teacher1.AddCourse(course, connect))
                {
                    MessageBox.Show("Add course successfully");
                    DataGridView_course.DataSource = teacher1.GetCourse(connect, tchId);
                    string query = "SELECT DISTINCT CourseName FROM Course WHERE TeachID IS NULL OR TeachID <> @tchId";
                    comboBox_course.DataSource = teacher1.GetCourse(connect, tchId, query);
                    comboBox_course.DisplayMember = "CourseName";
                    comboBox_course.ValueMember = "CourseName";
                }
                else
                {
                    MessageBox.Show("Add course failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void DataGridView_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            comboBox_course.Text = "";
            textBox_Chour.Text = "";
            textBox_description.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm teacherForm = new TeacherForm(tchId);
            teacherForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}