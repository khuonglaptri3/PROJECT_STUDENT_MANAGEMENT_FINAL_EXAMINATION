﻿namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.Loginbut = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Teacherrarbut = new System.Windows.Forms.RadioButton();
            this.Studentrar = new System.Windows.Forms.RadioButton();
            this.Adminrarbut = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 30);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "School Management System | Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 570);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Controls.Add(this.Adminrarbut);
            this.panel3.Controls.Add(this.Studentrar);
            this.panel3.Controls.Add(this.Teacherrarbut);
            this.panel3.Controls.Add(this.showpass);
            this.panel3.Controls.Add(this.Loginbut);
            this.panel3.Controls.Add(this.Password);
            this.panel3.Controls.Add(this.Username);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(65, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 421);
            this.panel3.TabIndex = 0;
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.showpass.ForeColor = System.Drawing.Color.Black;
            this.showpass.Location = new System.Drawing.Point(214, 318);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(125, 20);
            this.showpass.TabIndex = 2;
            this.showpass.Text = "Show Password";
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // Loginbut
            // 
            this.Loginbut.BackColor = System.Drawing.Color.Teal;
            this.Loginbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbut.ForeColor = System.Drawing.Color.Black;
            this.Loginbut.Location = new System.Drawing.Point(252, 367);
            this.Loginbut.Name = "Loginbut";
            this.Loginbut.Size = new System.Drawing.Size(87, 41);
            this.Loginbut.TabIndex = 5;
            this.Loginbut.Text = "Log in ";
            this.Loginbut.UseVisualStyleBackColor = false;
            this.Loginbut.Click += new System.EventHandler(this.Loginbut_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(26, 199);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(350, 31);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(26, 123);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(350, 29);
            this.Username.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sign In ";
            // 
            // Teacherrarbut
            // 
            this.Teacherrarbut.AutoSize = true;
            this.Teacherrarbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacherrarbut.ForeColor = System.Drawing.Color.Black;
            this.Teacherrarbut.Location = new System.Drawing.Point(182, 253);
            this.Teacherrarbut.Name = "Teacherrarbut";
            this.Teacherrarbut.Size = new System.Drawing.Size(86, 20);
            this.Teacherrarbut.TabIndex = 6;
            this.Teacherrarbut.TabStop = true;
            this.Teacherrarbut.Text = "Teacher";
            this.Teacherrarbut.UseVisualStyleBackColor = true;
            // 
            // Studentrar
            // 
            this.Studentrar.AutoSize = true;
            this.Studentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentrar.ForeColor = System.Drawing.Color.Black;
            this.Studentrar.Location = new System.Drawing.Point(296, 253);
            this.Studentrar.Name = "Studentrar";
            this.Studentrar.Size = new System.Drawing.Size(80, 20);
            this.Studentrar.TabIndex = 7;
            this.Studentrar.TabStop = true;
            this.Studentrar.Text = "Student";
            this.Studentrar.UseVisualStyleBackColor = true;
            // 
            // Adminrarbut
            // 
            this.Adminrarbut.AutoSize = true;
            this.Adminrarbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminrarbut.ForeColor = System.Drawing.Color.Black;
            this.Adminrarbut.Location = new System.Drawing.Point(90, 253);
            this.Adminrarbut.Name = "Adminrarbut";
            this.Adminrarbut.Size = new System.Drawing.Size(71, 20);
            this.Adminrarbut.TabIndex = 8;
            this.Adminrarbut.TabStop = true;
            this.Adminrarbut.Text = "Admin";
            this.Adminrarbut.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(550, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Loginbut;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.RadioButton Studentrar;
        private System.Windows.Forms.RadioButton Teacherrarbut;
        private System.Windows.Forms.RadioButton Adminrarbut;
    }
}