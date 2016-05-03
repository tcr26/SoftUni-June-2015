using System;

class Sumof3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of {0} + {1} + {2} = {3}", a, b, c, (a + b + c));
        Main();
    }
}

