namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    partial class TeacherForm
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
            this.Femaletxt = new System.Windows.Forms.Label();
            this.Total_stdtxt = new System.Windows.Forms.Label();
            this.Panel_subscore = new System.Windows.Forms.Panel();
            this.button_printsore = new System.Windows.Forms.Button();
            this.button_managescore = new System.Windows.Forms.Button();
            this.button_newscore = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Maletxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_score = new System.Windows.Forms.Button();
            this.panel_subcourse = new System.Windows.Forms.Panel();
            this.button_stdPrintcourse = new System.Windows.Forms.Button();
            this.button_managecourse = new System.Windows.Forms.Button();
            this.button_newcourse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HCMUTE = new System.Windows.Forms.Label();
            this.button_course = new System.Windows.Forms.Button();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_subscore.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_subcourse.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_slide.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Femaletxt
            // 
            this.Femaletxt.AutoSize = true;
            this.Femaletxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Femaletxt.Location = new System.Drawing.Point(123, 45);
            this.Femaletxt.Name = "Femaletxt";
            this.Femaletxt.Size = new System.Drawing.Size(97, 27);
            this.Femaletxt.TabIndex = 8;
            this.Femaletxt.Text = "Female: ";
            // 
            // Total_stdtxt
            // 
            this.Total_stdtxt.AutoSize = true;
            this.Total_stdtxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_stdtxt.Location = new System.Drawing.Point(6, 0);
            this.Total_stdtxt.Name = "Total_stdtxt";
            this.Total_stdtxt.Size = new System.Drawing.Size(171, 27);
            this.Total_stdtxt.TabIndex = 6;
            this.Total_stdtxt.Text = "Total Students: ";
            // 
            // Panel_subscore
            // 
            this.Panel_subscore.Controls.Add(this.button_printsore);
            this.Panel_subscore.Controls.Add(this.button_managescore);
            this.Panel_subscore.Controls.Add(this.button_newscore);
            this.Panel_subscore.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_subscore.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_subscore.Location = new System.Drawing.Point(0, 440);
            this.Panel_subscore.Name = "Panel_subscore";
            this.Panel_subscore.Size = new System.Drawing.Size(212, 204);
            this.Panel_subscore.TabIndex = 3;
            // 
            // button_printsore
            // 
            this.button_printsore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_printsore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_printsore.Location = new System.Drawing.Point(0, 134);
            this.button_printsore.Name = "button_printsore";
            this.button_printsore.Size = new System.Drawing.Size(212, 67);
            this.button_printsore.TabIndex = 5;
            this.button_printsore.Text = "Print";
            this.button_printsore.UseVisualStyleBackColor = true;
            this.button_printsore.Click += new System.EventHandler(this.button_printsore_Click);
            // 
            // button_managescore
            // 
            this.button_managescore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managescore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managescore.Location = new System.Drawing.Point(0, 67);
            this.button_managescore.Name = "button_managescore";
            this.button_managescore.Size = new System.Drawing.Size(212, 67);
            this.button_managescore.TabIndex = 4;
            this.button_managescore.Text = "Manage";
            this.button_managescore.UseVisualStyleBackColor = true;
            this.button_managescore.Click += new System.EventHandler(this.button_managescore_Click);
            // 
            // button_newscore
            // 
            this.button_newscore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newscore.Location = new System.Drawing.Point(0, 0);
            this.button_newscore.Name = "button_newscore";
            this.button_newscore.Size = new System.Drawing.Size(212, 67);
            this.button_newscore.TabIndex = 3;
            this.button_newscore.Text = "New Score";
            this.button_newscore.UseVisualStyleBackColor = true;
            this.button_newscore.Click += new System.EventHandler(this.button_newscore_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.Controls.Add(this.Femaletxt);
            this.panel4.Controls.Add(this.Maletxt);
            this.panel4.Controls.Add(this.Total_stdtxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(212, 546);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1074, 100);
            this.panel4.TabIndex = 9;
            // 
            // Maletxt
            // 
            this.Maletxt.AutoSize = true;
            this.Maletxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maletxt.Location = new System.Drawing.Point(17, 45);
            this.Maletxt.Name = "Maletxt";
            this.Maletxt.Size = new System.Drawing.Size(75, 27);
            this.Maletxt.TabIndex = 7;
            this.Maletxt.Text = "Male: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Role: Teacher";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome";
            // 
            // button_score
            // 
            this.button_score.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_score.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_score.Location = new System.Drawing.Point(0, 389);
            this.button_score.Name = "button_score";
            this.button_score.Size = new System.Drawing.Size(212, 51);
            this.button_score.TabIndex = 3;
            this.button_score.Text = "Score";
            this.button_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_score.UseVisualStyleBackColor = true;
            this.button_score.Click += new System.EventHandler(this.button_score_Click);
            // 
            // panel_subcourse
            // 
            this.panel_subcourse.Controls.Add(this.button_stdPrintcourse);
            this.panel_subcourse.Controls.Add(this.button_managecourse);
            this.panel_subcourse.Controls.Add(this.button_newcourse);
            this.panel_subcourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_subcourse.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_subcourse.Location = new System.Drawing.Point(0, 185);
            this.panel_subcourse.Name = "panel_subcourse";
            this.panel_subcourse.Size = new System.Drawing.Size(212, 204);
            this.panel_subcourse.TabIndex = 2;
            // 
            // button_stdPrintcourse
            // 
            this.button_stdPrintcourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_stdPrintcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stdPrintcourse.Location = new System.Drawing.Point(0, 134);
            this.button_stdPrintcourse.Name = "button_stdPrintcourse";
            this.button_stdPrintcourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_stdPrintcourse.Size = new System.Drawing.Size(212, 67);
            this.button_stdPrintcourse.TabIndex = 5;
            this.button_stdPrintcourse.Text = "Print";
            this.button_stdPrintcourse.UseVisualStyleBackColor = true;
            this.button_stdPrintcourse.Click += new System.EventHandler(this.button_stdPrintcourse_Click);
            // 
            // button_managecourse
            // 
            this.button_managecourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managecourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managecourse.Location = new System.Drawing.Point(0, 67);
            this.button_managecourse.Name = "button_managecourse";
            this.button_managecourse.Size = new System.Drawing.Size(212, 67);
            this.button_managecourse.TabIndex = 4;
            this.button_managecourse.Text = "Manage";
            this.button_managecourse.UseVisualStyleBackColor = true;
            this.button_managecourse.Click += new System.EventHandler(this.button_managecourse_Click);
            // 
            // button_newcourse
            // 
            this.button_newcourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newcourse.Location = new System.Drawing.Point(0, 0);
            this.button_newcourse.Name = "button_newcourse";
            this.button_newcourse.Size = new System.Drawing.Size(212, 67);
            this.button_newcourse.TabIndex = 3;
            this.button_newcourse.Text = "New Course";
            this.button_newcourse.UseVisualStyleBackColor = true;
            this.button_newcourse.Click += new System.EventHandler(this.button_newcourse_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(212, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1074, 83);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(212, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 80);
            this.panel1.TabIndex = 7;
            // 
            // HCMUTE
            // 
            this.HCMUTE.AutoSize = true;
            this.HCMUTE.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HCMUTE.Location = new System.Drawing.Point(48, 41);
            this.HCMUTE.Name = "HCMUTE";
            this.HCMUTE.Size = new System.Drawing.Size(102, 27);
            this.HCMUTE.TabIndex = 2;
            this.HCMUTE.Text = "HCMUTE";
            // 
            // button_course
            // 
            this.button_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_course.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_course.Location = new System.Drawing.Point(0, 118);
            this.button_course.Name = "button_course";
            this.button_course.Size = new System.Drawing.Size(212, 67);
            this.button_course.TabIndex = 1;
            this.button_course.Text = "Course";
            this.button_course.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_course.UseVisualStyleBackColor = true;
            this.button_course.Click += new System.EventHandler(this.button_std_Click);
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.SpringGreen;
            this.panel_slide.Controls.Add(this.Panel_subscore);
            this.panel_slide.Controls.Add(this.button_score);
            this.panel_slide.Controls.Add(this.panel_subcourse);
            this.panel_slide.Controls.Add(this.button_course);
            this.panel_slide.Controls.Add(this.panel2);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(212, 646);
            this.panel_slide.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.HCMUTE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 118);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1049, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 646);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_slide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.Panel_subscore.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_subcourse.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_slide.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Femaletxt;
        private System.Windows.Forms.Label Total_stdtxt;
        private System.Windows.Forms.Panel Panel_subscore;
        private System.Windows.Forms.Button button_printsore;
        private System.Windows.Forms.Button button_managescore;
        private System.Windows.Forms.Button button_newscore;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Maletxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_score;
        private System.Windows.Forms.Panel panel_subcourse;
        private System.Windows.Forms.Button button_stdPrintcourse;
        private System.Windows.Forms.Button button_managecourse;
        private System.Windows.Forms.Button button_newcourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HCMUTE;
        private System.Windows.Forms.Button button_course;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}