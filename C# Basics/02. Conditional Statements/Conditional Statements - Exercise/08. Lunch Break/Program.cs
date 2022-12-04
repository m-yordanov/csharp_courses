using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());
            double seriesTime = lunchBreak * 5 / 8.0;
            if (seriesTime >= episode)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(seriesTime - episode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(episode - seriesTime)} more minutes.");
            }
        }
    }
}
