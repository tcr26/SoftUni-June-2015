using System;
class EmployeeData
{
    static void Main()
    {
        Console.Write("First Name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string LastName = Console.ReadLine();
        Console.Write("Age: ");
        byte Age = byte.Parse(Console.ReadLine());
        Console.Write("Gender(Male or Female): ");
        string Gender = (Console.ReadLine());
        Console.Write("ID: ");
        int IdNumber = int.Parse(Console.ReadLine());
        Console.Write("UEN: ");
        int UEN = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('=', 26));
        Console.WriteLine("Employee Record \n{0} \n{1} \n{2} \n{3} \n{4} \n{5}", FirstName, LastName, Age, Gender, IdNumber, UEN);
    }
}

