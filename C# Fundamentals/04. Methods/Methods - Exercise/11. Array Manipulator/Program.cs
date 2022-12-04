using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split(" ");
                string command = inputArgs[0];
                if (command == "exchange")
                {
                    int index = int.Parse(inputArgs[1]);
                    if (index < 0 || index >= arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    arr = ExchangeArray(arr, index);
                }
                else if (command == "max" || command == "min")
                {
                    string evenOrOddArg = inputArgs[1];

                    int indexOfEl;
                    if (command == "max")
                    {
                        indexOfEl = IndexOfMaxEvenOrOddElement(arr, evenOrOddArg);
                    }
                    else
                    {
                        indexOfEl = IndexOfMinEvenOrOddElement(arr, evenOrOddArg);
                    }

                    if (indexOfEl == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(indexOfEl);
                }
                else if (command == "first" || command == "last")
                {
                    int count = int.Parse(inputArgs[1]);
                    string evenOrOddArg = inputArgs[2];

                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    int[] elements;
                    if (command == "first")
                    {
                        elements = FirstEvenOrOddElements(arr, count, evenOrOddArg);
                    }
                    else
                    {
                        elements = LastEvenOrOddElement(arr, count, evenOrOddArg);
                    }
                    PrintArray(elements);
                }
            }
            PrintArray(arr);
        }
        static int[] ExchangeArray(int[] originalArr, int index)
        {
            int[] modifiedArr = new int[originalArr.Length];
            int modifiedArrIndex = 0;
            for (int i = index + 1; i < originalArr.Length; i++)
            {
                modifiedArr[modifiedArrIndex++] = originalArr[i];
            }
            for (int i = 0; i <= index; i++)
            {
                modifiedArr[modifiedArrIndex++] = originalArr[i];
            }
            return modifiedArr;
        }

        static int IndexOfMaxEvenOrOddElement(int[] arr, string evenOrOddArg)
        {
            int maxIndex = -1;
            int currMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
            }
            return maxIndex;
        }

        static int IndexOfMinEvenOrOddElement(int[] arr, string evenOrOddArg)
        {
            int minIndex = -1;
            int currMin = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
            }
            return minIndex;
        }

        static int[] FirstEvenOrOddElements(int[] arr, int count, string evenOrOddArg)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (firstElArrIndex >= count)
                {
                    break;
                }
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
            }   
            if (firstElArrIndex < count)
            {
                firstElArr = ResizeArray(firstElArr, firstElArrIndex);
            }

            return firstElArr;
        }

        static int[] LastEvenOrOddElement(int[] arr, int count, string evenOrOddArg)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (firstElArrIndex >= count)
                {
                    break;
                }
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
            }

            if (firstElArrIndex < count)
            {
                firstElArr = ResizeArray(firstElArr, firstElArrIndex);
            }
            firstElArr = ReversedArray(firstElArr);
            return firstElArr;
        }

        static int[] ResizeArray(int[] originalArr, int count)
        {
            int[] modifiedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifiedArray[i] = originalArr[i];
            }
            return modifiedArray;
        }

        static int[] ReversedArray(int[] originalArr)
        {
            int[] reversed = new int[originalArr.Length];
            for (int i = originalArr.Length - 1; i >= 0; i--)
            {
                reversed[reversed.Length - i - 1] = originalArr[i];
            }
            return reversed;
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }
    }
}
