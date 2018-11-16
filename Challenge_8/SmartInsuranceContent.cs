using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_8
{
    class SmartInsuranceContent
    {
        public int DriverAge { get; set; }
        public int Drink { get; set; }
        public int CloseAccident { get; set; }
        public int StopSign { get; set; }
        public int LateForWork { get; set; }
        public int HadAccident { get; set; }

        public SmartInsuranceContent(int driverAge, int drink, int closeAccident, int stopSign, int lateForWork, int hadAccident)
        {
            DriverAge = driverAge;
            Drink = drink;
            CloseAccident = closeAccident;
            StopSign = stopSign;
            LateForWork = lateForWork;
            HadAccident = hadAccident;
        }
        public SmartInsuranceContent()
        {

        }
    }
}
