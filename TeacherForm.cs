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
    public partial class TeacherForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        private int tchId;
        private Teacher teacher;
        public TeacherForm(int tchId)
        {
            InitializeComponent();
            customizeDesign();
            this.tchId = tchId;
            teacher = new Teacher(tchId, connect);
            label3.Text = "Welcome " + teacher.PrintDetails();
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
        private void hideSubMenu()
        {
            if (Panel_subscore.Visible == true)
                Panel_subscore.Visible = false;
            if (panel_subcourse.Visible == true)
                panel_subcourse.Visible = false;
        }
        private void customizeDesign()
        {
            Panel_subscore.Visible = false;
            panel_subcourse.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }
        #region subMenu_Course 
        private void button_std_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_subcourse);
        }
        private void button_newcourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addcourse addcourse = new Addcourse(tchId);
            addcourse.Show();
            this.Close(); 
            hideSubMenu();
        }

        private void button_managecourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerCourseForm managerCourseForm = new ManagerCourseForm(tchId);
            managerCourseForm.Show();
            hideSubMenu();
            this.Close();
        }

        private void button_stdPrintcourse_Click(object sender, EventArgs e)

        {
            this.Hide();
            PrintCourse printCourse = new PrintCourse(tchId);
            printCourse.Show();
            this.Close(); 
            hideSubMenu();
        }
        #endregion subMenu_Course 
        #region SubMenu_Score
        private void button_score_Click(object sender, EventArgs e)
        {
            showSubMenu(Panel_subscore);
        }

        private void button_newscore_Click(object sender, EventArgs e)
        {
            this.Hide();    
            TeacherScoreForm teacherScoreForm = new TeacherScoreForm(tchId); 
            teacherScoreForm.Show();
            this.Close();   
            hideSubMenu();
        }

        private void button_managescore_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button_printsore_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print_Score_TeacherForm print_Score_TeacherForm = new Print_Score_TeacherForm(tchId);   
             
            print_Score_TeacherForm.ShowDialog();    
            hideSubMenu();
            this.Close(); 
        }
        #endregion SubMenu_Score    

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
