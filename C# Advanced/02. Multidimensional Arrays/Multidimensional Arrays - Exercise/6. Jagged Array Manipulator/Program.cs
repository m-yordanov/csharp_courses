using System.Diagnostics.CodeAnalysis;

int rows = int.Parse(Console.ReadLine());
int[][] jagged = new int[rows][];

for (int row = 0; row < rows; row++)
{
    jagged[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
}


for (int row = 0; row < rows - 1; row++)
{
    if (jagged[row].Length == jagged[row + 1].Length)
    {
        MultiplyByTwo(jagged, row);
    }
    else
    {
        DivideByTwo(jagged, row);
    }
}

string command = Console.ReadLine();
while (command != "End")
{
    string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int row = 0;
    int col = 0;
    int value = 0;

    if (commandArgs.Length == 4)
    {
        row = int.Parse(commandArgs[1]);
        col = int.Parse(commandArgs[2]);
        value = int.Parse(commandArgs[3]);
    }

    if (commandArgs[0] == "Add")
    {
        if (IsValid(jagged, row, col))
        {
            jagged[row][col] += value;
        }
    }
    else if (commandArgs[0] == "Subtract")
    {
        if (IsValid(jagged, row, col))
        {
            jagged[row][col] -= value;
        }
    }

    command = Console.ReadLine();
}

foreach (int[] row in jagged)
{
    foreach (int num in row)
    {
        Console.Write($"{num} ");
    }
    Console.WriteLine();
}

static void MultiplyByTwo(int[][] jagged, int row)
{
    for (int i = 0; i < jagged[row].Length; i++)
    {
        jagged[row][i] *= 2;
    }
    for (int i = 0; i < jagged[row + 1].Length; i++)
    {
        jagged[row + 1][i] *= 2;
    }
}

static void DivideByTwo(int[][] jagged, int row)
{
    for (int i = 0; i < jagged[row].Length; i++)
    {
        jagged[row][i] /= 2;
    }
    for (int i = 0; i < jagged[row + 1].Length; i++)
    {
        jagged[row + 1][i] /= 2;
    }
}

static bool IsValid(int[][] jagged, int row, int col)
{
    return row >= 0
        && row < jagged.Length
        && col >= 0
        && col < jagged[row].Length;
}
