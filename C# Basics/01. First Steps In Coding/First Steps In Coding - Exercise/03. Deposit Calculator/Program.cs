using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            Console.WriteLine(deposit + term* ((deposit * percent/100) / 12));
        }
    }
}
