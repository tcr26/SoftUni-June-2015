using System;
using System.Numerics;
class Calculate
{
    static void Main()
    {
        BigInteger n = int.Parse(Console.ReadLine());
        BigInteger k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        Console.WriteLine(factorialN / factorialK);
    }
}

