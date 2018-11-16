using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class BadgeContent
    {
        public int IdNumber { get; set; }
        public List<string> DoorList { get; set; }

        public BadgeContent(int idNumber, List<string> doorList)
        {
            IdNumber = idNumber;
            DoorList = doorList;
        }
        public BadgeContent()
        {
        }
    }
}
