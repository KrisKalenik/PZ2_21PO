using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Pz0428_Delegate
{
    delegate string Arithmetics(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetics arithmetics;
            arithmetics = new Arithmetics(Calculator.Add);
            Console.WriteLine( arithmetics(3, 4) );

            arithmetics = new Arithmetics(Calculator.Subtract);
            Console.WriteLine(arithmetics(3, 4));

            arithmetics = new Arithmetics(Calculator.Add);
            arithmetics += new Arithmetics(Calculator.Subtract);
            arithmetics += new Arithmetics(Calculator.Add);
            Console.WriteLine(arithmetics(3, 4));

            CallDelegat(10, 20, arithmetics);
            CallDelegat(10, 20, Calculator.Add);

            Console.ReadLine();

        }

        static void CallDelegat(int x, int y, Arithmetics arithmetics)
        {
            Console.WriteLine(arithmetics(x, y));
        }
    }
}
