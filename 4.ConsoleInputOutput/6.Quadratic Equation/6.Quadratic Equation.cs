﻿using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine()); //2
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine()); //5
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());//-3
        //5*5      4 * 2 * -3
        double discriminant = (b * b) - (4 * a * c);
        if (discriminant > 0)
        {
            double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
        else if (discriminant == 0)
        {
            double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x1Andx2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No real roots");
        }
    }
}