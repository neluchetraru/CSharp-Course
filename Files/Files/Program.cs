namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Ion\Desktop\";
            File.Copy(path + "file.txt", path + "file_copy.txt", true);
            if (File.Exists(path + "file_copy.txt"))
            {
                File.Delete(path + "file_copy.txt");
            }

            Console.WriteLine(File.ReadAllText(path + "file.txt"));

            var fileInfo = new FileInfo(path + "file.txt");
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists) ;
                //;
            
        }
    }
}