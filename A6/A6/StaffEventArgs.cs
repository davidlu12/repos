// A6, David Lu, CIS 345, T-TH 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    // Wrapper Class for staff
    public class StaffEventArgs : EventArgs
    {
        private Staff staff;

        public StaffEventArgs(Staff staff)
        {
            this.staff = staff;
        }

        public Staff Staff { get => staff; set => staff = value; }
    }
}
