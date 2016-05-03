using System;
using System.Text;
class ASCIITablePrint
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (short counter = 0; counter < 255; counter++)
        {
            char symbol = (char)counter;
            Console.Write("# {0} symbol is: {1}", counter, symbol);
        }
    }
}