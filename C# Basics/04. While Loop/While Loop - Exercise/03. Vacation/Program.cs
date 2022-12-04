using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем цена за екскурзията
            double neededMoney = double.Parse(Console.ReadLine());

            //2. Четем колко пари има спестени до момента
            double avaliableMoney = double.Parse(Console.ReadLine());

            int daysCount = 0; //брояч на дните, в които се опитва да спести
            int spendCount = 0; //брояч на ПОРЕДНИТЕ дни, в които харчи

            string input; //ще пазим действие => spend/save
            double money; //пари, които харчи/спестява

            //3. Многократно действие, докато не спести достатъчно за ексурзия
            while (avaliableMoney < neededMoney)
            {
                //    =>четем действие (харчи/спестява) и четем пари, които харчи/пести
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                daysCount++;

                //    => проверяваме какво е действието
                if (input == "save")
                {
                    //=> добавяме парите към спестяванията
                    avaliableMoney += money;
                    //=> нулираме брояча на поредните дни, в които харчи
                    spendCount = 0;
                }
                else //"spend"
                {
                    // => увеличаваме брояча на поредните дни, в които харчи с 1
                    spendCount++;
                    //=> проверяваме дали поредни дни на харчене са станали 5 => спираме цикъла и изписваме съобщението на конзолата
                    if (spendCount == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{daysCount}");
                        break;
                    }
                    //=> изваждаме парите от спестяванията
                    avaliableMoney -= money;

                    //=> ако спестяванията са станали <0 => трябва да ги направим 0
                    if (avaliableMoney < 0)
                    {
                        avaliableMoney = 0;
                    }
                }
            }

            //Проверяваме дали е успяла да спести парите 
            if (avaliableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
