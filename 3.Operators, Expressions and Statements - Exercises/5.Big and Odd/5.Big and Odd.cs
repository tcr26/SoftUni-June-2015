using System;
class BigandOdd
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()); //vuvejda se chislo
        if (number >= 20 & number % 2 != 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
