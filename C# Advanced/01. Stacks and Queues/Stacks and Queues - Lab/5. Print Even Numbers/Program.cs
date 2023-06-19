int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> evenNumbers = new Queue<int>();
for(int i = 0; i < inputNumbers.Length; i++)
{
    if (inputNumbers[i] % 2 == 0)
    {
        evenNumbers.Enqueue(inputNumbers[i]);
    }
}
Console.WriteLine(String.Join(", ", evenNumbers));