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
    public partial class PrintTeacher : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");

        public PrintTeacher()
        {
            InitializeComponent();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT* FROM teacher";
            }
            else if (radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM teacher WHERE Gender = 'Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM teacher WHERE Gender = 'Female'";
            }
            Administrator administrator = new Administrator();
            DataGridView_student.DataSource = administrator.GetTeacherList(connect, selectQuery);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "HCMUTE student  list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_student);
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

        private void button_search_Click_1(object sender, EventArgs e)
        {
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT* FROM teacher";
            }
            else if (radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM teacher WHERE Gender = 'Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM teacher WHERE Gender = 'Female'";
            }
            Administrator administrator = new Administrator();
            DataGridView_student.DataSource = administrator.GetTeacherList(connect, selectQuery);
        }

        private void button_print_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "HCMUTE teacher list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_student);
        }

        private void DataGridView_student_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_search_Click_2(object sender, EventArgs e)
        {
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT* FROM teacher";
            }
            else if (radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM teacher WHERE Gender = 'Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM teacher WHERE Gender = 'Female'";
            }
            Administrator administrator = new Administrator();
            DataGridView_student.DataSource = administrator.GetTeacherList(connect, selectQuery);
        }

        private void button_print_Click_2(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "HCMUTE teacher list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_student);
        }
    }
}
