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

    public partial class AdminForm : Form
    {
        private int admin; 
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        private SqlConnection connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\School.mdf;Integrated Security=True;Connect Timeout=30");
        private Administrator Administrator1 = new Administrator();
        public AdminForm(int admin ) 
        {
            this.admin = admin; 
            InitializeComponent();
            customizeDesign();
            Total_studenttxt.Text = Administrator1.coutstudent(connect, "SELECT COUNT(*) FROM student").ToString();
            Total_femaletxt.Text = Administrator1.coutstudent(connect, "SELECT COUNT(*) FROM student WHERE  Gender = 'Female'").ToString();
            Totalmaletxt.Text = Administrator1.coutstudent(connect, "SELECT COUNT(*) FROM   student WHERE Gender = 'Male'").ToString();
            comboBox_course.DataSource = Administrator1.getCourse(connect, "SELECT * FROM Course");
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName";
            Administrator administrator = new Administrator(connect1 , admin);
            label3.Text = administrator.PrintDetails(); 
        }
        private void customizeDesign()
        {
            panel_substd.Visible = false;
            Panel_subtch.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel_substd.Visible == true)
                panel_substd.Visible = false;
            if (Panel_subtch.Visible == true)
                Panel_subtch.Visible = false;
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
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        #region Student_SubMenu  
        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_substd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();     
            ManegerStudentForm manegerStudentForm = new ManegerStudentForm(admin);
            manegerStudentForm.ShowDialog();
            hideSubMenu();
            this.Close();

        }

        private void button_registrationstd_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(admin);
            this.Hide();     
            registerForm.ShowDialog();
            this.Close();

            hideSubMenu();


        }


        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            PrintStudent printStudent = new PrintStudent(admin);
            printStudent.ShowDialog();
            hideSubMenu();
            this.Close(); 
        }
        #endregion Student_SubMenu   
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Teacher_SubMenu 
        private void button_tch_Click(object sender, EventArgs e)
        {
            showSubMenu(Panel_subtch);
        }

        private void button_Registrationtch_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            RegistratorTeacher registerteacherForm = new RegistratorTeacher(admin );
            registerteacherForm.ShowDialog();
            this.Close();

            hideSubMenu();

        }

        private void button_managetch_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            hideSubMenu();
            TeacherManageForm teacherManageForm = new TeacherManageForm(admin);
            teacherManageForm.ShowDialog();
            this.Close(); 
            //hideSubMenu();
        }

        private void button_printtch_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintTeacher printTeacher = new PrintTeacher(admin);
            
            printTeacher.ShowDialog();
            hideSubMenu();
            this.Close();
        }
        #endregion Teacher_SubMenu   

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_cover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_cmale_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = comboBox_course.Text.Trim(); // Trim any leading or trailing spaces

            // Use parameterized queries to avoid SQL injection and syntax errors
            string maleQuery = "SELECT COUNT(*) FROM student INNER JOIN GRADES ON GRADES.StdId = student.StdId WHERE GRADES.CourseId = (SELECT CourseID FROM Course WHERE CourseName = @CourseName) AND student.Gender = 'Male'";
            string femaleQuery = "SELECT COUNT(*) FROM student INNER JOIN GRADES ON GRADES.StdId = student.StdId WHERE GRADES.CourseId = (SELECT CourseID FROM Course WHERE CourseName = @CourseName) AND student.Gender = 'Female'";

            //label_cmale.Text = "Male : " + Administrator1.coutstudent(connect, maleQuery, selectedCourse).ToString();
            //label_cfemale.Text = "Female : " + Administrator1.coutstudent(connect, femaleQuery, selectedCourse).ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HCMUTE_Click(object sender, EventArgs e)
        {

        }
    }
}
