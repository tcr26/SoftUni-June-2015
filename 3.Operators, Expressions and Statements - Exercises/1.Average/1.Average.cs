using System;
class Average
{
    static void Main()
    {
        Console.Write("Chislo: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Chislo: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Chislo: ");
        double c = double.Parse(Console.ReadLine());
        double sum = (a + b + c) / 3;
        Console.WriteLine("Sumata ot:{0} + {1} + {2} e: {3}", a, b, c, sum);
    }
}

