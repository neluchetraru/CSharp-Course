namespace ReferenceValueTypes
{
    public class Person
    {
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a; // Copy by value
            b++;

            // What is a? -> 10. 

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            // array1[0] = array2[0] = 0.



            var number = 1; // value type -> copy sent to Increment
            Increment(number);
            Console.WriteLine(number);

            var person = new Person(); // reference type -> addres of person sent to MakeOld
            person.Age = 20;
            MakeOld(person);
            Console.WriteLine(person.Age); 
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}