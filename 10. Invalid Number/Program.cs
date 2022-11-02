using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 100 && num != 0 || num > 200 && num != 0)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}