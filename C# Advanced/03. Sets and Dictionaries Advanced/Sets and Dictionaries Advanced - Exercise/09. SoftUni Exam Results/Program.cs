SortedDictionary<string, int> contestantsScores = new SortedDictionary<string, int>();
SortedDictionary<string, int> languagesCount = new SortedDictionary<string, int>();
string input;
while ((input = Console.ReadLine()) != "exam finished")
{
    string[] inputArgs = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
    string username = inputArgs[0];
    string language = inputArgs[1];
    if (language == "banned")
    {
        contestantsScores.Remove(username);
        continue;
    }

    int points = int.Parse(inputArgs[2]);


    if (!contestantsScores.ContainsKey(username))
    {
        contestantsScores.Add(username, points);
    }
    else if (points > contestantsScores[username])
    {
        contestantsScores[username] = points;
    }
    if (!languagesCount.ContainsKey(language))
    {
        languagesCount.Add(language, 1);
    }
    else
    {
        languagesCount[language]++;
    }
}

Console.WriteLine("Results:");
foreach (var (key, value) in contestantsScores.OrderByDescending(x => x.Value))
{
    Console.WriteLine($"{key} | {value}");

}

Console.WriteLine("Submissions:");
foreach(var (key, value) in languagesCount.OrderByDescending(x => x.Value))
{
    Console.WriteLine($"{key} - {value}");
}