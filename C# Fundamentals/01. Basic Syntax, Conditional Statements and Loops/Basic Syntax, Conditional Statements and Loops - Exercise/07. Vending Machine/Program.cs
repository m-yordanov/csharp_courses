using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coins = 0;
            double money = 0;
            string type = string.Empty;
            string input = string.Empty;
            while (input != "Start")
            {
                input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                money = double.Parse(input);
                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    coins += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
            }
            while (input != "End")
            {
                input = Console.ReadLine();
                switch(input)
                {
                    case "Nuts":
                    {
                        if (coins >= 2)
                            {
                                coins -= 2;
                                Console.WriteLine("Purchased nuts");
                            }
                        else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                    }
                    case "Water":
                        {
                            if (coins >= 0.7)
                            {
                                coins -= 0.7;
                                Console.WriteLine("Purchased water");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        }
                    case "Crisps":
                        {
                            if (coins >= 1.5)
                            {
                                coins -= 1.5;
                                Console.WriteLine("Purchased crisps");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        }
                    case "Soda":
                        {
                            if (coins >= 0.8)
                            {
                                coins -= 0.8;
                                Console.WriteLine("Purchased soda");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        }
                    case "Coke":
                        {
                            if (coins >= 1)
                            {
                                coins -= 1;
                                Console.WriteLine("Purchased coke");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        }
                    case "End":
                        {
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
            Console.WriteLine($"Change: {coins:f2}");
        }
    }
}
