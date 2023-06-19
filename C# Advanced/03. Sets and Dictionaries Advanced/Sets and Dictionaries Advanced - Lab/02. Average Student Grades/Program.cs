int gradesAmount = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> studentsInfo = new Dictionary<string, List<decimal>>();

for(int i = 0; i < gradesAmount; i++)
{
    string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = strings[0];
    decimal grade = decimal.Parse(strings[1]);
    if(!studentsInfo.ContainsKey(name))
    {
        List<decimal> grades = new List<decimal>();
        studentsInfo.Add(name, grades);
        studentsInfo[name].Add(grade);
    }
    else
    {
        studentsInfo[name].Add(grade);
    }
}

foreach(var item in studentsInfo)
{
    Console.WriteLine($"{item.Key} -> {String.Join(" ", item.Value.Select(grade => grade.ToString("F2")))} (avg: {item.Value.Average():f2})");
}