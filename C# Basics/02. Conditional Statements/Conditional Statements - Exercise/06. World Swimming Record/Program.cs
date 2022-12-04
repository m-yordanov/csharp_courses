using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            double delay = meters / 15;
            delay = Math.Floor(delay);
            double overallTime = (meters * seconds) + (delay * 12.5);
            if (overallTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {overallTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - overallTime):f2} seconds slower.");
            }
        }
    }
}
