using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz0428_Delegate
{
    internal class Calculator
    {
        public static string Add(int x, int y)
        {
            return $"Sum: {x} + {y} = {x + y}\n";
        }

        public static string Subtract(int x, int y)
        {
            return $"Subtract: {x} - {y} = {x - y}\n";
        }
    }
}
