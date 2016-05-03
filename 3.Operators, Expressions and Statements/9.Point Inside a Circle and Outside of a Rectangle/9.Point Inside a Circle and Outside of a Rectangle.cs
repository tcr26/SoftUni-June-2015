using System;
class PointInsideaCircleandOutsideofaRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool inCircle = (Math.Pow(x - 1, 2) + (Math.Pow(y - 1, 2)) <= 1.5 * 1.5);
        bool inRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
        if (inCircle && !inRectangle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
