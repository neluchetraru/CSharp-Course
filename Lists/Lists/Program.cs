namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4};

            // Add
            numbers.Add(1);

            // AddRange
            numbers.AddRange(new int[] { 3, 4, 5 });

            // IndexOf
            Console.WriteLine("Index of 1 is {0}",numbers.IndexOf(1));

            // LastIndexOf
            Console.WriteLine("Last Index of 1 is {0}", numbers.LastIndexOf(1));

            // Count
            Console.WriteLine("Count: {0}",numbers.Count);

            // Remove
            numbers.Remove(3);
            Console.WriteLine("The list after removing 3 is: ");
            foreach(var num in numbers)
            {
                Console.Write(num + " ");
            }

            // Clear
            numbers.Clear();
        }
    }
}