using System;
class ExtractBitfromInteger
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        uint mask = 1;
        if ((mask << p & number) == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("1");
        }
        //Console.WriteLine((mask << p & number) == 0 ? "0" : "1");
    }
}
