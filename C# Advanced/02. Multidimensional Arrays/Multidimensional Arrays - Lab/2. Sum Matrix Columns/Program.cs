int[] sizes = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[,] matrix = new int[sizes[0], sizes[1]];

for (int row = 0; row < sizes[0]; row++)
{
    int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < array.Length; col++)
    {
        matrix[row, col] = array[col];
    }
}

for (int cols = 0; cols < sizes[1]; cols++)
{
    int colSum = 0;
    for (int rows = 0; rows < sizes[0]; rows++)
    {
        colSum += matrix[rows, cols];
    }
    Console.WriteLine(colSum);
}