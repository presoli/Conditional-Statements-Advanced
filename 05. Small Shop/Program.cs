using System;
using System.Reflection.Metadata;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(0.5 * quantity);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(0.4 * quantity);
                        break;
                    case "Varna":
                        Console.WriteLine(0.45 * quantity);
                        break;
                }
            }
            else if (product == "water")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(0.8 * quantity);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(0.7 * quantity);
                        break;
                    case "Varna":
                        Console.WriteLine(0.7 * quantity);
                        break;
                }
            }
            else if (product == "beer")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(1.2 * quantity);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(1.15 * quantity);
                        break;
                    case "Varna":
                        Console.WriteLine(1.1 * quantity);
                        break;
                }
            }
            else if (product == "sweets")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(1.45 * quantity);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(1.3 * quantity);
                        break;
                    case "Varna":
                        Console.WriteLine(1.35 * quantity);
                        break;
                }
            }
            else if (product == "peanuts")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(1.6 * quantity);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(1.5 * quantity);
                        break;
                    case "Varna":
                        Console.WriteLine(1.55 * quantity);
                        break;
                }
            }

        }
    }
}

