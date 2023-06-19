using System.Data;

int size = int.Parse(Console.ReadLine());
string[] commands = Console.ReadLine().Split().ToArray();
char[,] matrix = new char[size, size];

int minerRow = 0;
int minerCol = 0;

for (int row = 0; row < size; row++)
{
    char[] currentLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = currentLine[col];
        if (matrix[row, col] == 's')
        {
            minerRow = row;
            minerCol = col;
        }
    }
}

int coals = 0;

foreach (char c in matrix)
{
    if (c == 'c')
    {
        coals++;
    }
}

foreach (string command in commands)
{
    switch (command)
    {
        case "up":
            if (minerRow > 0)
            {
                matrix[minerRow, minerCol] = '*';
                minerRow--;
                if (matrix[minerRow, minerCol] == 'c')
                {
                    coals--;
                    matrix[minerRow, minerCol] = '*';
                }
                else if (matrix[minerRow, minerCol] == 'e')
                {
                    GameOver(minerRow, minerCol);
                }
            }
            break;
        case "down":
            if (minerRow < matrix.GetLength(0) - 1)
            {
                matrix[minerRow, minerCol] = '*';
                minerRow++;
                if (matrix[minerRow, minerCol] == 'c')
                {
                    coals--;
                    matrix[minerRow, minerCol] = '*';
                }
                else if (matrix[minerRow, minerCol] == 'e')
                {
                    GameOver(minerRow, minerCol);
                }
            }
            break;
        case "left":
            if (minerCol > 0)
            {
                matrix[minerRow, minerCol] = '*';
                minerCol--;
                if (matrix[minerRow, minerCol] == 'c')
                {
                    coals--;
                    matrix[minerRow, minerCol] = '*';
                }
                else if (matrix[minerRow, minerCol] == 'e')
                {
                    GameOver(minerRow, minerCol);
                }
            }
            break;
        case "right":
            if (minerCol < matrix.GetLength(1) - 1)
            {
                matrix[minerRow, minerCol] = '*';
                minerCol++;
                if (matrix[minerRow, minerCol] == 'c')
                {
                    coals--;
                    matrix[minerRow, minerCol] = '*';
                }
                else if (matrix[minerRow, minerCol] == 'e')
                {
                    GameOver(minerRow, minerCol);
                    return;
                }
            }
            break;
    }
    if(coals == 0)
    {
        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
        return;
    }
}

Console.WriteLine($"{coals} coals left. ({minerRow}, {minerCol})");

static void GameOver(int minerRow, int minerCol)
{
    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
}