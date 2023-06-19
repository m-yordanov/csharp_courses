Func<string[], int, List<int>> calculate = (numbers, divider) =>
{
    List<int> reversedList = numbers.Reverse().Select(int.Parse).ToList();    
    List<int> result = new();
    foreach(var number in reversedList)
    {
        if(number % divider != 0)
        {
            result.Add(number);
        }
    }

    return result;
};

string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

int divider = int.Parse(Console.ReadLine());

List<int> result = calculate(numbers, divider);

Console.WriteLine(String.Join(" ", result));