﻿using System;
class DecimaltoBinaryNumber
{
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        string binNumber = "";

        while (decNumber!=0)
        {
            int remain = (int)decNumber % 2;
            decNumber /= 2;
            binNumber = remain + binNumber;
        }
        Console.WriteLine(binNumber);
        Main();
    }
}

