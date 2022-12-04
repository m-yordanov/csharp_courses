using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] studentInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                float grade = float.Parse(studentInfo[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            List<Student> orderedStudents = students.OrderByDescending(s => s.Grade).ToList();
            foreach(Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastname, float grade)
        {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Grade = grade;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public float Grade { get; private set; }
    }
}
