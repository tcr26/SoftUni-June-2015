using System;
class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 7;

        uint firstBit = (n & (mask << 3)) >> 3;
        uint secondBit = (n & (mask << 24)) >> 24;

        n = n & ~(mask << 3);
        n = n & ~(mask << 24);

        n = n | (firstBit << 24);
        n = n | (secondBit << 3);
        Console.WriteLine(n);

    }
}
