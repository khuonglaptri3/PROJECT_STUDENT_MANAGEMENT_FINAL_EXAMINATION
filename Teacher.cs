using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Teacher : Person
    {
        private string teacherID;
        private List<string> subjectTaught = new List<string>();

        public Teacher(int id, string firstName, string lastName, bool gender, Date dateofBirth, string teacherID, string contactInfo) : base (id, firstName, lastName, gender, dateofBirth, contactInfo)
        {
            this.teacherID = teacherID;
        }
        public string GetTeacherID
        {
            get { return teacherID; }
            set { teacherID = value; }
        }

    }
}