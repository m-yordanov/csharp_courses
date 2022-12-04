using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] inputParts = input.Split(':');
                string lessonTitle = inputParts[1];
                if (inputParts[0] == "Add")
                {
                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                    }
                }
                else if (inputParts[0] == "Insert")
                {
                    int index = int.Parse(inputParts[2]);
                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Insert(index, lessonTitle);
                    }
                }
                else if (inputParts[0] == "Remove")
                {
                    if (schedule.Contains(lessonTitle))
                    {
                        schedule.Remove(lessonTitle);
                    }
                    if (schedule.Contains((lessonTitle) + "-" + ("Exercise")))
                    {
                        schedule.Remove((lessonTitle) + "-" + ("Exercise"));
                    }
                }
                else if (inputParts[0] == "Swap")
                {
                    string firstLesson = inputParts[1];
                    string secondLesson = inputParts[2];
                    if (schedule.Contains(lessonTitle) && schedule.Contains(secondLesson))
                    {
                        int firstLessonPosition = schedule.IndexOf(firstLesson);
                        int secondLessonPosition = schedule.IndexOf(secondLesson);


                        schedule[firstLessonPosition] = secondLesson;
                        schedule[secondLessonPosition] = firstLesson;
                    }
                    if (schedule.Contains(firstLesson + "-" + "Exercise") || schedule.Contains(secondLesson + "-" + "Exercise"))
                    {

                        int firstLessonPosition = schedule.IndexOf(firstLesson);
                        int secondLesonPosition = schedule.IndexOf(secondLesson);


                        if (schedule.Contains(firstLesson + "-" + "Exercise"))
                        {
                            schedule.Remove(firstLesson + "-" + "Exercise");

                            if (firstLessonPosition == schedule.Count - 1)
                            {
                                schedule.Add(firstLesson + "-" + "Exercise");
                            }
                            else
                            {
                                schedule.Insert(firstLessonPosition + 1, firstLesson + "-" + "Exercise");
                            }

                        }
                        if (schedule.Contains(secondLesson + "-" + "Exercise"))
                        {
                            schedule.Remove(secondLesson + "-" + "Exercise");

                            if (secondLesonPosition == schedule.Count - 1)
                            {
                                schedule.Add(secondLesson + "-" + "Exercise");
                            }
                            else
                            {
                                schedule.Insert(secondLesonPosition + 1, secondLesson + "-" + "Exercise");
                            }
                        }
                    }
                }
                else if (inputParts[0] == "Exercise")
                {
                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add(((lessonTitle) + "-" + ("Exercise")));
                    }
                    else
                    {
                        int lessonIndex = 0;

                        for (int i = 0; i < schedule.Count; i++)
                        {
                            if (schedule[i] == lessonTitle)
                            {
                                lessonIndex = i;
                            }
                        }

                        schedule.Insert(lessonIndex + 1, lessonTitle + "-" + "Exercise");
                    }
                }
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
