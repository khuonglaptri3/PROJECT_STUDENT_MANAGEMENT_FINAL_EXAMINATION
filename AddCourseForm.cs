using PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION;
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
    public partial class AddCourseForm : Form
    {
        //Teacher course = new Teacher();
        Course course = new Course();

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        public AddCourseForm()
        {

            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button_add_Click(object sender, EventArgs e)
        {
            //if (textBox_Cname.Text == "" || textBox_Chour.Text == "")
            //{
            //    MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    string cName = textBox_Cname.Text;
            //    //int chr = Convert.ToInt32(textBox_Chour.Text);
            //    string desc = textBox_description.Text;
            //    int hr = Convert.ToInt32(textBox_Chour.Text);
            //    Teacher teacher = new Teacher();
            //    //string test = course.insertstudent(connect, student);
            //    if (teacher.insertcourse(connect, course, cName, hr, desc) == "True")
            //    {
            //        showData();
            //        button_clear.PerformClick();
            //        MessageBox.Show("New course inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    else
            //    {
            //        MessageBox.Show("Course not insert", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Cname.Clear();
            textBox_Chour.Clear();
            textBox_description.Clear();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            //to show course list on datagridview
            //DataGridView_course.DataSource = course.getCourse(new SqlCommand("SELECT * FROM `course`"));
            //DataGridView_course.DataSource = course.GetCourse(new SqlCommand("SELECT * FROM [course]"));
            DataGridView_course.DataSource = course.GetCourses();

        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            if (textBox_Cname.Text == "" || textBox_Chour.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cName = textBox_Cname.Text;
                string desc = textBox_description.Text;
                int hr = Convert.ToInt32(textBox_Chour.Text);

                if (course.InsertCourse(cName, hr, desc))
                {
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("New course inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course not inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
