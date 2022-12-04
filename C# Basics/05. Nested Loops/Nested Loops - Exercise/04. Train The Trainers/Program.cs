using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double presentationEv = 0;
            double presentationCount = 0;
            double presentationAvg = 0;
            string input = Console.ReadLine();
            while (input != "Finish")
            {
                presentationCount++;
                presentationEv = 0;
                for (int i = 1; i <= n; i++)
                {
                    presentationEv += double.Parse(Console.ReadLine());
                }
                presentationEv /= n;
                presentationAvg += presentationEv;
                Console.WriteLine($"{input} - {presentationEv:f2}.");
                input = Console.ReadLine();
            }
            presentationAvg /= presentationCount;
            Console.WriteLine($"Student's final assessment is {presentationAvg:f2}.");
        }
    }
}
