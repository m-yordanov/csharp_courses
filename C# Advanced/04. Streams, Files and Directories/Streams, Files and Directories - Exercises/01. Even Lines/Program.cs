namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = string.Empty;
                StringBuilder sb = new StringBuilder();
                int count = 0;
                while (line != null)
                {
                    line = reader.ReadLine();

                    if (count % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string reversedWords = ReverseWords(replacedSymbols);
                        sb.AppendLine(reversedWords);
                    }

                    count++;
                }

                return sb.ToString();
            }
        }

        private static string ReplaceSymbols(string line)
        {
            StringBuilder sb = new(line);

            char[] symbolsToReplace = { '-', ',', '.', '!', '?' };

            foreach(char symbol in symbolsToReplace)
            {
                sb = sb.Replace(symbol, '@');
            }

            return sb.ToString();
        }

        private static string ReverseWords(string words)
        {
            string[] reversedWords = words.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            return string.Join(" ", reversedWords);
        }
    }
}