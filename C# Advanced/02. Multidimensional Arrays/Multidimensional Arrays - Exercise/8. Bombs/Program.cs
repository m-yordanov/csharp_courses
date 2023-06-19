int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

ReadFieldFromConsole(matrix);

string[] coordinatesValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

ExplodeTheBombs(matrix, coordinatesValues);

int aliveCells = 0;
int sumAliveCells = 0;

foreach (int cell in matrix)
{
    if (cell > 0)
    {
        aliveCells++;
        sumAliveCells += cell;
    }
}
Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sumAliveCells}");
PrintField(matrix);


static void PrintField(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");

        }
        Console.WriteLine();
    }
}

static void ExplodeTheBombs(int[,] matrix, string[] coordinatesValues)
{
    foreach (string rowColPair in coordinatesValues)
    {
        int[] currentBombCoordinates = rowColPair
            .Split(",", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int currentBombRow = currentBombCoordinates[0];
        int currentBombCol = currentBombCoordinates[1];
        int currentBomb = matrix[currentBombRow, currentBombCol];


        for (int row = currentBombRow - 1; row <= currentBombRow + 1; row++)
        {
            for (int col = currentBombCol - 1; col <= currentBombCol + 1; col++)
            {
                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                {
                    if (matrix[row, col] <= 0 || currentBomb < 0)
                    {
                        continue;
                    }
                    matrix[row, col] -= currentBomb;
                }

            }

        }

    }
}

static void ReadFieldFromConsole(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int[] currentRow = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = currentRow[col];
        }
    }
}
