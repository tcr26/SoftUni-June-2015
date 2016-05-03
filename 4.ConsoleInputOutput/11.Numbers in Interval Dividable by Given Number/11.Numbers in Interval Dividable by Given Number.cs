using System;
class NumbersinIntervalDividablebyGivenNumber
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int p = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        if (p > 0)
        {
            Console.WriteLine(p);
        }
        else
        {
            Console.WriteLine("-", p);
        }
        Main();
    }
}

