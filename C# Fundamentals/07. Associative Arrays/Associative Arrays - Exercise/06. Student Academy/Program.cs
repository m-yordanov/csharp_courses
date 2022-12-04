using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (!grades.ContainsKey(studentName))
                {
                    grades[studentName] = new List<double>();
                }
                grades[studentName].Add(studentGrade);
            }
            foreach (var kvp in grades.Where(x => x.Value.Sum() / x.Value.Count >= 4.50))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Sum() / kvp.Value.Count:f2}");
            }
        }
    }
}
