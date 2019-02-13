// IC17_DLL, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IC17_DLL
{
    public class Person
    {
        private string name;

        /// <summary>
        /// Name of the person
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Makes the person run at a given speed
        /// </summary>
        /// <param name="speed">Speed at which the person is supposed to run, in miles per hour</param>
        public void Run (int speed)
        {
            WriteLine("Running at {0} mph", speed);
        }
    }
}
