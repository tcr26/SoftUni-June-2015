using System;
class AssignIntDoubleNull
{
    static void Main()
    {

        int? intNumber = null;
        double? doubleNumber = null;
        Console.WriteLine("integerNumber = {0}!", intNumber);
        Console.WriteLine("doubleNumber = {0}!", doubleNumber);
        Console.WriteLine("integerNumber GetValueOrDefault = {0}", intNumber.GetValueOrDefault());
        Console.WriteLine("doubleNumber HasValue? {0}\n", doubleNumber.HasValue);

        intNumber = 3;
        doubleNumber = 5.55;
        Console.WriteLine("integerNumber={0}\ndoubleNumber={1}", intNumber, doubleNumber);
        Console.WriteLine("integerNumber HasValue? {0}\ndoubleNumber GetValueOrDefault = {1}", intNumber.HasValue, doubleNumber.GetValueOrDefault());
    }
}
