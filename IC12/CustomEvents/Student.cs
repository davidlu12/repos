// IC12, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEvents
{
    [Serializable]
    public class Student
    {
        private string name;
        private string id;
        private BindingList<Course> courses;

        public Student()
        {
            this.name = "";
            this.id = "";
            Courses = new BindingList<Course>();
        }

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
            Courses = new BindingList<Course>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public BindingList<Course> Courses { get => courses; set => courses = value; }

        public override string ToString()
        {
            return name;
        }

    }
}
