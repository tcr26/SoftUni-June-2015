using System;
class VariableinHexadecimalFormat
{
    static void Main()
    {
        int number = 0xFE;
        Console.WriteLine(Convert.ToInt32(number));

        int hexFormat = 0x00FE;
        Console.WriteLine("0xFE = {0}", hexFormat);
    }
}
