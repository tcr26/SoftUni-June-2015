using System;
class OddorEven
{
    static void Main()
    {        
        
        while (true)
        {
            Console.Write("Въведи число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((number % 2 == 0) ? "It's even" : "It's odd");
        }
    }
}

