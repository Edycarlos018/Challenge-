using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class Badge
    {
        public string FullName { get; set; }
        public string IdNumber { get; set; }
        public List<string> DoorList { get; set; }

        public Badge(string fullName, string idNumber, List<string> doorList)
        {
            FullName = fullName;
            IdNumber = idNumber;
            DoorList = doorList;
        }
        public Badge()
        {
            DoorList = new List<string>();
        }
    }
}
