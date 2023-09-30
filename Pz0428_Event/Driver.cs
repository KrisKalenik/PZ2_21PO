using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz0428_Event
{
    internal class Driver
    {
        public string Name { get; set; }

        public Driver(string name)
        {
            Name = name;
            Gai.penalty += new Penalty(GaiPenalty);
            Gai.premium += GaiPremium;
        }

        void GaiPenalty(Driver driver, int speed)
        {
            if (driver == this)
                Console.WriteLine($"Driver {Name} thanks for penalty");
        }

        void GaiPremium(Driver driver, int speed)
        {
            if (driver == this)
                Console.WriteLine($"Driver {Name} is greatfull for premium");
        }
    }
}
