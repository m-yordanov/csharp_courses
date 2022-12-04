using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());
            int trashedHeadsets = 0;
            int trashedMice = 0;
            int trashedKeyboards = 0;
            int trashedDisplays = 0;
            for (int i = 0; i <= lostGames; i+=2)
            {
                if (i+2 <= lostGames)
                {
                    trashedHeadsets++;
                }
            }
            for (int i = 0; i <= lostGames; i+=3)
            {
                if (i+3 <= lostGames)
                {
                    trashedMice++;
                }
            }
            for (int i = 0; i <= lostGames; i+=6)
            {
                if (i+6 <= lostGames)
                {
                    trashedKeyboards++;
                }
            }
            for (int i = 0; i <= lostGames; i+=12)
            {
                if (i+12 <= lostGames)
                {
                    trashedDisplays++;
                }
            }
            double rageExpense = (priceHeadset * trashedHeadsets) + (priceMouse * trashedMice) + (priceKeyboard * trashedKeyboards) + (priceDisplay * trashedDisplays);
            Console.WriteLine($"Rage expenses: {rageExpense:f2} lv.");
        }
    }
}
