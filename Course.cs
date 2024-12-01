using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_STUDENT_MANAGEMENT_FINAL_EXAMINATION
{
    public class Course
    {
        private string courseName;
        private int courseId;
        private int teacherId;
        private int coureseHour;
        private string courseDescription;
        public string COURSENAME
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public int COURSEID
        {
            get { return courseId; }
            set { courseId = value; }
        }
        public int TEACHERID
        {
            get { return teacherId; }
            set { teacherId = value; }
        }
        public int COURSEHOUR
        {
            get { return coureseHour; }
            set { coureseHour = value; }
        }
        public string COURSEDESCRIPTION
        {
            get { return courseDescription; }
            set { courseDescription = value; }
        }
        public Course()
        {
            courseName = default;
            courseId = default;
            teacherId = default;
            coureseHour = default;
            courseDescription = default;
        }
        public Course(string courseName, int courseId, int teacherId, int courseHour, string courseDescription)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.teacherId = teacherId;
            this.coureseHour = courseHour;
            this.courseDescription = courseDescription;
        }
        public Course(string courseName, int teacherId, int courseHour, string courseDescription)
        {
            this.courseName = courseName;
            this.teacherId = teacherId;
            this.coureseHour = courseHour;
            this.courseDescription = courseDescription;
        }

    }
}
