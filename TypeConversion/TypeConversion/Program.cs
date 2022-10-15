

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 256;
            byte b = (byte)i;
            Console.WriteLine(b);

            // Using Convert
            var number = "2343";
            int x = Convert.ToInt32(number);
            Console.WriteLine(x);


            // Exception handling
            try
            {
                var number1 = "1234";
                byte b1 = Convert.ToByte(number1);
                Console.WriteLine(b1);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to byte.");
            }



        }
    }
}