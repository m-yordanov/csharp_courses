namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string[] lines = File.ReadAllLines(inputFilePath);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        writer.WriteLine($"Line {i + 1}: {lines[i]} ({lines[i].Where(char.IsLetter).ToArray().Count()})({lines[i].Where(char.IsPunctuation).ToArray().Count()})");
                    }
                }
            }
        }
    }
}