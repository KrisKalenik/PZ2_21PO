using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz0428_Event
{
    internal class Execute
    {
        public static void Run()
        {
            Clerk clerk = new Clerk();
            Cashier cashier = new Cashier();

            Driver driver1 = new Driver("Ivanov");
            Driver driver2 = new Driver("Petrov");
            Driver driver3 = new Driver("Sidorov");

            Gai.MeasureSpeed(driver1, 50);
            Console.WriteLine();
            Gai.MeasureSpeed(driver2, 60);
            Console.WriteLine();
            Gai.MeasureSpeed(driver3, 100);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
