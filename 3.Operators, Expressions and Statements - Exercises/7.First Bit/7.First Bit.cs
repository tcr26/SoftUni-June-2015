using System;
class BitwiseExtractBit3
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int mask = 1;
        //if ((mask << 1 & number) == 0)
        //{
        //    Console.WriteLine("0");
        //}
        //else
        //{
        Console.WriteLine((mask << 1 & number) == 0 ? "0" : "1");
        //    Console.WriteLine("1");
        //}

        Main();
    }
}
