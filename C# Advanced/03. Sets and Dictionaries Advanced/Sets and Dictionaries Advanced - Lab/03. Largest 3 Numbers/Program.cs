int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderByDescending(n => n).ToArray();

if(array.Length == 1)
{
    Console.WriteLine(array[0]);
}
else if(array.Length == 2)
{
    Console.WriteLine($"{array[0]} {array[1]}");
}
else
{
    for (int i = 0; i <= 2; i++)
    {
        Console.Write(array[i] + " ");
    }
}
