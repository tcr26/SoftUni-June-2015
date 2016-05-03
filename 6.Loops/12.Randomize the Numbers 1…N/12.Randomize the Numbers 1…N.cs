using System;
class RandomizetheNumbers1N
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        Console.WriteLine();

        if (n == 0 || n < 0)
        {
            Console.WriteLine("Invalid Input");
        }

        if ((n > 1 || !(n == 1)))
        {
            for (int i = 0; i <= n + 1; i++)
            {
                int result = rnd.Next(n);
                Console.Write("{0} ", result);
            }
        }
        Console.WriteLine();
        Main();
    }
}

//array solution
//            int num = int.Parse(Console.ReadLine());
//            int[] array = new int[num];
//            for (int index = 0; index < num; index++)
//            {
//                array[index] = index + 1;
//            }

//            Random random = new Random();
//            foreach (int index in array)
//            {
//                int randNum = random.Next(0, num);
//                int temp = array[randNum];
//                array[randNum] = array[0];
//                array[0] = temp;
//            }
//            Console.WriteLine(String.Join(" ", array));
//        }
