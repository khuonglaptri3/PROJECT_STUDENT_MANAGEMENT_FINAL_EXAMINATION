using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Grade
    {
        private int gradeId;
        private int stdId;
        private int courseId;
        private int gradeValue;
        private string courseName;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }


        public int GradeId
        {
            get { return gradeId; }
            set { gradeId = value; }
        }

        public int StdId
        {
            get { return stdId; }
            set { stdId = value; }
        }

        public int CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public int GradeValue
        {
            get { return gradeValue; }
            set { gradeValue = value; }
        }

        public Grade(int gradeId, int stdId, int courseId, int gradeValue)
        {
            this.gradeId = gradeId;
            this.stdId = stdId;
            this.courseId = courseId;
            this.gradeValue = gradeValue;
        }
        public Grade(int stdId , int courseId, int gradeValue , string courseName)
        {
            this.stdId = stdId;
            this.courseId = courseId;
            this.gradeValue = gradeValue;
            CourseName = courseName;
        }
        public Grade(int stdId, int gradeValue, string courseName)
        {
            this.stdId = stdId;
            this.courseId = courseId;
            this.gradeValue = gradeValue;
            CourseName = courseName;
        }
    }
}