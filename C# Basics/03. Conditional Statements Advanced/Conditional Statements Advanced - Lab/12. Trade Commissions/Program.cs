using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission;
            if(0 <= sales && sales <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sales * 0.05;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Varna":
                        commission = sales * 0.045;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Plovdiv":
                        commission = sales * 0.055;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (500 < sales && sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sales * 0.07;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Varna":
                        commission = sales * 0.075;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Plovdiv":
                        commission = sales * 0.08;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (1000 < sales && sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sales * 0.08;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Varna":
                        commission = sales * 0.10;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Plovdiv":
                        commission = sales * 0.12;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sales * 0.12;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Varna":
                        commission = sales * 0.13;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Plovdiv":
                        commission = sales * 0.145;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
