//using System;

//namespace _05._Travelling
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string destination = Console.ReadLine();
//            double minBudget = double.Parse(Console.ReadLine());
//            double budget = 0;
//            bool flag = false;
//            while (destination != "End")
//            {
//                while (budget < minBudget)
//                {
//                    budget += double.Parse(Console.ReadLine());
//                    if (budget >= minBudget)
//                    {
//                        Console.WriteLine($"Going to {destination}!");
//                        destination = Console.ReadLine();
//                        if (destination == "End")
//                        {
//                            flag = true;
//                            break;
//                        }
//                        minBudget = double.Parse(Console.ReadLine());
//                        budget = 0;
//                    }
//                }
//                if (flag)
//                {
//                    break;
//                }
//            }
//        }
//    }
//}
using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }

                double budget = double.Parse(Console.ReadLine());
                double money = 0;

                while (true)
                {
                    if (money >= budget)
                    {
                        break;
                    }
                    money += double.Parse(Console.ReadLine());
                }


                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}