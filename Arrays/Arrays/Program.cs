namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            // default 0
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            // initialization
            var names = new string[3] { "Jogn", "Aby", "Mary" };


            // Matrix
            var matrix = new int[3, 5]{
                {1, 2, 3,4,5},
                {1,2,3,4,5},
                {1,2,3,4,5}
            };

            Console.WriteLine(matrix[2,4]);

            // Length
            Console.WriteLine("The size of the matrix is: {0}", matrix.Length);


            numbers = new int[]{1,2,3,4,5,6,7,8,9};
            //IndexOf
            Console.WriteLine("The index of number 4 is: {0}", Array.IndexOf(numbers, 5));


            // Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("The array after clearing first 2 elements: ");
            foreach(var num in numbers)
            {
                Console.Write(num + " ");
            }

            // Copy
            var numbersCopy = new int[3];
            Array.Copy(numbers, numbersCopy, 3);
            Console.WriteLine("The values of the new array after copying from numbers: ");
            foreach(var num in numbersCopy)
            {
                Console.Write(num + " ");
            }

            // Sort
            Array.Sort(numbers);

            // Reverse
            Array.Reverse(numbers);
            
        }
    }
}