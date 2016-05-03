using System;
using System.Globalization;
using System.Threading;
class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time (hh:mm am/pm): ");
        string timeString = Console.ReadLine();
        DateTime newDate = new DateTime();
        bool check = DateTime.TryParseExact(timeString, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDate);
        DateTime startTime = DateTime.Parse("1:00 pm");
        DateTime endTime = DateTime.Parse("3:00 am");

        if (check)
        {
            if (newDate >= startTime || newDate < endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
        Main();
    }
}