// IC12, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEvents
{
    class CourseEventArgs : EventArgs
    {
        private Course course;

        public CourseEventArgs(Course course)
        {
            this.course = course;
        }

        public Course Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }
    }
}
