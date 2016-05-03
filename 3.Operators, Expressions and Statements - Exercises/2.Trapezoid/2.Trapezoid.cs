using System;
class Trapezoid
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("Area of Trapozoid With:\nA side: {0} \nand \nB side: {1} \nand Height: {2} \nis: {3}", a, b, h, area);
    }
}
