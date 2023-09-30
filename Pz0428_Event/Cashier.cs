using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz0428_Event
{
    internal class Cashier
    {
        public Cashier()
        {
            Gai.penalty += GaiPenalty;
            Gai.premium += GaiPremium;
        }

        void GaiPenalty(Driver driver, int speed)
        {
            Console.WriteLine($"Cashir: Get penalty for driver {driver.Name}");
        }

        void GaiPremium(Driver driver, int speed)
        {
            Console.WriteLine($"Cashir: Set premium for driver {driver.Name}");
        }
    }
}
