using System;
class StringsandObjects
{
    static void Main()
    {
        string helo = "Hello ";
        string wurld = "World";
        object signs = string.Concat(helo + wurld);
        Console.WriteLine(signs);
    }
}
