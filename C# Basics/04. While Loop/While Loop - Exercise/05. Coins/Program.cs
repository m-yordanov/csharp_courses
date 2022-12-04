using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputValue;
            int counter;
            bool isLoopExit;

            inputValue = decimal.Parse(Console.ReadLine());
            counter = 0;
            isLoopExit = false;

            while (!isLoopExit)
            {
                if ((inputValue - (decimal)2.0) >= 0)
                    inputValue -= (decimal)2.0;
                else if ((inputValue - (decimal)1.0) >= 0)
                    inputValue -= (decimal)1.0;
                else if ((inputValue - (decimal).5) >= 0)
                    inputValue -= (decimal).5;
                else if ((inputValue - (decimal).2) >= 0)
                    inputValue -= (decimal).2;
                else if ((inputValue - (decimal).1) >= 0)
                    inputValue -= (decimal).1;
                else if ((inputValue - (decimal).05) >= 0)
                    inputValue -= (decimal).05;
                else if ((inputValue - (decimal).02) >= 0)
                    inputValue -= (decimal).02;
                else if ((inputValue - (decimal).01) >= 0)
                    inputValue -= (decimal).01;
                else
                {
                    isLoopExit = true;
                    counter--;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
