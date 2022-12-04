using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Създаме променливи за броя продадени билети от всеки тип ("student", "standard", "kid") 
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            //Създаме променлива за името на филма
            string filmName = Console.ReadLine();

            //1. Пускаме цикъл, който да се върти до получаване на командата "Finish"
            while (filmName != "Finish")
            {
                //Създаме променливи за броя свободни места и четем от конзолата колко са?
                int free = int.Parse(Console.ReadLine());
                //   Създаме променливи за типа билет, който е продаден 
                string type = Console.ReadLine();
                //   Създаме променливи за продените билети за конкретната прожекция
                int tickets = 0;

                //aко не сме получили "Finish" => получили сме заглавие на филм.

                // => 2. Пускаме вътрешен цикъл, който да се изпълнява до командата "End" или до изчепване на свободните места
                while (type != "End")
                {
                    //=> четем тип на билет => добавяме го към съответната група ("student", "standard", "kid") 
                    if (type == "student")
                    {
                        studentTickets++;
                    }
                    else if (type == "standard")
                    {
                        standardTickets++;
                    }
                    else //type =="kid"
                    {
                        kidTickets++;
                    }
                    tickets++;

                    if (tickets == free)
                    {
                        break;
                    }

                    type = Console.ReadLine();
                }

                //  => когато излезем от вътрешния цикъл:
                //     => Изчисляваме и отпечатваме какъв % от залата е запълнена (колко от общия брой билети са закупени)
                double occupancy = tickets * 100.0 / free;
                Console.WriteLine($"{filmName} - {occupancy:f2}% full.");

                filmName = Console.ReadLine();
            }

            //3. Изчисляваме колко общо са продадените билети и да отпечатаме
            int totalTickets = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");

            //4. Изчиславаме какъв % от всички продадени билети са: "student", "standard", "kid"
            Console.WriteLine($"{studentTickets * 100.0 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{standardTickets * 100.0 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 100.0 / totalTickets:f2}% kids tickets.");

        }
    }
}