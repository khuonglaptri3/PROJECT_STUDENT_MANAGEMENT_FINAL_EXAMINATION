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
    public partial class StudentForm : Form
    {

        private int StdId; 
        public StudentForm(int StdId)
        {
            InitializeComponent();
            this.StdId = StdId; 
            label3.Text = "Welcome :" + StdId.ToString();    



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
            //EnrollInCourseForm newCourse = new EnrollInCourseForm();
            this.Hide();
            //newCourse.ShowDialog();
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

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
