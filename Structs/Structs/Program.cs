namespace Structs
{
    class Program
    {
        public struct RGBColor
        {
            public int Red;
            public int Green;
            public int Blue;
            public RGBColor(int r, int g, int b)
            {
                Red = r;
                Green = g;
                Blue = b;
            }
        }
        public static void Main(string[] args)
        {
            var greenish = new RGBColor(0, 255, 12);
            Console.WriteLine(greenish.Green);

        }
    }
}