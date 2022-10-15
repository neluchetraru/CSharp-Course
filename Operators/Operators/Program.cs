namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a / b);  // integer division: 3
            Console.WriteLine((float)a / b);

            var c = 4;
            Console.WriteLine(a+b*c);
        }
    }
}