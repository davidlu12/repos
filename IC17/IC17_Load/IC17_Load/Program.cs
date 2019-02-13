// IC17_Load, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IC17_DLL;

namespace IC17_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "David";
            Console.WriteLine(person.Name);
            person.Run(100);
            Console.ReadKey();
        }
    }
}
