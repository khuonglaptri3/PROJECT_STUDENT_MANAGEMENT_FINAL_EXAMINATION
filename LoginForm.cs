using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION.SchoolSysDBDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    //public partial class LoginForm : Form
    //{
    //    //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\School.mdf;Integrated Security=True;Connect Timeout=30");
    //    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trant\source\repos\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\School.mdf;Integrated Security=True;Connect Timeout=30");
    //    public LoginForm()
    //    {
    //        InitializeComponent();
    //    }

    //    private void label1_Click(object sender, EventArgs e)
    //    {
    //        Application.Exit();
    //    }

    //    private void showpass_CheckedChanged(object sender, EventArgs e)
    //    {
    //        Password.PasswordChar = showpass.Checked ? '\0' : '*';
    //    }

    //    private void Loginbut_Click(object sender, EventArgs e)
    //    {
//            if (Username.Text == "" || Password.Text == "")
//            {
//                MessageBox.Show("Please fill in the required information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            else
//{
//    try
//    {
//        connect.Open();
//        String selectData = "SELECT * FROM users Where username = @username AND password = @password";
//        using (SqlCommand cmd = new SqlCommand(selectData, connect))
//        {
//            cmd.Parameters.AddWithValue("@username", Username.Text.Trim());
//            cmd.Parameters.AddWithValue("@password", Password.Text.Trim());
//            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//            DataTable table = new DataTable();
//            adapter.Fill(table);
//            if (table.Rows.Count >= 1)
//            {
//                if (Teacherrarbut.Checked)
//                {
//                    MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    TeacherForm teacherForm = new TeacherForm();
//                    teacherForm.Show();
//                    this.Hide();
//                }
//                else if (Studentrar.Checked)
//                {
//                    MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    StudentForm studentForm = new StudentForm();
//                    studentForm.Show();
//                    this.Hide();
//                }
//                else
//                {
//                    MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    AdminForm adminForm = new AdminForm();
//                    adminForm.Show();
//                    this.Hide();
//                }
//            }
//            else
//            {
//                MessageBox.Show("Login Failed ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show("Error connecting Database : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//    finally
//    {
//        connect.Close();
//    }

//}
//    }

//    private void panel2_Paint(object sender, PaintEventArgs e)
//    {

//    }

//    private void Password_TextChanged(object sender, EventArgs e)
//    {

//    }

//    private void Adminrarbut_CheckedChanged(object sender, EventArgs e)
//    {

//    }

//    private void Registerbut_Click(object sender, EventArgs e)
//    {
//        this.Hide();
//        SignUp signUp = new SignUp();   
//        signUp.Show();
//    }

//    private void panel3_Paint(object sender, PaintEventArgs e)
//    {

//    }

//    private void label6_Click(object sender, EventArgs e)
//    {

//    }

//    private void Username_TextChanged(object sender, EventArgs e)
//    {

//    }

//    private void Teacherrarbut_CheckedChanged(object sender, EventArgs e)
//    {

//    }

//    private void label4_Click(object sender, EventArgs e)
//    {

//    }

//    private void Studentrar_CheckedChanged(object sender, EventArgs e)
//    {

//    }

//    private void label3_Click(object sender, EventArgs e)
//    {

//    }

//    private void label2_Click(object sender, EventArgs e)
//    {

//    }

//    private void panel1_Paint(object sender, PaintEventArgs e)
//    {

//    }

//    private void label5_Click(object sender, EventArgs e)
//    {

//    }

//    private void label7_Click(object sender, EventArgs e)
//    {

//    }
//}
public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trant\source\repos\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\School.mdf;Integrated Security=True;Connect Timeout=30");
        StudentClass student = new StudentClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_usrname.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please fill in the required information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    String selectData = "SELECT * FROM users Where username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox_usrname.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", textBox_password.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count >= 1)
                        {
                            if (teacherRadioButton.Checked)
                            {
                                MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TeacherForm teacherForm = new TeacherForm();
                                teacherForm.Show();
                                this.Hide();
                            }
                            else if (studentRadioButton.Checked)
                            {
                                MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                StudentForm studentForm = new StudentForm();
                                studentForm.Show();
                                this.Hide();
                            }
                            else if(adminRadioButton.Checked)
                            {
                                MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm adminForm = new MainForm();
                                adminForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Failed ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
