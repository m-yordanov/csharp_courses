Dictionary<string, string> contests = new Dictionary<string, string>();
Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();
Dictionary<string, int> results = new Dictionary<string, int>();

string input = Console.ReadLine();
while (input != "end of contests")
{
    string[] tokens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
    string contest = tokens[0];
    string password = tokens[1];

    if (!contests.ContainsKey(contest))
    {
        contests.Add(contest, password);
    }

    input = Console.ReadLine();
}

input = Console.ReadLine();
while (input != "end of submissions")
{
    string[] tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
    string contest = tokens[0];
    string password = tokens[1];
    string user = tokens[2];
    int score = int.Parse(tokens[3]);

    if (contests.ContainsKey(contest) && contests[contest] == password)
    {
        if (!candidates.ContainsKey(user))
        {
            candidates.Add(user, new Dictionary<string, int>());
            results.Add(user, 0);
        }

        if (!candidates[user].ContainsKey(contest))
        {
            candidates[user].Add(contest, score);
            results[user] += score;
        }
        else if (candidates[user][contest] < score)
        {
            results[user] += score - candidates[user][contest];
            candidates[user][contest] = score;
        }
    }

    input = Console.ReadLine();
}

foreach (var (key, value) in results.OrderByDescending(x => x.Value).Take(1))
{
    Console.WriteLine($"Best candidate is {key} with total {value} points.");
}

Console.WriteLine("Ranking:");

foreach (var (key, value) in candidates.OrderBy(x => x.Key))
{
    Console.WriteLine(key);

    foreach (var (contest, points) in value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {contest} -> {points}");
    }
}