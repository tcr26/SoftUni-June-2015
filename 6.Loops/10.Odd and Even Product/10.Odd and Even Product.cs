using System;
class OddandEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] array = input.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < array.Length; i++)
        {
            int number = int.Parse(array[i]);
            
            if (i % 2 == 0 || i == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }
        
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd procuct = {0}", oddProduct);
            Console.WriteLine("even procuct = {0}", evenProduct);
        }
        Main();
    }
}
