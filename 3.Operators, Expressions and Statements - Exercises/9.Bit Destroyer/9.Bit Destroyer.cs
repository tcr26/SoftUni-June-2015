using System;
class BitDestroyer
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());

        //input position
        int p = int.Parse(Console.ReadLine());

        ///mask
        int mask = 7;

        ///result
        int result = n & ~(mask << p);

        Console.WriteLine(result);

        Main();
    }
}
