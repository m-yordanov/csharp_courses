namespace DirectoryTraversal
{
    using System;
    using System.Globalization;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";
            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);
            WriteReportToDesktop(reportContent, reportFileName);
        }
        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionFiles = new();

            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                if(!extensionFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionFiles[fileInfo.Extension] = new List<FileInfo>();
                }

                extensionFiles[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new();

            foreach(var extensionFile in extensionFiles.OrderByDescending(ef => ef.Value.Count()))
            {
                sb.AppendLine(extensionFile.Key);

                foreach (var file in extensionFile.Value.OrderBy(f => f.Length))
                {
                    sb.AppendLine($"--{file.Name} - {file.Length / 1024:f3}kb");
                }
            }
            return sb.ToString();
        }
        public static void WriteReportToDesktop(string textContent, string
       reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + reportFileName;
        }
    }
}
