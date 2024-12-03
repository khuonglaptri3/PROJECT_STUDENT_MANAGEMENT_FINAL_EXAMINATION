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
    public partial class TeacherScoreForm : Form
    {
        private int tchId;
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");

        public TeacherScoreForm(int tchId)
        {
            InitializeComponent();
            DataGridView_score.ReadOnly = false;
            this.tchId = tchId;
            Teacher teacher = new Teacher(tchId, connect);
            string query = "SELECT CourseName FROM Course WHERE TeachID = @tchId";
            comboBox_course.DataSource = teacher.GetCourse(connect, tchId, query);
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName";
            
        }

        private void TeacherScoreForm_Load(object sender, EventArgs e)
        {
            // Optionally, you can trigger the event manually to load data for the initially selected course
            comboBox_course_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(tchId, connect);
            DataGridView_score.DataSource = teacher.Get_score_student(connect, comboBox_course.Text.Trim(), tchId);
        }

        private void DataGridView_score_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(tchId, connect); 
            int STDID = int .Parse(textBox_stdId.Text.Trim());
            string courseName = comboBox_course.Text.Trim();
            int gradeValue = int.Parse(textBox_score.Text.Trim());
            Grade grade = new Grade(STDID,gradeValue, courseName);
            if(teacher.add_score_student(connect,grade, tchId))
            {
                MessageBox.Show("Add score successfully");
                DataGridView_score.DataSource = teacher.Get_score_student(connect, comboBox_course.Text.Trim(), tchId);
            }
            else
            {
                MessageBox.Show("Add score failed");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            comboBox_course.Text = "";
            textBox_stdId.Text = "";
            textBox_score.Text = "";    

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_score_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_stdId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm teacherForm = new TeacherForm(tchId);    
            teacherForm.ShowDialog(); 
            this.Close();    
        }
    }
}
