// A6, David Lu, CIS 345, T-TH 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    // Wrapper class for Student
    public class StudentEventArgs : EventArgs
    {
        private Student student;

        public StudentEventArgs(Student student)
        {
            this.Student = student;
        }

        public Student Student { get => student; set => student = value; }
    }
}
