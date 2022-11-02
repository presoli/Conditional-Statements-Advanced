using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double revenue = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (revenue >= 0 && revenue <= 500)
                {
                    Console.WriteLine($"{(0.05 * revenue):f2}");
                }
                else if (revenue > 500 && revenue <=1000)
                {
                    Console.WriteLine($"{(0.07 * revenue):f2}");
                }
                else if (revenue > 1000 && revenue <= 10_000)
                {
                    Console.WriteLine($"{(0.08 * revenue):f2}");
                }
                else if (revenue > 10_000)
                {
                    Console.WriteLine($"{(0.12 * revenue):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (revenue >= 0 && revenue <= 500)
                {
                    Console.WriteLine($"{(0.045 * revenue):f2}");
                }
                else if (revenue > 500 && revenue <= 1000)
                {
                    Console.WriteLine($"{(0.075 * revenue):f2}");
                }
                else if (revenue > 1000 && revenue <= 10_000)
                {
                    Console.WriteLine($"{(0.1 * revenue):f2}");
                }
                else if (revenue > 10_000)
                {
                    Console.WriteLine($"{(0.13 * revenue):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (revenue >= 0 && revenue <= 500)
                {
                    Console.WriteLine($"{(0.055 * revenue):f2}");
                }
                else if (revenue > 500 && revenue <= 1000)
                {
                    Console.WriteLine($"{(0.08 * revenue):f2}");
                }
                else if (revenue > 1000 && revenue <= 10_000)
                {
                    Console.WriteLine($"{(0.12 * revenue):f2}");
                }
                else if (revenue > 10_000)
                {
                    Console.WriteLine($"{(0.145 * revenue):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}