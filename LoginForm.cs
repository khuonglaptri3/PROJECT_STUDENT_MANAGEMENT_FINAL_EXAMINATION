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
namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\School.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");
        private Student student;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = showpass.Checked ? '\0' : '*';
        }

        private void Loginbut_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please fill in the required information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    if (Studentrar.Checked)
                    {
                        String selectData1 = "SELECT * FROM studentUsers Where username = @username AND password = @password";
                        using (SqlCommand cmd1 = new SqlCommand(selectData1, connect1))
                        {
                            // dflsfjskfjlksjf

                            cmd1.Parameters.AddWithValue("@username", Username.Text.Trim());
                            cmd1.Parameters.AddWithValue("@password", Password.Text.Trim());
                            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                            DataTable table1 = new DataTable();
                            adapter1.Fill(table1);
                            if (table1.Rows.Count >= 1)
                            {
                              
                                MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                StudentForm studentForm = new StudentForm(student);

                                studentForm.Show();
                                this.Hide();
                            }
                        }
                    }
                    else if (Teacherrarbut.Checked)
                    {
                        string selectData = "SELECT * FROM teacherUsers Where username = @username AND password = @password";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect1))
                        {
                            cmd.Parameters.AddWithValue("@username", Username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", Password.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {

                                MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TeacherForm teacherForm = new TeacherForm();
                                teacherForm.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        String selectData = "SELECT * FROM users Where username = @username AND password = @password";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", Username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", Password.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                
                                    MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AdminForm adminForm = new AdminForm(); 
                                    adminForm.Show();    
                                    this.Hide();
                               

                            }
                        }
                    }
                    #region comment_code 
                    //String selectData = "SELECT * FROM users Where username = @username AND password = @password";
                    //using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    //{
                    //    cmd.Parameters.AddWithValue("@username", Username.Text.Trim());
                    //    cmd.Parameters.AddWithValue("@password", Password.Text.Trim());
                    //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //    DataTable table = new DataTable();
                    //    adapter.Fill(table);
                    //    if (table.Rows.Count >= 1)
                    //    {
                    //        if (Teacherrarbut.Checked)
                    //        {
                    //            MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //            TeacherForm teacherForm = new TeacherForm();
                    //            teacherForm.Show();
                    //            this.Hide();
                    //        }
                    //        else if (Studentrar.Checked)
                    //        {
                    //            MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //            StudentForm studentForm = new StudentForm(student);

                    //            studentForm.Show();
                    //            this.Hide();
                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //            AdminForm adminForm = new AdminForm();
                    //            adminForm.Show();
                    //            this.Hide();
                    //        }
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Login Failed ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    #endregion comment_code  
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adminrarbut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Registerbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Teacherrarbut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Studentrar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
