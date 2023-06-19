string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Predicate<string> isUpper = w => Char.IsUpper(w[0]);
string[] upperCaseWords = text.Where(w => isUpper(w)).ToArray();

foreach (string word in upperCaseWords)
{
    Console.WriteLine(word);
}