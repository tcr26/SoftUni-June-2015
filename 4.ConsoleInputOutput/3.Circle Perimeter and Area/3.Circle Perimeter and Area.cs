using System;
class CirclePerimeterandArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double perimeter = (Math.PI * r) * 2;
        double area = Math.PI * (Math.Pow(r, 2));
        Console.WriteLine("{0:0.00}", perimeter);
        Console.WriteLine("{0, 0:F2}", area);
        Main();
    }
}
