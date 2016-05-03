using System;
class pthBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        //bool id = (n & (1 << p)) > 0;
        //if (id == true)
        //{
        //    Console.WriteLine("1");
        //}
        //else
        //{
        //    Console.WriteLine("0");
        //}
        Console.WriteLine((n & (1 << p)) > 0 ? "true" : "false");
        Main();

    }
}
