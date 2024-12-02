using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper; 
namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public partial class Print_Score_TeacherForm : Form
    {
        private int tchId;
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        public Print_Score_TeacherForm(int tchId)
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

        private void Print_Score_TeacherForm_Load(object sender, EventArgs e)
        { 
            
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(tchId, connect);
            DataGridView_score.DataSource = teacher.Get_score_student(connect, comboBox_course.Text.Trim(), tchId);  
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(tchId, connect);
            DGVPrinter printer = new DGVPrinter();
            DataGridView_score.DataSource = teacher.Get_score_student(connect, comboBox_course.Text.Trim(), tchId);
       
            printer.Title = $"{teacher.LASTNAME} {teacher.FIRSTNAME} {teacher.GetDayOfBirth}  {comboBox_course.Text.Trim()}";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "OOP";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_score);
        }

        private void DataGridView_score_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
