using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length >= 2)
            {
                int arg1 = int.Parse(args[0]);
                int arg2 = int.Parse(args[1]);
                int result = arg1 + arg2;
                Console.WriteLine("{0} + {1} = {2}.", arg1, arg2, result);
            }
            else
            {
                Console.WriteLine("Gebruik: sum <getal1> <getal2>");
            }
        }
    }
}
