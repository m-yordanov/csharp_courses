int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
int sumPrimary = 0;
int sumSecondary = 0;

for (int row = 0; row < n; row++)
{
    int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < array.Length; col++)
    {
        matrix[row, col] = array[col];
    }
}

for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        if (row == col)
        {
            sumPrimary += matrix[row, col];
        }
    }
}

for(int i =  0; i < n; i++)
{
    int row = i;
    int col = n - 1 - i;
    sumSecondary += matrix[row, col];
}

Console.WriteLine(Math.Abs(sumPrimary - sumSecondary));