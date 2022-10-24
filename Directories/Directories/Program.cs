namespace Directories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Ion\Desktop\";
            Directory.CreateDirectory(path + "folder");
            var files = Directory.GetFiles(path,"*.pdf",SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file );
        }
    }
}