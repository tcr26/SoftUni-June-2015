﻿using System;
class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        float precision = 0.000001f;
        bool areEqual = (Math.Abs(firstNumber - secondNumber) < precision);
        Console.WriteLine(areEqual);
        Main();
    }
}
