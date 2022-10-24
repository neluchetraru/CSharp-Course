namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Ion";
            var lastName = "Chetraru";
            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}",firstName,lastName);


            var names = new string[3] { "Ion", "Abi", "John" };
            var formattedNames = string.Join(",", names);
            //Console.WriteLine(formattedNames);

            var text = "Hi, Ion\nLook into the following paths\nC:\\Users\\Ion";
            //Console.WriteLine(text);

            var text1 = @"Hi, Ion
Look into the following paths
C:\Users\Ion";
            //Console.WriteLine(text1);

            // Formatting

            fullName = "Chetraru Ion   ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());


            if (String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid message");

            var str = "35";
            var age = Convert.ToByte(str);
            Console.WriteLine("Age: {0}", age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

            Console.WriteLine(StringUtility.SummarizeText("Really really really really loong text."));


            

        }

        
    }
}