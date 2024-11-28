using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data; 
using System.Data.SqlClient; 
namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lanph\OneDrive\Tệp đính kèm\Tài liệu\School.mdf"";Integrated Security=True;Connect Timeout=30");
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
                            if(Teacherrarbut.Checked)
                            {
                                MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TeacherForm teacherForm = new TeacherForm();
                                teacherForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Login Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                StudentForm studentForm = new StudentForm();
                                studentForm.Show();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
