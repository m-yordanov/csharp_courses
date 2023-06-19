﻿namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            RewriteFileWithLineNumbers(inputPath, outputPath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string
       outputFilePath)
        {
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int row = 0;
                    string line = "";
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        writer.WriteLine($"{row}. {line}");
                        row++;
                    }
                }
            }
        }
    }
}