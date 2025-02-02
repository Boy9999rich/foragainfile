namespace withFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\user\Videos\fox.mp4";
            CopyFileAtOnce(filePath, @"D:\MeningPapkam\extrafile");
        }

        public static void CopyFileAtOnce(string filePath, string newFile)
        {
            var fileExtension = Path.GetExtension(filePath);
            var destinationFilePath = Path.Combine(Directory.GetCurrentDirectory(), newFile + fileExtension);

            using(FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using(FileStream destinationFile = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
                {
                    fileStream.CopyTo(destinationFile);
                }
            }
        }


        //public static void CopyFileWithChunks(string filePath, string newFile)
        //{
        //    var fileExtension = Path.GetExtension(filePath);
        //    var destinationFilePath = Path.Combine(Directory.GetCurrentDirectory(), newFile + fileExtension);

        //    var bytes = 1024 * 1024 * 100;
        //    byte[] buffer = new byte[bytes];
        //    int byteRead;

        //    using(FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        //    {
        //        using(FileStream destinationFile = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
        //        {
        //            while (true)
        //            {
        //                byteRead = fileStream.Read(buffer, 0, buffer.Length);
        //                if (byteRead <= 0) break;
        //                destinationFile.Write(buffer, 0, byteRead);
        //            }
        //        }
        //    }
        //}

        //public static void CopyFileWithChunks2(string filePath, string newFile)
        //{
        //    var fileExtension = Path.GetExtension(filePath);
        //    var destinationFilePath = Path.Combine(Directory.GetCurrentDirectory(), newFile + fileExtension);
        //    var fileInfo = new FileInfo(filePath);
        //    var fileLength = fileInfo.Length;

        //    var bytes = 1024 * 1024 * 2;
        //    byte[] buffer = new byte[bytes];
        //    //int byteRead;

        //    var bytePercent = bytes / fileLength * 100;
        //    var percent = bytePercent;

        //    using(FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        //    { 
        //        using(FileStream destinationFile = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
        //        {
        //            while (true)
        //            {
        //                Console.WriteLine($"{percent} % ");
        //                percent += bytePercent;
        //                var byteRead = fileStream.Read(buffer, 0, buffer.Length);
        //                if (byteRead <= 0) break;
        //                destinationFile.Write(buffer, 0, byteRead);
        //            }
        //        }
        //    }

        //}

    }
}
