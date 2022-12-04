using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourCurrent = int.Parse(Console.ReadLine());
            int minCurrent = int.Parse(Console.ReadLine());
            int min = minCurrent + 30;
            if(minCurrent < 30)
            {
                Console.WriteLine($"{hourCurrent}:{min:d2}");
            }
            else
            {
                if(hourCurrent == 23)
                {
                    hourCurrent = 0;
                    Console.WriteLine($"{hourCurrent}:{min - 60:d2}");
                }
                else
                {
                    Console.WriteLine($"{hourCurrent + 1}:{min - 60:d2}");
                }
            }
        }
    }
}
