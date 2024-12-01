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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            //DisplayStudentName();
        }
        private int studentID;

        public StudentForm(int studentId)
        {
            InitializeComponent();
            this.studentID = studentId;
            DisplayStudentName();

            // Use studentId as needed, for example, to load student-specific data
        }
        private void hideSubMenu()
        {
            if (button_courseandgrade.Visible == true)
                button_courseandgrade.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void button_enrollincourse_Click(object sender, EventArgs e)
        {
            EnrollInCourseForm newCourse = new EnrollInCourseForm();
            this.Hide();
            newCourse.ShowDialog();
            this.Close();

            hideSubMenu();

        }
        #region CourseAndGrades_SubMenu   
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_tch_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_subcourse);
        }

        private void button_Registrationtch_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button_managetch_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button_printtch_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion CourseAndGrades_SubMenu
        private void button_viewcourse_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void DisplayStudentName()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT StdFirstName, StdLastName FROM Student WHERE StdId = @StdId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StdId", studentID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string firstName = reader["StdFirstName"].ToString();
                        string lastName = reader["StdLastName"].ToString();
                        label3.Text = $"Welcome {firstName} {lastName}";
                    }
                    else
                    {
                        MessageBox.Show("No student found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving student name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            //DisplayStudentName();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
