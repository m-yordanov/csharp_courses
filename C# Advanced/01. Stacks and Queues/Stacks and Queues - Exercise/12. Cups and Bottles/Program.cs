Queue<int> cups = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> bottles = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
int wastedLitters = 0;
int currentCupValue = 0;

while(cups.Any())
{
    if(!bottles.Any())
    {
        Console.WriteLine($"Cups: {string.Join(" ", cups)}");
        Console.WriteLine($"Wasted litters of water: {wastedLitters}");
        return;
    }
    int bottleSize = bottles.Pop();
    if (currentCupValue <= 0)
    {
        currentCupValue = cups.Peek();
    }
    if(bottleSize >= currentCupValue)
    {
        wastedLitters += bottleSize - currentCupValue;
        cups.Dequeue();
        currentCupValue = 0;
    }
    else
    {
        currentCupValue -= bottleSize;
    }
}
Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
Console.WriteLine($"Wasted litters of water: {wastedLitters}");