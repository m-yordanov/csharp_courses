//Includes both 04. Students and 05. Students 2.0
using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputParts = input.Split();
                string firtstName = inputParts[0];
                string lastName = inputParts[1];
                int age = int.Parse(inputParts[2]);
                string hometown = inputParts[3];
                Student student = new Student(firtstName, lastName, age, hometown);

                bool exists = false;

                foreach(var currentStudent in students)
                {
                    if(currentStudent.FirstName == student.FirstName && currentStudent.LastName == student.LastName)
                    {
                        currentStudent.Age = student.Age;
                        currentStudent.Hometown = student.Hometown;
                        exists = true;
                    }
                }

                if(!exists)
                {
                    students.Add(student);      
                }

                students.Add(student);
            }
            string city = Console.ReadLine();
            foreach (Student currentStudent in students)
            {
                if (currentStudent.Hometown == city)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }
    internal class Student
    {
        public Student(string firstName, string lastName, int age, string hometown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hometown = hometown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Hometown { get; set; }
    }
}
