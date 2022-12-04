using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int hours = amount * 3;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {amount} project/s.");
        }
    }
}
