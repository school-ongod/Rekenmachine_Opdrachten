using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine_Opdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                Console.WriteLine($"Welkom {args[0].ToString()}");
            }
            else
            {
                Console.WriteLine("Geef je naam in als argument");
            }
            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy - HH:mm:ss"));
        }
    }
}
