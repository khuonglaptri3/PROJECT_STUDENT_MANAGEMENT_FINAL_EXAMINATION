namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    //partial class LoginForm
    //{
    //    /// <summary>
    //    /// Required designer variable.
    //    /// </summary>
    //    private System.ComponentModel.IContainer components = null;

    //    /// <summary>
    //    /// Clean up any resources being used.
    //    /// </summary>
    //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    #region Windows Form Designer generated code

    //    /// <summary>
    //    /// Required method for Designer support - do not modify
    //    /// the contents of this method with the code editor.
    //    /// </summary>
    //    private void InitializeComponent()
    //    {
    //        this.panel2 = new System.Windows.Forms.Panel();
    //        this.panel3 = new System.Windows.Forms.Panel();
    //        this.Registerbut = new System.Windows.Forms.Button();
    //        this.label7 = new System.Windows.Forms.Label();
    //        this.label6 = new System.Windows.Forms.Label();
    //        this.Adminrarbut = new System.Windows.Forms.RadioButton();
    //        this.Studentrar = new System.Windows.Forms.RadioButton();
    //        this.Teacherrarbut = new System.Windows.Forms.RadioButton();
    //        this.showpass = new System.Windows.Forms.CheckBox();
    //        this.Loginbut = new System.Windows.Forms.Button();
    //        this.Password = new System.Windows.Forms.TextBox();
    //        this.Username = new System.Windows.Forms.TextBox();
    //        this.label5 = new System.Windows.Forms.Label();
    //        this.label4 = new System.Windows.Forms.Label();
    //        this.label3 = new System.Windows.Forms.Label();
    //        this.label1 = new System.Windows.Forms.Label();
    //        this.label2 = new System.Windows.Forms.Label();
    //        this.panel1 = new System.Windows.Forms.Panel();
    //        this.panel2.SuspendLayout();
    //        this.panel3.SuspendLayout();
    //        this.panel1.SuspendLayout();
    //        this.SuspendLayout();
    //        // 
    //        // panel2
    //        // 
    //        this.panel2.BackColor = System.Drawing.Color.PaleGreen;
    //        this.panel2.Controls.Add(this.panel3);
    //        this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
    //        this.panel2.Location = new System.Drawing.Point(0, 30);
    //        this.panel2.Name = "panel2";
    //        this.panel2.Size = new System.Drawing.Size(550, 570);
    //        this.panel2.TabIndex = 1;
    //        this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
    //        // 
    //        // panel3
    //        // 
    //        this.panel3.BackColor = System.Drawing.Color.MintCream;
    //        this.panel3.Controls.Add(this.Registerbut);
    //        this.panel3.Controls.Add(this.label7);
    //        this.panel3.Controls.Add(this.label6);
    //        this.panel3.Controls.Add(this.Adminrarbut);
    //        this.panel3.Controls.Add(this.Studentrar);
    //        this.panel3.Controls.Add(this.Teacherrarbut);
    //        this.panel3.Controls.Add(this.showpass);
    //        this.panel3.Controls.Add(this.Loginbut);
    //        this.panel3.Controls.Add(this.Password);
    //        this.panel3.Controls.Add(this.Username);
    //        this.panel3.Controls.Add(this.label5);
    //        this.panel3.Controls.Add(this.label4);
    //        this.panel3.Controls.Add(this.label3);
    //        this.panel3.Location = new System.Drawing.Point(40, 69);
    //        this.panel3.Name = "panel3";
    //        this.panel3.Size = new System.Drawing.Size(440, 421);
    //        this.panel3.TabIndex = 0;
    //        this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
    //        // 
    //        // Registerbut
    //        // 
    //        this.Registerbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.Registerbut.ForeColor = System.Drawing.Color.IndianRed;
    //        this.Registerbut.Location = new System.Drawing.Point(234, 361);
    //        this.Registerbut.Name = "Registerbut";
    //        this.Registerbut.Size = new System.Drawing.Size(142, 36);
    //        this.Registerbut.TabIndex = 11;
    //        this.Registerbut.Text = "Register here";
    //        this.Registerbut.UseVisualStyleBackColor = true;
    //        this.Registerbut.Click += new System.EventHandler(this.Registerbut_Click);
    //        // 
    //        // label7
    //        // 
    //        this.label7.AutoSize = true;
    //        this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
    //        this.label7.ForeColor = System.Drawing.Color.Black;
    //        this.label7.Location = new System.Drawing.Point(46, 370);
    //        this.label7.Name = "label7";
    //        this.label7.Size = new System.Drawing.Size(167, 18);
    //        this.label7.TabIndex = 10;
    //        this.label7.Text = "Don\'t have an account ?";
    //        this.label7.Click += new System.EventHandler(this.label7_Click);
    //        // 
    //        // label6
    //        // 
    //        this.label6.AutoSize = true;
    //        this.label6.Location = new System.Drawing.Point(0, 0);
    //        this.label6.Name = "label6";
    //        this.label6.Size = new System.Drawing.Size(44, 16);
    //        this.label6.TabIndex = 9;
    //        this.label6.Text = "label6";
    //        this.label6.Click += new System.EventHandler(this.label6_Click);
    //        // 
    //        // Adminrarbut
    //        // 
    //        this.Adminrarbut.AutoSize = true;
    //        this.Adminrarbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.Adminrarbut.ForeColor = System.Drawing.Color.Black;
    //        this.Adminrarbut.Location = new System.Drawing.Point(113, 222);
    //        this.Adminrarbut.Name = "Adminrarbut";
    //        this.Adminrarbut.Size = new System.Drawing.Size(71, 20);
    //        this.Adminrarbut.TabIndex = 8;
    //        this.Adminrarbut.TabStop = true;
    //        this.Adminrarbut.Text = "Admin";
    //        this.Adminrarbut.UseVisualStyleBackColor = true;
    //        this.Adminrarbut.CheckedChanged += new System.EventHandler(this.Adminrarbut_CheckedChanged);
    //        // 
    //        // Studentrar
    //        // 
    //        this.Studentrar.AutoSize = true;
    //        this.Studentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.Studentrar.ForeColor = System.Drawing.Color.Black;
    //        this.Studentrar.Location = new System.Drawing.Point(296, 222);
    //        this.Studentrar.Name = "Studentrar";
    //        this.Studentrar.Size = new System.Drawing.Size(80, 20);
    //        this.Studentrar.TabIndex = 7;
    //        this.Studentrar.TabStop = true;
    //        this.Studentrar.Text = "Student";
    //        this.Studentrar.UseVisualStyleBackColor = true;
    //        this.Studentrar.CheckedChanged += new System.EventHandler(this.Studentrar_CheckedChanged);
    //        // 
    //        // Teacherrarbut
    //        // 
    //        this.Teacherrarbut.AutoSize = true;
    //        this.Teacherrarbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.Teacherrarbut.ForeColor = System.Drawing.Color.Black;
    //        this.Teacherrarbut.Location = new System.Drawing.Point(193, 222);
    //        this.Teacherrarbut.Name = "Teacherrarbut";
    //        this.Teacherrarbut.Size = new System.Drawing.Size(86, 20);
    //        this.Teacherrarbut.TabIndex = 6;
    //        this.Teacherrarbut.TabStop = true;
    //        this.Teacherrarbut.Text = "Teacher";
    //        this.Teacherrarbut.UseVisualStyleBackColor = true;
    //        this.Teacherrarbut.CheckedChanged += new System.EventHandler(this.Teacherrarbut_CheckedChanged);
    //        // 
    //        // showpass
    //        // 
    //        this.showpass.AutoSize = true;
    //        this.showpass.BackColor = System.Drawing.Color.DarkSeaGreen;
    //        this.showpass.ForeColor = System.Drawing.Color.Black;
    //        this.showpass.Location = new System.Drawing.Point(251, 262);
    //        this.showpass.Name = "showpass";
    //        this.showpass.Size = new System.Drawing.Size(125, 20);
    //        this.showpass.TabIndex = 2;
    //        this.showpass.Text = "Show Password";
    //        this.showpass.UseVisualStyleBackColor = false;
    //        this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
    //        // 
    //        // Loginbut
    //        // 
    //        this.Loginbut.BackColor = System.Drawing.Color.Teal;
    //        this.Loginbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.Loginbut.ForeColor = System.Drawing.Color.Black;
    //        this.Loginbut.Location = new System.Drawing.Point(25, 295);
    //        this.Loginbut.Name = "Loginbut";
    //        this.Loginbut.Size = new System.Drawing.Size(87, 41);
    //        this.Loginbut.TabIndex = 5;
    //        this.Loginbut.Text = "Log In";
    //        this.Loginbut.UseVisualStyleBackColor = false;
    //        this.Loginbut.Click += new System.EventHandler(this.Loginbut_Click);
    //        // 
    //        // Password
    //        // 
    //        this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.Password.Location = new System.Drawing.Point(26, 175);
    //        this.Password.Name = "Password";
    //        this.Password.PasswordChar = '*';
    //        this.Password.Size = new System.Drawing.Size(350, 31);
    //        this.Password.TabIndex = 4;
    //        this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
    //        // 
    //        // Username
    //        // 
    //        this.Username.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.Username.Location = new System.Drawing.Point(26, 109);
    //        this.Username.Name = "Username";
    //        this.Username.Size = new System.Drawing.Size(350, 29);
    //        this.Username.TabIndex = 3;
    //        this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
    //        // 
    //        // label5
    //        // 
    //        this.label5.AutoSize = true;
    //        this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label5.ForeColor = System.Drawing.Color.Black;
    //        this.label5.Location = new System.Drawing.Point(22, 153);
    //        this.label5.Name = "label5";
    //        this.label5.Size = new System.Drawing.Size(89, 19);
    //        this.label5.TabIndex = 2;
    //        this.label5.Text = "Password: ";
    //        this.label5.Click += new System.EventHandler(this.label5_Click);
    //        // 
    //        // label4
    //        // 
    //        this.label4.AutoSize = true;
    //        this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label4.ForeColor = System.Drawing.Color.Black;
    //        this.label4.Location = new System.Drawing.Point(22, 87);
    //        this.label4.Name = "label4";
    //        this.label4.Size = new System.Drawing.Size(90, 19);
    //        this.label4.TabIndex = 1;
    //        this.label4.Text = "Username:";
    //        this.label4.Click += new System.EventHandler(this.label4_Click);
    //        // 
    //        // label3
    //        // 
    //        this.label3.AutoSize = true;
    //        this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label3.ForeColor = System.Drawing.Color.Black;
    //        this.label3.Location = new System.Drawing.Point(177, 33);
    //        this.label3.Name = "label3";
    //        this.label3.Size = new System.Drawing.Size(102, 31);
    //        this.label3.TabIndex = 0;
    //        this.label3.Text = "Sign In ";
    //        this.label3.Click += new System.EventHandler(this.label3_Click);
    //        // 
    //        // label1
    //        // 
    //        this.label1.AutoSize = true;
    //        this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label1.Location = new System.Drawing.Point(522, 2);
    //        this.label1.Name = "label1";
    //        this.label1.Size = new System.Drawing.Size(25, 25);
    //        this.label1.TabIndex = 0;
    //        this.label1.Text = "X";
    //        this.label1.Click += new System.EventHandler(this.label1_Click);
    //        // 
    //        // label2
    //        // 
    //        this.label2.AutoSize = true;
    //        this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label2.Location = new System.Drawing.Point(3, 3);
    //        this.label2.Name = "label2";
    //        this.label2.Size = new System.Drawing.Size(322, 24);
    //        this.label2.TabIndex = 1;
    //        this.label2.Text = "School Management System | Log In";
    //        this.label2.Click += new System.EventHandler(this.label2_Click);
    //        // 
    //        // panel1
    //        // 
    //        this.panel1.BackColor = System.Drawing.Color.LightYellow;
    //        this.panel1.Controls.Add(this.label2);
    //        this.panel1.Controls.Add(this.label1);
    //        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
    //        this.panel1.ForeColor = System.Drawing.Color.Black;
    //        this.panel1.Location = new System.Drawing.Point(0, 0);
    //        this.panel1.Name = "panel1";
    //        this.panel1.Size = new System.Drawing.Size(550, 30);
    //        this.panel1.TabIndex = 0;
    //        this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
    //        // 
    //        // LoginForm
    //        // 
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.BackColor = System.Drawing.Color.Chartreuse;
    //        this.ClientSize = new System.Drawing.Size(550, 600);
    //        this.Controls.Add(this.panel2);
    //        this.Controls.Add(this.panel1);
    //        this.ForeColor = System.Drawing.Color.White;
    //        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    //        this.Name = "LoginForm";
    //        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    //        this.Text = "LoginForm";
    //        this.panel2.ResumeLayout(false);
    //        this.panel3.ResumeLayout(false);
    //        this.panel3.PerformLayout();
    //        this.panel1.ResumeLayout(false);
    //        this.panel1.PerformLayout();
    //        this.ResumeLayout(false);

    //    }

    //    #endregion

    //    private System.Windows.Forms.Panel panel2;
    //    private System.Windows.Forms.Panel panel3;
    //    private System.Windows.Forms.Button Registerbut;
    //    private System.Windows.Forms.Label label7;
    //    private System.Windows.Forms.Label label6;
    //    private System.Windows.Forms.RadioButton Adminrarbut;
    //    private System.Windows.Forms.RadioButton Studentrar;
    //    private System.Windows.Forms.RadioButton Teacherrarbut;
    //    private System.Windows.Forms.CheckBox showpass;
    //    private System.Windows.Forms.Button Loginbut;
    //    private System.Windows.Forms.TextBox Password;
    //    private System.Windows.Forms.TextBox Username;
    //    private System.Windows.Forms.Label label5;
    //    private System.Windows.Forms.Label label4;
    //    private System.Windows.Forms.Label label3;
    //    private System.Windows.Forms.Label label1;
    //    private System.Windows.Forms.Label label2;
    //    private System.Windows.Forms.Panel panel1;
    //}
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_usrname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.teacherRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 108);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(699, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 49);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(98, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mdemy International School";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(240, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Login First";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(77, 584);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(646, 47);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_usrname
            // 
            this.textBox_usrname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usrname.Location = new System.Drawing.Point(77, 457);
            this.textBox_usrname.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_usrname.Name = "textBox_usrname";
            this.textBox_usrname.Size = new System.Drawing.Size(646, 47);
            this.textBox_usrname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(69, 411);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(69, 537);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password :";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(77, 693);
            this.button_login.Margin = new System.Windows.Forms.Padding(6);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(650, 79);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(286, 158);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminRadioButton.Location = new System.Drawing.Point(76, 640);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(103, 29);
            this.adminRadioButton.TabIndex = 4;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            this.adminRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teacherRadioButton.Location = new System.Drawing.Point(332, 640);
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Size = new System.Drawing.Size(122, 29);
            this.teacherRadioButton.TabIndex = 5;
            this.teacherRadioButton.TabStop = true;
            this.teacherRadioButton.Text = "Teacher";
            this.teacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentRadioButton.Location = new System.Drawing.Point(606, 640);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(117, 29);
            this.studentRadioButton.TabIndex = 6;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 1044);
            this.Controls.Add(this.studentRadioButton);
            this.Controls.Add(this.teacherRadioButton);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_usrname);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_usrname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.RadioButton teacherRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
    }
}