using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            foreach (char i in num.ToString())
            {
                sum += (int)i;
            }
            Console.WriteLine(sum);
        }
    }
}
