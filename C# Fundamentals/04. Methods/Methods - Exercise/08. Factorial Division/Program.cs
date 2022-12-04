using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double Factorial1 = GetFactorial(Math.Abs(num1));
            double Factorial2 = GetFactorial(Math.Abs(num2));
            Console.WriteLine($"{Factorial1/Factorial2:f2}");
        }
        static double GetFactorial(int num)
        {
            double result = num;
            for(int i = num-1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
