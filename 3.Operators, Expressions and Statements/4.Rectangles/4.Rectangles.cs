using System;
class Rectangles
{
    static void Main()
    {
        Console.Write("Rectangle Height: ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Rectangle Width: ");
        double width = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = (width * 2) + (height * 2);
        Console.Write("area of Rectangle is: ");
        Console.WriteLine(area);
        Console.Write("perimeter of Rectangle is: ");
        Console.WriteLine(perimeter);
    }
}

