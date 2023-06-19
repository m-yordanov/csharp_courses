int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];

for (int row = 0; row < n; row++)
{
    string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int col = 0; col < array.Length; col++)
    {
        int iteration = 0;
        foreach (var item in array)
        {
            foreach (char character in item)
            {
                matrix[row, col + iteration] = character;
                iteration++;
            }
        }
    }
}

char symbol = char.Parse(Console.ReadLine());

for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        if (matrix[row, col] == symbol)
        {
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}
Console.WriteLine($"{symbol} does not occur in the matrix");