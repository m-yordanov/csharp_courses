using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNum = int.MaxValue;
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number < minNum)
                {
                    minNum = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
