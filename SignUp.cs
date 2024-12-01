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
    public partial class SignUp : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\School.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\SYS_MANAGERMENT.mdf;Integrated Security=True;Connect Timeout=30");

        public SignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registerbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sign_upBut_Click(object sender, EventArgs e)
        {
            if (connect1.State != ConnectionState.Open)
            {
                try
                {
                    connect1.Open();
                    String CheckUsernamestd = "SELECT * FROM studentUsers WHERE username = @username";
                    String CheckUsernametch = "SELECT * FROM teacherUsers WHERE username = @username";
                    String CheckIDSTD = "SELECT * FROM student WHERE StdId = @StdId";
                    String CheckIDTCH = "SELECT * FROM teacher WHERE tchdId = @tchdId";

                    if (Studentrar.Checked)
                    {
                        using (SqlCommand CheckUser = new SqlCommand(CheckUsernamestd, connect1))
                        {
                            CheckUser.Parameters.AddWithValue("@username", Username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(CheckUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(Username.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                using (SqlCommand CheckStdId = new SqlCommand(CheckIDSTD, connect1))
                                {
                                    CheckStdId.Parameters.AddWithValue("@StdId", Idtxt.Text.Trim());
                                    SqlDataAdapter adapter1 = new SqlDataAdapter(CheckStdId);
                                    DataTable table1 = new DataTable();
                                    adapter1.Fill(table1);
                                    if (table1.Rows.Count < 1)
                                    {
                                        MessageBox.Show("Student ID does not exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        string insertData = "INSERT INTO studentUsers (username, password, StdId) VALUES (@username, @password, @StdId)";
                                        using (SqlCommand cmd = new SqlCommand(insertData, connect1))
                                        {
                                            cmd.Parameters.AddWithValue("@username", Username.Text.Trim());
                                            cmd.Parameters.AddWithValue("@password", Password.Text.Trim());
                                            cmd.Parameters.AddWithValue("@StdId", Idtxt.Text.Trim());
                                            cmd.ExecuteNonQuery();
                                            MessageBox.Show("Register Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Hide();
                                            LoginForm loginForm = new LoginForm();
                                            loginForm.Show();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (Teacherrarbut.Checked)
                    {
                        using (SqlCommand CheckUser = new SqlCommand(CheckUsernametch, connect1))
                        {
                            CheckUser.Parameters.AddWithValue("@username", Username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(CheckUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(Username.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                using (SqlCommand CheckId = new SqlCommand(CheckIDTCH, connect1))
                                {
                                    CheckId.Parameters.AddWithValue("@tchdId", Idtxt.Text.Trim());
                                    SqlDataAdapter adapter1 = new SqlDataAdapter(CheckId);
                                    DataTable table1 = new DataTable();
                                    adapter1.Fill(table1);
                                    if (table1.Rows.Count < 1)
                                    {
                                        MessageBox.Show("Teacher ID does not exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        string insertData = "INSERT INTO teacherUsers (username, password, TeacherId) VALUES (@username, @password, @TeacherId)";
                                        using (SqlCommand cmd = new SqlCommand(insertData, connect1))
                                        {
                                            cmd.Parameters.AddWithValue("@username", Username.Text.Trim());
                                            cmd.Parameters.AddWithValue("@password", Password.Text.Trim());
                                            cmd.Parameters.AddWithValue("@TeacherId", Idtxt.Text.Trim());
                                            cmd.ExecuteNonQuery();
                                            MessageBox.Show("Register Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Hide();
                                            LoginForm loginForm = new LoginForm();
                                            loginForm.Show();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select the type of account you want to register", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect1.Close();
                }
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = showpass.Checked ? '\0' : '*';
        }

        private void Teacherrarbut_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
