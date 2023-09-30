using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz0428_Event
{
    delegate void Premium(Driver driver, int speed);
    delegate void Penalty(Driver driver, int speed);
    internal class Gai
    {
        const int SPEED_BORDER = 60;
        public static event Premium premium;
        public static event Penalty penalty;

        public static void MeasureSpeed(Driver driver, int speed)
        {
            if(speed <= SPEED_BORDER && premium != null)
                premium(driver, speed);
            else if(penalty != null)
                penalty(driver, speed);
        }
    }
}
