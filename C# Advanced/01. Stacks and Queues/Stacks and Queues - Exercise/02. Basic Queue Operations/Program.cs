int[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = tokens[0];
int s = tokens[1];
int x = tokens[2];
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>();
for (int i = 0; i < n; i++)
{
    queue.Enqueue(numbers[i]);
}
for (int i = 0; i < s; i++)
{
    queue.Dequeue();
}
if (queue.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Any())
    {
        Console.WriteLine(queue.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}