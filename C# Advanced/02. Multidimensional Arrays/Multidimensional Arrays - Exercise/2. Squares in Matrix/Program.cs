int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = matrixSize[0];
int cols = matrixSize[1];
char[,] matrix = new char[rows, cols];
int squaresAmount = 0;

for (int row = 0; row < rows; row++)
{
    char[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < array.Length; col++)
    {
        matrix[row, col] = array[col];
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (col < cols - 1 && row < rows - 1)
        {
            if (matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1] & matrix[row, col] == matrix[row, col + 1])
            {
                squaresAmount++;
            }
        }
    }
}

Console.WriteLine(squaresAmount);