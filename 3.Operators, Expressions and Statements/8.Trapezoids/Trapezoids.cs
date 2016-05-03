using System;
    class Trapezoids
    {
        static void Main()
        {
            Console.Write("Vyvedi A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Vuvedi B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Vuvedi H: ");
            double h = double.Parse(Console.ReadLine());
            double result = ((a + b) / 2) * h;
            Console.WriteLine(result);

        }
    }

