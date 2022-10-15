using Classes.Math;

namespace Classes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Chetraru";
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(2, 4);
            Console.WriteLine(result);

        }
    }
}