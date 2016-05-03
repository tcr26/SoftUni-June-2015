using System;
class PointyTriangle
{
    static void Main()
    {
        int row, column;

        Console.WriteLine("Enter Number 1-10: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (n < 3 || n >= 10)
        {
            Console.WriteLine("Invalid Input!");
            Main();
        }

        for (row = 1; row < n; row++)
        {
            for (column = 1; column < row + 1; column++)
            {
                Console.Write(column);
            }
            Console.Write("\n");
        }

        for (row = n; row > 0; row--)
        {
            for (column = 1; column + 1 < row; column++)
            {
                Console.Write(column);
            }
            Console.Write("\n");
        }
        Main();
    }
}