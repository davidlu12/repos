// IC12, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEvents
{
    [Serializable]
    public class Course
    {
        private string courseName;
        private string courseID;
        private int credits;

        public Course()
        {
            this.courseName = "";
            this.courseID = "";
            this.credits = 0;
        }

        public Course(string courseName, string courseID, int credits)
        {
            this.courseName = courseName;
            this.courseID = courseID;
            this.credits = credits;
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public string CourseID
        {
            get
            {
                return courseID;
            }

            set
            {
                courseID = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public override string ToString()
        {
            return $"{courseID} - {courseName}";
        }

    }

}
