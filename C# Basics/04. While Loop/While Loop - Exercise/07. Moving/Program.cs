using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            int metersAvailable = width * length * heigth;
            int metersUsed = 0;
            string input = "";
            while (metersAvailable > metersUsed)
            {
                input = Console.ReadLine();
                if (input != "Done")
                {
                    metersUsed += int.Parse(input);
                    if (metersUsed > metersAvailable)
                    {
                        Console.WriteLine($"No more free space! You need {metersUsed - metersAvailable} Cubic meters more.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{metersAvailable - metersUsed} Cubic meters left.");
                    break;
                }
            }
        }
    }
}
