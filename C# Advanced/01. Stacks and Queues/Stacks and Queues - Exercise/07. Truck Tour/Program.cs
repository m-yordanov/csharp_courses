﻿using System.Diagnostics.Metrics;

int pumpsAmount = int.Parse(Console.ReadLine());
Queue<int[]> pumps = new Queue<int[]>();
int counter = 0;

for (int i = 0; i < pumpsAmount; i++)
{
    int[] query = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    pumps.Enqueue(query);
}

while (true)
{
    int fuelAmount = 0;
    bool foundPoint = true;
    for (int i = 0; i < pumpsAmount; i++)
    {
        int[] currentPump = pumps.Dequeue();
        fuelAmount += currentPump[0];
        if (fuelAmount < currentPump[1])
        {
            foundPoint = false;
        }
        fuelAmount -= currentPump[1];

        pumps.Enqueue(currentPump);
    }
    if (foundPoint)
    {
        break;
    }
    counter++;
    pumps.Enqueue(pumps.Dequeue());
}

Console.WriteLine(counter);