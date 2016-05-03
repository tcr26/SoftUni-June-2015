using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("Enter Number: ");
        int n = int.Parse(Console.ReadLine());
        int sum = new int();
        int minVal = int.MaxValue;
        int maxVal = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < minVal)
            {
                minVal = number;
            }
            else if (number > maxVal)
            {
                maxVal = number;
            }
            sum += number;
        }
        float avarage = sum / (float)n;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F}",
            minVal, maxVal, sum, avarage);
    }
}

//array solution

//Console.WriteLine("Enter the number of numbers:");
//        int n = int.Parse(Console.ReadLine());
//        int []num=new int[n];
//        int sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("Enter an integer:");
//            num[i] =int.Parse(Console.ReadLine());
//            sum += num[i];
//        }
//        int min = num[0];
//        int max = num[0];
//        for (int i = 1; i < n; i++)
//        {   
//            if (min>num[i])
//            {
//                min = num[i];
//            }
//            if (max < num[i])
//            {
//                max = num[i];
//            }
//        }
//        Console.WriteLine("min={0}",min);
//        Console.WriteLine("max={0}",max);
//        Console.WriteLine("sum={0}",sum);
//        Console.WriteLine("average={0:F2}", (double)sum/n);

