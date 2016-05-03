using System;
class QuotesinStrings
{
    static void Main()
    {
        string edno = "The \"use\" of quotations causes difficulties.";
        string dve = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(edno);
        Console.WriteLine(dve);
    }
}

