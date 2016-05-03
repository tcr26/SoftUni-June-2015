using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter value for a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b:");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            double c = a;
            a = b;
            b = c;
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
        Main();
    }
}