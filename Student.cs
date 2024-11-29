using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Student : Person
    {
        private string studentID;
        private List<string> courses;
        private Dictionary<string, string> grades;//courses va grades

        public Student(int id, string firstName, string lastName,bool gender, Date dateofBirth, string studentID,string contactInfo) : base(id,firstName,lastName,gender,dateofBirth, contactInfo)
        {
            this.studentID = studentID;
            this.courses = new List<string>();
            this.grades = new Dictionary<string, string>();
        }
        public string GetStudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string EnrollInCourse(string course)
        {
            if(courses.Contains(course))
            {
                courses.Add(course);
                return $"Sucessfully enrolled course {course}";
            }
            return $"Failed to enroll course{course}";
        }

    }
}