using System.Runtime.ExceptionServices;

int rows = int.Parse(Console.ReadLine());
int[][] jagged = new int[rows][];

for (int row = 0; row < rows; row++)
{
    jagged[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
}

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int row = int.Parse(commandArgs[1]);
    int col = int.Parse(commandArgs[2]);
    int value = int.Parse(commandArgs[3]);

    bool isValid = true;
    if (row < 0 || jagged.Length <= row)
    {
        isValid = false;
    }
    else
    {
        if (jagged[row].Length <= col || col < 0)
        {
            isValid = false;
        }
    }

    if (isValid)
    {
        if (commandArgs[0] == "add")
        {
            jagged[row][col] += value;
        }
        else if (commandArgs[0] == "subtract")
        {
            jagged[row][col] -= value;
        }
    }
    else
    {
        Console.WriteLine("Invalid coordinates");
    }

    command = Console.ReadLine().ToLower();
}

for (int row = 0; row < jagged.Length; row++)
{
    for (int col = 0; col < jagged[row].Length; col++)
    {
        Console.Write($"{jagged[row][col]} ");
    }
    Console.WriteLine();
}