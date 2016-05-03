using System;
    class PointinaCircle
    {
        static void Main()
        {
            Console.Write("Vuvedi X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Vuvedi Y: ");
            int y = int.Parse(Console.ReadLine());
            bool inCircle = (((x * x) + (y * y)) <= 2 * 2);
            Console.WriteLine(inCircle);
        }
    }
