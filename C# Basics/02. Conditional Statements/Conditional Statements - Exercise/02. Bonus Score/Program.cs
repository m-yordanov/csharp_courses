using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (num > 1000)
            {
                bonus = 0.10 * num; 
            }
            else if (num > 100)
            {
                bonus = 0.20 * num;
            }
            else if (num <= 100)
            {
                bonus = 5;
            }
            if (num % 2 == 0)
            {
                bonus += 1;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
