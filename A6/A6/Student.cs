// A6, David Lu, CIS 345, T-TH 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    [Serializable]
    public class Student
    {
        private string name;
        private string id;

        public Student()
        {
            this.name = "";
            this.id = "";
        }

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"{Name} {Id}";
        }
    }
}
