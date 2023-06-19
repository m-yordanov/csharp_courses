int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
char[,] matrix = new char[rows, cols];

int playerRow = 0;
int playerCol = 0;

for (int row = 0; row < rows; row++)
{
    string chars = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = chars[col];
        if (matrix[row, col] == 'P')
        {
            playerRow = row;
            playerCol = col;
            matrix[row, col] = '.';
        }
    }
}

string commands = Console.ReadLine();

foreach (var command in commands)
{
    int oldPlayerRow = playerRow;
    int oldPlayerCol = playerCol;

    switch (command)
    {
        case 'L':
            playerCol--;
            break;
        case 'R':
            playerCol++;
            break;
        case 'U':
            playerRow--;
            break;
        case 'D':
            playerCol++;
            break;
    }

    matrix = SpreadBunnies(rows, cols, matrix);

    if (playerRow < 0 || playerRow >= rows || playerCol > 0 || playerCol >= cols)
    {
        PrintMatrix(matrix);
        Console.WriteLine($"won: {oldPlayerRow} {oldPlayerCol}");

        break;
    }

    if (matrix[playerRow, playerCol] == 'B')
    {
        PrintMatrix(matrix);
        Console.WriteLine($"dead: {playerRow} {playerCol}");

        break;
    }
}

static char[,] SpreadBunnies(int rows, int cols, char[,] matrix)
{
    char[,] newMatrix = new char[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            newMatrix[row, col] = matrix[row, col];
        }
    }

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (matrix[row, col] == 'B')
            {
                if (row > 0)
                {
                    newMatrix[row - 1, col] = 'B';
                }
                if (row < rows - 1)
                {
                    newMatrix[row + 1, col] = 'B';
                }
                if (col > 0)
                {
                    newMatrix[row, col - 1] = 'B';
                }
                if (col < cols - 1)
                {
                    newMatrix[row, col + 1] = 'B';
                }
            }
        }
    }

    return newMatrix;
}

static void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}