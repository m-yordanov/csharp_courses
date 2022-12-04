using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cakeIntegrity = width * length;
            string input = "";
            while (cakeIntegrity > 0)
            {
                input = Console.ReadLine();
                if(input != "STOP")
                {
                    cakeIntegrity -= int.Parse(input);
                    if (cakeIntegrity < 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(0 - cakeIntegrity)} pieces more.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{cakeIntegrity} pieces are left.");
                    break;
                }
            }
        }
    }
}
