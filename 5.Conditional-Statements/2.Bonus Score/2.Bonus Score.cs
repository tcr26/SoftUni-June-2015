using System;
class BonusScore
{
    static void Main()
    {

        int i = int.Parse(Console.ReadLine());


        if (i >= 1 && i <= 3)
        {
            Console.WriteLine((i * 10));
        }

        if (i >= 4 && i <= 6)
        {
            Console.WriteLine((i * 100));
        }
        if (i >= 7 && i <= 9)
        {
            Console.WriteLine((i * 1000));
        }
        if (i <= 0 || i > 9)
        {
            Console.WriteLine("invalid score");
        }

        Main();
    }
}

