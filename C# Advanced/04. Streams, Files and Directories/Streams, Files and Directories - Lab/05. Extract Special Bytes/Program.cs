using System.Text;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] bytesToExtract = ReadBytesFromFile(bytesFilePath);

            using (FileStream inputFileStream = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream outputFileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        foreach (byte byteToExtract in bytesToExtract)
                        {
                            for (int i = 0; i < bytesRead; i++)
                            {
                                if (buffer[i] == byteToExtract)
                                {
                                    outputFileStream.WriteByte(buffer[i]);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static byte[] ReadBytesFromFile(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            return bytes;
        }
    }
}
