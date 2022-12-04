using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGradesAllowed = int.Parse(Console.ReadLine());
            int badGrades = 0;
            int problemAmount = 0;
            double average = 0;
            string problemName = string.Empty;
            double problemGrade = 0;
            string lastProblem = "";
            while (badGrades < badGradesAllowed)
            {
                problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    Console.WriteLine($"Average score: {average / problemAmount:f2}");
                    Console.WriteLine($"Number of problems: {problemAmount}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                lastProblem = problemName;
                problemGrade= double.Parse(Console.ReadLine());
                average += problemGrade;
                if (problemGrade <= 4)
                {
                    badGrades++;
                    if (badGrades >= badGradesAllowed)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        break;
                    }
                }
                problemAmount++;
            }
        }
    }
}
