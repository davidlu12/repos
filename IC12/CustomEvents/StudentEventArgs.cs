// IC12, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEvents
{
    class StudentEventArgs : EventArgs
    {
        private Student student;

        public StudentEventArgs(Student student)
        {
            this.student = student;
        }

        public Student Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }




    }
}
