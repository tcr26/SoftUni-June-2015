using System;
class RandomNumbersinGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        Console.WriteLine();        
        
        if (min <= max)
        {
            for (int i = 0; i <= n; i++)
            {
                int result = rnd.Next(min, max + 1);
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("Incorect input!");
            Main();
        }

        Main();
    }
}
