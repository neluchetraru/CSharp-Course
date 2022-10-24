namespace IterationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // even numbers 1 to ten
            for(var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for(var i = 10; i >0; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // foreach
            var name = "Chetraru Ion";
            for(var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach(var ch in name)
            {
                Console.WriteLine(ch);
            }

            // while
            var i = 0;
            while (i <= 10)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("@Echo {0}",input);
                }
            }
        }
    }
}