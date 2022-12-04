using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int n1 = 0; n1 <= n; n1++)
            {
                for (int n2 = 0; n2 <= n; n2++)
                {
                    for(int n3 = 0; n3 <= n; n3++)
                    {
                        if (n1 + n2 + n3 == n)
                        {
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
