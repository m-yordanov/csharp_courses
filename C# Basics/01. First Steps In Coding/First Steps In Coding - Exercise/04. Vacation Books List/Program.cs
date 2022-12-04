using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesBook = int.Parse(Console.ReadLine());
            int pagesHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine((pagesBook / pagesHour) / days);
        }
    }
}
