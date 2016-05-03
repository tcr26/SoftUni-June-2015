using System;

class BitsInverter
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        for (int i = 0; i < input; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                index++;
                if ((step == 1) || (index % step == 1))
                {
                    num = num ^ (1 << bit);
                }
            }
            Console.WriteLine(num);
        }
        Main();
    }
}
