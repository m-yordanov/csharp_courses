namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream sourceFileStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                long fileSize = sourceFileStream.Length;
                long partOneSize = fileSize / 2;
                long partTwoSize = fileSize - partOneSize;

                using (FileStream partOneFileStream = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    long bytesRead = 0;
                    int bytesToRead;

                    while (bytesRead < partOneSize && (bytesToRead = sourceFileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        partOneFileStream.Write(buffer, 0, bytesToRead);
                        bytesRead += bytesToRead;
                    }
                }

                using (FileStream partTwoFileStream = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    long bytesRead = 0;
                    int bytesToRead;

                    while (bytesRead < partTwoSize && (bytesToRead = sourceFileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        partTwoFileStream.Write(buffer, 0, bytesToRead);
                        bytesRead += bytesToRead;
                    }
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream joinedFileStream = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
            {
                using (FileStream partOneFileStream = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = partOneFileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        joinedFileStream.Write(buffer, 0, bytesRead);
                    }
                }

                using (FileStream partTwoFileStream = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = partTwoFileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        joinedFileStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}