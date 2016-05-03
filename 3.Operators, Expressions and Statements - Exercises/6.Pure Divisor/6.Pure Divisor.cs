using System;
class PureDivisor
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool a = number % 9 == 0 | number % 11 == 0 | number % 13 == 0;
        Console.WriteLine("Bla bla: {0}", a);


        //if (number % 9 == 0 | number % 11 == 0 | number % 13 == 0)
        //{
        //    Console.WriteLine("True");
        //}
        //else
        //{
        //    Console.WriteLine("False");
        //}
        
        Main();
    }
}

