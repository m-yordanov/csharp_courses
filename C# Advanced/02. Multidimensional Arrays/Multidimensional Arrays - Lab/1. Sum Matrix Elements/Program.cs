int[] sizes = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[,] matrix = new int[sizes[0], sizes[1]];

for (int row = 0; row < sizes[0]; row++)
{
    int[] colElements = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for(int col = 0; col < colElements.Length; col++)
    {
        matrix[row, col] = colElements[col];
    }
}

int sum = 0;

for(int row = 0; (row < sizes[0]); row++)
{
    for(int col = 0; (col < sizes[1]); col++)
    {
        sum += matrix[row, col];
    }
}

Console.WriteLine(sizes[0]);
Console.WriteLine(sizes[1]);
Console.WriteLine(sum);