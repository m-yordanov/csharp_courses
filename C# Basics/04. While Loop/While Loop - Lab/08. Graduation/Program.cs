using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int k = 1;
            int f = 0;
            double average = 0;
            while (k <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                average += grade;
                if (grade < 4.00)
                {
                    f++;
                    if (f > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {k} grade");
                    }
                }
                k++;
            }
            Console.WriteLine($"{name} graduated. Average grade: {average/12:f2}");
        }
    }
}
