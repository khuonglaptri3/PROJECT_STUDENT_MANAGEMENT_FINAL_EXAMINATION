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
    public partial class ManegerStudentForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        public ManegerStudentForm()
        {
            InitializeComponent();
            Administrator administrator = new Administrator();
            DataGridView_student.DataSource = administrator.GetStudentList(connect);
        }
        private bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == "") )
            {
                return false;
            }
            else
                return true;
        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close(); 
           AdminForm ad = new AdminForm();
            ad.ShowDialog();   
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            Administrator administrator = new Administrator();
            if (administrator.deletestudent(connect, id))
            {
                MessageBox.Show("Delete student successfully");
                DataGridView_student.DataSource = administrator.GetStudentList(connect);
            }
            else
            {
                MessageBox.Show("Delete student failed");
            }
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_id.Text, out int id))
            {
                string fname = textBox_Fname.Text;
                string lname = textBox_Lname.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = textBox_phone.Text;
                string address = textBox_address.Text;
                string gender = radioButton_male.Checked ? "Male" : "Female";
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verify())
                {
                    Student student = new Student(fname, lname, address, gender, bdate, phone);
                    Administrator administrator = new Administrator();
                    if (administrator.updatestudent(connect, student, id))
                    {
                        MessageBox.Show("Update student successfully");
                        DataGridView_student.DataSource = administrator.GetStudentList(connect);
                    }
                    else
                    {
                        MessageBox.Show("Update student failed");
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid ID format", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = new Administrator().Seachstudent(connect, textBox_search.Text);   
        }
       
    }
}
