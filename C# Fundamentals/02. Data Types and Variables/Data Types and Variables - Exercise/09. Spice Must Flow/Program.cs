using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yieldOverall = int.Parse(Console.ReadLine());
            int spices = 0;
            int days = 0;
            int dayEnd = 0;
            while (yieldOverall >= 100)
            {
                days++;
                spices = yieldOverall - 26;
                yieldOverall -= 10;
                dayEnd += spices;
            }
            if (dayEnd >= 26)
            {
                dayEnd -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(dayEnd);
        }
    }
}
