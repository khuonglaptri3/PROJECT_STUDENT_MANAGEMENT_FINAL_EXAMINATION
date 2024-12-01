using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            customizeDesign(); 
        }
        private int teacherId;

        public TeacherForm(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            customizeDesign();
            // Use teacherId as needed, for example, to load teacher-specific data
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
            AddCourseForm addcourseForm = new AddCourseForm();
            this.Hide();
            addcourseForm.ShowDialog();
            this.Close();
            hideSubMenu();   
        }

        private void button_managecourse_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourse = new ManageCourseForm();
            this.Hide();
            manageCourse.ShowDialog();
            this.Close();
            hideSubMenu();   
        }

        private void button_stdPrintcourse_Click(object sender, EventArgs e)
        {
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
            hideSubMenu(); 
        }

        private void button_managescore_Click(object sender, EventArgs e)
        {
            hideSubMenu();   
        }

        private void button_printsore_Click(object sender, EventArgs e)
        {
            hideSubMenu();   
        }
        #endregion SubMenu_Score    

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }
    }
}
