using System;
    class BitwiseExtractBit3
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint mask = 1;
            if ((mask << 3 & number) == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
            //Console.WriteLine((mask << 3 & number) == 0 ? "0" : "1");
        }
    }

