// A6, David Lu, CIS 345, T-TH 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    [Serializable]
    public class Staff
    {
        private string staffName;
        private string staffID;

        public Staff()
        {
            this.staffName = "";
            this.staffID = "";
        }

        public Staff(string staffName, string staffID)
        {
            this.staffName = staffName;
            this.staffID = staffID;
        }

        public string StaffName { get => staffName; set => staffName = value; }
        public string StaffID { get => staffID; set => staffID = value; }

        public override string ToString()
        {
            return $"{staffName} {StaffID}";
        }
    }
}
