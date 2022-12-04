using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger max = BigInteger.MinusOne;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;
            for (int i = 1; i <= N; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > max)
                {
                    max = snowballValue;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {max} ({maxQuality})");
        }
    }
}
