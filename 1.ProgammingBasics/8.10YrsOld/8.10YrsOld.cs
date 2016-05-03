using System;
class TenYrs
{
    static void Main()
    {
        Console.WriteLine("Enter ur Birth Year Below (ex:1985):");
        DateTime UserYear = new DateTime(year: int.Parse(Console.ReadLine()), month: 1, day: 1);
        DateTime CurrentYear = new DateTime(year: DateTime.Now.Year, month:1, day: 1);
        
        TimeSpan tempYear = CurrentYear.Subtract(UserYear);
        int tempNumberYears = Convert.ToInt32(tempYear.Days);     
        DateTime resultyr = new DateTime(year: tempNumberYears / 365, month: 1, day: 1);
        
        resultyr = resultyr.AddYears(10);
        Console.WriteLine("After ten yrs u will be {0} yrs old" , resultyr.Year);
    }
}
