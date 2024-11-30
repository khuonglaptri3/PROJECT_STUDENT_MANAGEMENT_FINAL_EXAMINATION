using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Student : Person
    {

        private string phone; 
        private List<string> courses;
        private Dictionary<string, string> grades;//courses va grades

       public string PHONE
        {
            get { return phone;  } 
            set { phone = value;  }
        }
        public Student ()
        {
            FIRSTNAME = default;
            LASTNAME = default;
            GENDER = default;
            GetDayOfBirth = default;
            PHONE = default;
            ADDRESS = default; 
        }
        public Student (string FirstName , string LastName , string address ,  string gender , DateTime dateofbirth , string phone )
        {
            FIRSTNAME = FirstName;
            LASTNAME = LastName;
            GENDER = gender;
            GetDayOfBirth = dateofbirth;
            PHONE = phone;
            ADDRESS = address; 
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