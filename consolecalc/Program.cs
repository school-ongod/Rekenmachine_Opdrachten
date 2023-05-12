using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolecalc
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length == 3)
            {
                double num1, num2, result;
                char op = char.Parse(args[1]);

                if (double.TryParse(args[0], out num1) && double.TryParse(args[2], out num2))
                {
                    switch (op)
                    {
                        case '+':
                            result = num1 + num2;
                            Console.WriteLine($"{num1} + {num2} = {result}");
                            break;
                        case '-':
                            result = num1 - num2;
                            Console.WriteLine($"{num1} - {num2} = {result}");
                            break;
                        case '*':
                            result = num1 * num2;
                            Console.WriteLine($"{num1} * {num2} = {result}");
                            break;
                        case '/':
                            if (num2 == 0)
                            {
                                Console.WriteLine("Kan niet delen door nul.");
                            }
                            else
                            {
                                result = num1 / num2;
                                Console.WriteLine($"{num1} / {num2} = {result}");
                            }
                            break;
                        default:
                            Console.WriteLine($"Ongeldige operator: {op}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer: beide argumenten moeten getallen zijn.");
                }
            }
            else
            {
                Console.WriteLine("Ongeldige invoer: voer twee getallen en een operator in, bijvoorbeeld 'consolecalc.exe 12 * 12'.");
            }
        }
    }
}