using System;
class Numbersfrom1toN
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        for (int i = 1; i <= a; i++)
        {
            Console.Write("{0,5}", i);
        }
    }
}

