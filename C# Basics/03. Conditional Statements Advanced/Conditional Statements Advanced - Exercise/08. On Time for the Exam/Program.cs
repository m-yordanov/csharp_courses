using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. четем време на изпита (час, минути)
            int examHour = int.Parse(Console.ReadLine()); //10
            int examMin = int.Parse(Console.ReadLine()); //10 

            //1.2. Преобразуваме минутите и часовете на изпита в минути
            examMin = examMin + examHour * 60; // 10+ 10*60 => 610

            //2. Четем време на пристигане (час, минути)
            int arrivalHour = int.Parse(Console.ReadLine()); //10
            int arrivalMin = int.Parse(Console.ReadLine()); //30

            //1.2. Преобразуваме минутите и часовете на пристигане в минути
            arrivalMin = arrivalMin + arrivalHour * 60; //30+10*60 => 630


            //2. Намираме каква е разликата между времето на изпита и времето на пристигане
            //difference > 0, когато той е дошъл ПРЕДИ часа на изпита
            int difference = examMin - arrivalMin; //610-630 => -20


            //3. Намираме дали той е:
            if (difference >= 0 && difference <= 30) //[0-30]
            {
                //навреме => точно в часа на изпита или 30 мин по-рано
                Console.WriteLine("On time");
                //проверяваме дали е подранил с поне 1 мин
                if (difference != 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if (difference > 30)
            {
                //подранил => повече от 30 мин преди изпита
                Console.WriteLine("Early");
                //проверяваме дали е подранил с повече от час
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    int diffHours = difference / 60;
                    int diffMin = difference % 60;
                    Console.WriteLine($"{diffHours}:{diffMin:d2} hours before the start");
                }
            }
            else // difference < 0
            {
                //закъснявал => с поне 1 минута след часа на изпита =>
                Console.WriteLine("Late");

                //проверяваме дали е закъснял с повече от час
                difference = Math.Abs(difference);
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    int diffHours = difference / 60;
                    int diffMin = difference % 60;
                    Console.WriteLine($"{diffHours}:{diffMin:d2} hours after the start");
                }
            }
        }
    }
}
