using System;
class Sumof5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 number separated by space: ");
        string[] number = Console.ReadLine().Split(' ');
        double a = double.Parse(number[0]);
        double b = double.Parse(number[1]);
        double c = double.Parse(number[2]);
        double d = double.Parse(number[3]);
        double e = double.Parse(number[4]);
        double sum = (a + b + c + d + e);
        Console.WriteLine(sum);
    }
}

