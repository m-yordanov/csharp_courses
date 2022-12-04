using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int num2 = 0;
            while (sum < num)
            {
                num2 = int.Parse(Console.ReadLine());
                sum += num2;
            }
            Console.WriteLine(sum);
        }
    }
}
