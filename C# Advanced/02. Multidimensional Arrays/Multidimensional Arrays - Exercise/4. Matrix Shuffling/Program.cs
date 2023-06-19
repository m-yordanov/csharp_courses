int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = strings[col];
    }
}

string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

while (command[0] != "END")
{
    if (IsValidCommand(rows, cols, command))
    {
        int[] coordinates = new int[command.Length - 1];
        for (int i = 0; i <= coordinates.Length - 1; i++)
        {
            coordinates[i] = int.Parse(command[i + 1]);
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row == coordinates[0] && col == coordinates[1])
                {
                    string replacement = matrix[row, col];
                    matrix[row, col] = matrix[coordinates[2], coordinates[3]];
                    matrix[coordinates[2], coordinates[3]] = replacement;
                    PrintMatrix(matrix);
                }
            }
        }

    }
    else
    {
        Console.WriteLine("Invalid input!");
    }

    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
}

static bool IsValidCommand(int rows, int cols, string[] command)
{
    bool isValid = command[0] == "swap"
        && command.Length == 5
        && int.Parse(command[1]) >= 0 && int.Parse(command[1]) < rows
        && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < cols
        && int.Parse(command[3]) >= 0 && int.Parse(command[3]) < rows
        && int.Parse(command[4]) >= 0 && int.Parse(command[4]) < cols;


    return isValid;
}

static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }

        Console.WriteLine();
    }
}