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
    public partial class RegistratorTeacher : Form
    {
        public RegistratorTeacher()
        {
            InitializeComponent();
        }
        //private void RegistratorTeacher_Load(object sender, EventArgs e)
        //{
        //    Administrator administrator = new Administrator();
        //    DataGridView_student.ReadOnly = true;
        //    DataGridView_student.DataSource = administrator.GetTeacherList(connect);
        //    //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
        //    //imageColumn = (DataGridViewImageColumn)guna2DataGridView1.Columns[6];
        //    //imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        //}
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == "")
            )
            {
                return false;
            }
            else
                return true;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            // add new student
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 18 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The Teacher age must be between 18 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                Teacher teacher = new Teacher(fname, lname, address, gender, bdate, phone);
                Administrator administrator = new Administrator();
                string test = administrator.insertteacher(connect, teacher);
                if (test == "True")
                {
                    MessageBox.Show("New Teacher Added", "Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridView_student.DataSource = administrator.GetTeacherList(connect);
                }
                else
                {
                    Exception ex = new Exception();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Field", "Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistratorTeacher_Load_1(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            DataGridView_student.ReadOnly = true;
            DataGridView_student.DataSource = administrator.GetTeacherList(connect);
            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn = (DataGridViewImageColumn)guna2DataGridView1.Columns[6];
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
