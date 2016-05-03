using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter Odd Number: ");
        string input = Console.ReadLine();

        int n;

        bool isParsed = int.TryParse(input, out n);

        if (!isParsed)
        {
            Console.WriteLine("Invalid Input! Enter a number please.");
            Main();
        }

        if (n < 3 || n % 2 == 0)
        {
            Console.WriteLine("{0} is Invalid Number! {0} / 2 = {1} ", n, n / 2);
            Main();
        }

        if (n > 9)
        {
            Console.WriteLine("The number {0} is too large! Please enter an integer below 9", n);
            Main();
        }

        Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));

        for (int i = 0; i < n - 2; i++)
        {
            if (i != (n / 2) - 1)
            {
                Console.WriteLine("{0}{2}{0}{1}{0}{2}{0}", '*', new string(' ', n), new string('/', (n * 2 - 2)));
            }
            else if (i == (n / 2) - 1)
            {
                Console.WriteLine("{0}{2}{0}{1}{0}{2}{0}", '*', new string('|', n), new string('/', (n * 2 - 2)));
            }
        }

        Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
        Main();
    }
}

