using System;
class ExpressionCheckMod
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool divided = n % 5 == 0 && n % 7 == 0;
        Console.WriteLine(divided);
        Main();



        //for (int i = 1; i <= 140; i++)
        //{
        //    if (i % 5 == 0 & i % 7 == 0)
        //    {
        //        Console.WriteLine("{0}: Deli se na 5 i 7", i);
        //    }
        //}
    }
}