using System;
using System.Threading;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int seconds = 0; seconds <= 59; seconds++)
                    {
                        Console.WriteLine($"{hour:d2}:{minutes:d2}:{seconds:d2}");
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}

