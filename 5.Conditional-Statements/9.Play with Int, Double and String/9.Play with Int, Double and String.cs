using System;
class PlaywithIntDoubleandString
{
    static void Main()
    {
        Console.WriteLine("Choose a Type");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.Write("Enter an int: ");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;
            case 2:
                Console.Write("Enter an Double: ");
                double dNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(dNumber + 1);
                break;
            case 3:
                Console.Write("Enter a String: ");
                string input = Console.ReadLine();
                Console.WriteLine(input + "" + "*");
                break;

            default:
                Console.WriteLine("Invalid code...!!!");
                break;
        }
        Main();
    }
}

