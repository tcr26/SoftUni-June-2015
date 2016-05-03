using System;
class TriBitSwitch
{
    static void Main()
    {
        //input
        long n = long.Parse(Console.ReadLine());

        //position
        int p = int.Parse(Console.ReadLine());

        //maska
        long mask = ((long)7 << p);

        for (int i = 0; i < 59; i++)
        {
            int a = 7 << i;
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));
        }

        long result = n ^ mask;

        Console.WriteLine(result);

        Main();
    }
}



//result
//3652421623 7 3652420727
//2135693832857285912 59 2712154585160709400

