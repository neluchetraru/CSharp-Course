using System.Text;

namespace StringBuilderExplore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder()
                .Append('-', 20)
                .AppendLine()
                .AppendLine("Header")
                .AppendLine()
                .Append('-', 20)
                .Replace('-', '=');

            Console.WriteLine("21st character: {0}", builder[21]);
            Console.WriteLine(builder);

            

        }
    }
}