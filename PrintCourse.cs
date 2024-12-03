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
    public partial class PrintCourse : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        private int tchId;
        private DGVPrinter printer = new DGVPrinter();
        public PrintCourse(int tchId)
        {
            InitializeComponent();
            this.tchId = tchId;
            Teacher teacher = new Teacher(tchId, connect);
            DataGridView_student.DataSource = teacher.GetCourse(connect, tchId);
        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(tchId, connect);
            DataGridView_student.DataSource = teacher.searchCourse(connect, textBox_search.Text.Trim(), tchId);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_print_Click(object sender, EventArgs e)

        {
            Teacher teacher = new Teacher(tchId, connect);
            printer.Title = $" The Course of {teacher.PrintDetails()} teach :  ";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Mdemy";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_student);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm teacherForm = new TeacherForm(tchId);    
            teacherForm.Show();
            this.Close(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
