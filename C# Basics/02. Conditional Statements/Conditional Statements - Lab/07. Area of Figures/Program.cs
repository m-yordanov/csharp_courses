using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string shape = Console.ReadLine();
           if (shape == "square")
            {
                double size = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", size * size);
            }
           else if (shape == "rectangle")
            {
                double size1 = double.Parse(Console.ReadLine());
                double size2 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", size1 * size2);
            }
           else if (shape == "triangle")
            {
                double size1= double.Parse(Console.ReadLine());
                double size2 = double.Parse(Console.ReadLine());
                Console.Write("{0:f3}", (size1 * size2) / 2); 
            }
           else if (shape == "circle")
            {
                double size1 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", ((size1 * size1) * Math.PI));
            }
        }
    }
}
