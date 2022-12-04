using System;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            foreach (string problem in input)
            {
                char firstLetter = problem[0];
                char secondLetter = problem[^1]; //equal to problem.Length - 1 
                string numberText = problem[1..^1]; // everything between 0 and the last index  
                double number = double.Parse(numberText.ToString());
                double operation = 0;
                if (Char.IsUpper(firstLetter))
                {
                    operation = number / (firstLetter - 64);
                }
                else
                {
                    operation = number * (firstLetter - 96);
                }
                if (Char.IsUpper(secondLetter))
                {
                    operation -= (secondLetter - 64);
                }
                else
                {
                    operation += (secondLetter - 96);
                }
                sum += operation;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
