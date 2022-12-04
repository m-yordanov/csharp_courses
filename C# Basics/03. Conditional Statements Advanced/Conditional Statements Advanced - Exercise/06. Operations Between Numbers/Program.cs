using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result;
            if (operation == "+" || operation == "-" || operation == "*")
            {
                if (operation == "+")
                {
                    result = N1 + N2;
                }
                else if (operation == "-")
                {
                    result = N1 - N2;
                }
                else
                {
                    result = N1 * N2;
                }
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {result} - odd");
                }
            }
            else if (operation == "%" || operation == "/")
            {
                if (operation == "/")
                {   
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        result = (double)N1 / N2;
                        Console.WriteLine($"{N1} {operation} {N2} = {result:f2}");
                    }
                }
                else if (operation == "%")
                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} {operation} {N2} = {result}");
                }
            }
        }
    }
}
