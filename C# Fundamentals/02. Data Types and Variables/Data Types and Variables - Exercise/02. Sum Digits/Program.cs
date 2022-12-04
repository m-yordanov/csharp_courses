using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string amount = num.ToString();
            int sum = 0;
            for (int i = amount.Length-1; i >= 0; i--)
            {
                char ch = amount[i];
                sum += ch - '0';
            }
            Console.WriteLine(sum);
        }
    }
}
