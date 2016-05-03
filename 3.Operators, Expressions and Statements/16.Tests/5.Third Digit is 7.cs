using System;
class ThirdDigitis7
{
    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        bool isSeven = (number / 100) % 10 == 7;
        Console.WriteLine(isSeven);
        Main();


        //int p = number / 100;
        //int result = p % 10;
        //Console.WriteLine(result);
        
    }
}
