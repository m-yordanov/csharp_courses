using System.Transactions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string
       textFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(textFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    using (StreamReader reader2 = new StreamReader(wordsFilePath))
                    {
                        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
                        string line;
                        while ((line = reader2.ReadLine()) != null)
                        {
                            string[] words = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            foreach (string word in words)
                            {
                                wordFrequency[word] = 0;
                            }
                        }
                        string currentWord = "";
                        foreach (char c in reader.ReadToEnd())
                        {
                            if (Char.IsLetter(c))
                            {
                                currentWord += c;
                            }
                            else
                            {
                                string checkWord = currentWord.ToLower();
                                if (wordFrequency.ContainsKey(checkWord))
                                {
                                    wordFrequency[currentWord.ToLower()]++;
                                }
                                currentWord = "";
                            }
                        }
                        foreach (var item in wordFrequency.OrderByDescending(x => x.Value))
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
