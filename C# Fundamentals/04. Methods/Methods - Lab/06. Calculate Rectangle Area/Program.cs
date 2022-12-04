using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double heigth = int.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, heigth);
            Console.WriteLine(area);
        }
        static double GetRectangleArea(double width, double heigth)
        {
            return width * heigth;
        }
    }
}
