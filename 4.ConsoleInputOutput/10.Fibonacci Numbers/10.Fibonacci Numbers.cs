using System;

class SumOfNNumbers
{
    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int a = 0;
        int b = 1;
        int c = 0;
        Console.Write(a + " " + b + " ");
        for (int i = 0; i < (number -2); i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.Write(c + " ");
        }
        Main();
    }
}