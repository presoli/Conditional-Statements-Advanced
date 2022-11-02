using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (fruit)
            {
                case "banana":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{(2.5 * quantity):f2}");
                            break;

                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{(2.7 * quantity):f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "apple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{(1.2 * quantity):f2}");
                            break;

                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{(1.25 * quantity):f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "orange":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{(0.85 * quantity):f2}");
                            break;

                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{(0.9 * quantity):f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "grapefruit":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{(1.45 * quantity):f2}");
                            break;

                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{(1.6 * quantity):f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "kiwi":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{(2.7 * quantity):f2}");
                            break;

                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{(3 * quantity):f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "pineapple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{(5.5 * quantity):f2}");
                            break;

                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{(5.6 * quantity):f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "grapes":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine($"{(3.85 * quantity):f2}");
                            break;

                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine($"{(4.2 * quantity):f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;

            }
        }
    }
}