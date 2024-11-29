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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            customizeDesign();   
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
            hideSubMenu();
        }

        private void button_registrationstd_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }
        

        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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
        #endregion Teacher_SubMenu   
    }
}
