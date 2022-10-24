namespace Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015,2,2);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Current time: {0}:{1}", now.Hour, now.Minute);

            now.AddDays(1);
            now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd"));

            // TimeSpan
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var duration = timeSpan - timeSpan1;
            Console.WriteLine("Duration: {0}", duration);

            // Properties
            Console.WriteLine(timeSpan1.Minutes);
            Console.WriteLine(timeSpan2.TotalMinutes);

            // Add
            timeSpan.Add(TimeSpan.FromMinutes(8));
            Console.WriteLine(timeSpan);

            // toString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}