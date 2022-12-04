using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double sum = 0;
            while (input != "NoMoreMoney")
            {
                input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    break;
                }
                double added = double.Parse(input);
                if (added < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    sum += added;
                    Console.WriteLine($"Increase: {added:f2}");
                    continue;
                }
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
