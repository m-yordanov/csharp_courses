Stack<int> clothes = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int rackCapacity = int.Parse(Console.ReadLine());
int currentRackSize = rackCapacity;
int rackAmount = 1;

while (clothes.Any())
{
    currentRackSize -= clothes.Peek();

    if (currentRackSize < 0)
    {
        currentRackSize = rackCapacity;
        rackAmount++;

        continue;
    }

    clothes.Pop();
}
Console.WriteLine(rackAmount);