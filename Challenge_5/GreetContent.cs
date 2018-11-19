using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public enum TypeofGreet {Potential = 1, Current , Past}
    class GreetContent
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int Response { get; set; }
        public TypeofGreet Type { get; set; }

        public GreetContent(string customerFirstName, string customerLastName, TypeofGreet type, int response)
        {
            Type = type;
            CustomerFirstName = customerFirstName;
            CustomerLastName = customerLastName;
            Response = response;
        }
        public GreetContent()
        {

        }
    }
}
