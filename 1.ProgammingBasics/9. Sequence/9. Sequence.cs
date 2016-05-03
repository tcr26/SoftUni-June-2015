using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("The first ten members of sequencethe sequence: 2, -3, 4, -5, 6, -7, ... are: ");
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(i * -(1));
            }
        }
    }
}

