using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            double average = 0.0;
            string name = Console.ReadLine();
            int grade = 1;
            int excluded = 0;
            double sumOfEvaluations = 0.0;
            while (grade <= 12)
            {
                double evaluation = double.Parse(Console.ReadLine());
                sumOfEvaluations += evaluation;

                if (evaluation < 4)
                {
                    excluded++;
                    if (excluded >= 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }

                }
                grade++;
            }
            average = sumOfEvaluations / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
        }
    }
}
