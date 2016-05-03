using System;

class calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int factorial = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += (factorial / Math.Pow(x, i)); //sum S = 1 + 1!/x + 2!/x2 + … + n!/xn
        }
        Console.WriteLine("{0:F5}", sum);
    }
}