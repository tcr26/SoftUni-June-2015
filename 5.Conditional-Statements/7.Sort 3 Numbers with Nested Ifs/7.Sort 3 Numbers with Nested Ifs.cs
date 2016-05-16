using System;
class Sort3NumberswithNestedIfs
{
    static void Main()
    {
        Console.Write("Enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("Equal numbers");
        }

        else if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("The numbers are equal");
        }
        // A<B<C || A=B<C || A<B=C
        else if (firstNumber <= secondNumber && secondNumber <= thirdNumber)
        {
            Console.WriteLine("{0}\n{1}\n{2}", thirdNumber, secondNumber, firstNumber);
        }
        // A<C<B || A=C<B || A<C=B
        else if (firstNumber <= thirdNumber && thirdNumber <= secondNumber)
        {
            Console.WriteLine("{0}\n{1}\n{2}", secondNumber, thirdNumber, firstNumber);
        }
        // B<A<C || B=A<C || B<A=C
        else if (secondNumber <= firstNumber && firstNumber <= thirdNumber)
        {
            Console.WriteLine("{0}\n{1}\n{2}", thirdNumber, firstNumber, secondNumber);
        }
        // B<C<A || B=C<A || B<C=A
        else if (secondNumber <= thirdNumber && thirdNumber <= firstNumber)
        {
            Console.WriteLine("{0}\n{1}\n{2}", firstNumber, thirdNumber, secondNumber);
        }
        // C<A<B || C=A<B || C<A=B
        else if (thirdNumber <= firstNumber && firstNumber <= secondNumber)
        {
            Console.WriteLine("{0}\n{1}\n{2}", secondNumber, firstNumber, thirdNumber);
        }
        // C<B<A || C=B<A || C<B=A
        else if (thirdNumber <= secondNumber && secondNumber <= firstNumber)
        {
            Console.WriteLine("{0}\n{1}\n{2}", firstNumber, secondNumber, thirdNumber);
        }
        Main();
    }
}

