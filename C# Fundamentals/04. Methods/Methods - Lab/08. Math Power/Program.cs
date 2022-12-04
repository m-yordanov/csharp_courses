using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = GetPower(@base, power);
            Console.WriteLine(result);
        }
        static double GetPower(double @base, double power)
        {
            double result = Math.Pow(@base, power);
            return result;
        }
    }
}
