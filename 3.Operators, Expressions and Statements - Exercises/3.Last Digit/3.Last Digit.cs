using System;
class LastDigit
{
    static void Main()
    {
        double digit = double.Parse(Console.ReadLine());
        digit = digit % 10;
        Console.WriteLine(digit);
    }
}

