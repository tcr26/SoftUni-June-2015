using System;
class NthDigit
{
    static void Main()
    {
        //take number ,take digit position, number / (Math.Pow(10, digit) % 10), print result;


        int number = int.Parse(Console.ReadLine()); //number
        int digit = int.Parse(Console.ReadLine()); //n
        double result = (number / (double) Math.Pow(10, digit - 1)) % 10; //result
        if (result >= 1)
        {
            Console.WriteLine("Rezultata e {0}", (int) result);
        }
        else
        {
            Console.WriteLine("-");
        }
        Main();
    }
}