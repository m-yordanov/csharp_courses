int bulletPrice = int.Parse(Console.ReadLine());   
int clip = int.Parse(Console.ReadLine());
Stack<int> bullets = new (Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
Queue<int> locks = new (Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
int salary = int.Parse(Console.ReadLine());
while (locks.Any())
{
    for(int i = 0;  i < clip; i++)
    {
        if(!locks.Any())
        {
        break;
        }
        if (!bullets.Any())
        {
            Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            return;
        }
        int bulletSize = bullets.Pop();
        salary -= bulletPrice;
        if(bulletSize <= locks.Peek())
        {
            Console.WriteLine("Bang!");
            locks.Dequeue();
        }
        else
        {
            Console.WriteLine("Ping!");
        }
        if(i == clip - 1 && bullets.Any())
        {
            i = -1;
            Console.WriteLine("Reloading!");
        }
    }
}
Console.WriteLine($"{bullets.Count} bullets left. Earned ${salary}");