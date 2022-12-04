using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split(" : ");
                string course = inputArgs[0];
                string student = inputArgs[1];
                if (!courses.ContainsKey(course))
                {
                    courses[course] = new List<string>();
                }
                courses[course].Add(student);
            }
            foreach (var kvp in courses)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
