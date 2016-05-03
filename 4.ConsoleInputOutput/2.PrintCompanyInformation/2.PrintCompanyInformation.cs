using System;

class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string adress = Console.ReadLine();
        int phoneNumber = int.Parse(Console.ReadLine());
        int faxNumber = int.Parse(Console.ReadLine());
        string webSite = Console.ReadLine();
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        int managerPhone = int.Parse(Console.ReadLine());

        Console.WriteLine("Company Name:{0} \nAdress:{1} \nPhone Number:{2} \nFax Number:{3} \nWeb Site:{4} \nFirst Name of Manager:{5} \nLast Name of Manager:{6} \nManager Age:{7} \nManager Phone:{8}", companyName, adress, phoneNumber, faxNumber, webSite, firstName, lastName, managerAge, managerPhone);
    }
}

