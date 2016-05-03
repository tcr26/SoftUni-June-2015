using System;
class TwoIntegerExchangeValues
{
    static void Main()
    {
        //11.Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int tempNumber = secondNumber;
        secondNumber = firstNumber;
        firstNumber = tempNumber;
        Console.WriteLine("Values after the exchange\nFirst Number: {0}\nSecond Number: {1}\n", firstNumber, secondNumber);
    }
}