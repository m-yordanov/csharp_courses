using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Calculate(operation, num1, num2);
        }

        private static void Calculate(string operation, int num1, int num2)
        {
            if (operation == "subtract")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (operation == "add")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (operation == "divide")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (operation == "multiply")
            {
                Console.WriteLine(num1 * num2);
            }
        }
    }
}
