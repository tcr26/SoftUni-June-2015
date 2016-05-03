using System;
    class Program
    {
        static void Main()
        {
            string binNumber = Console.ReadLine();
            long decNumber = 0;
            int power = 1;
            for (int i = binNumber.Length-1; i >= 0; i--)
            {
                int num = binNumber[i] - 48;
                decNumber += num * power;
                power *= 2;
            }
            Console.WriteLine(decNumber);
            Main();
        }
    }


//solution
//long num, binary_val, decimal_val = 0, base_val = 1, rem;

//            Console.Write("Enter a Binary Number(1s and 0s) : ");

//            num = long.Parse(Console.ReadLine()); /* maximum five digits */

//            binary_val = num;

//            while (num > 0)
//            {
//                rem = num % 10;
//                decimal_val = decimal_val + rem * base_val;
//                num = num / 10;
//                base_val = base_val * 2;
//            }

//            Console.Write("The Binary Number is : " + binary_val);
//            Console.Write("\nIts Decimal Equivalent is : " + decimal_val);
//            Console.ReadLine();
//            Main();