using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pz0428_Event
{
    internal class Clerk
    {
        public Clerk()
        {
            Gai.penalty += GaiPenalty;
            Gai.premium += GaiPremium;
        }

        void GaiPenalty(Driver driver, int speed)
        {
            Console.WriteLine($"Clerk: Penalty for driver {driver.Name}");
        }

        void GaiPremium(Driver driver, int speed)
        {
                Console.WriteLine($"Clerk: Premium for driver {driver.Name}");
        }
    }
}
