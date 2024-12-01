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
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\School.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\trant\source\repos\PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION\School.mdf;Integrated Security=True;Connect Timeout=30");


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
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    String CheckUsername = " SELECT * FROM users  WHERE username = '" + Username.Text.Trim() + "' ";
                    using (SqlCommand CheckUser = new SqlCommand(CheckUsername, connect))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(CheckUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(Username.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password)  VALUES (@username, @password)";
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@username", Username.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", Password.Text.Trim());
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Register Successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connection Database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = showpass.Checked ? '\0' : '*'; 
        }
    }
}
