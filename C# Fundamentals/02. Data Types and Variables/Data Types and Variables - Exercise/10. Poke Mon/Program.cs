using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int newN = 0;
            int Y = int.Parse(Console.ReadLine());
            int count = 0;
            while (N > int.MinValue)
            {
                if(N == newN && Y != 0)
                {
                    N /= Y;
                    if (N < M)
                    {
                        break;
                    }
                }
                N -= M;
                newN += M;
                count++;
                if (N < M)
                {
                    break;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
