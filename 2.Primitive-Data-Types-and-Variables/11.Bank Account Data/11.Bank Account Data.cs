using System;
    class BankAccountData
    {
        static void Main()
        {
            Console.Write("First Name: ");
            string FirstName = Console.ReadLine();
            
            Console.Write("Middle Name: ");
            string MidName = Console.ReadLine();
            
            Console.Write("Last Name: ");
            string LastName = Console.ReadLine();
            
            Console.Write("Balance: ");
            ulong Balance = ulong.Parse(Console.ReadLine());
            
            Console.Write("Enter ur Bank Name: ");
            string BankName = Console.ReadLine();
            
            Console.Write("IBAN: ");
            ulong IBAN = ulong.Parse(Console.ReadLine());

            Console.Write("CreditCardNumber: ");
            ulong CreditCard1 = ulong.Parse(Console.ReadLine());
            Console.Write("CreditCardNumber: ");
            ulong CreditCard2 = ulong.Parse(Console.ReadLine());
            Console.Write("CreditCardNumber: ");
            ulong CreditCard3 = ulong.Parse(Console.ReadLine());

            Console.WriteLine("=====Bank Account=====");
            Console.WriteLine("Name: {0} {1} {2} \nBalance: {3} \nBankName: {4} \nIBAN:  {5}\nCreditCard:\n 1. {6} \n 2. {7}\n 3. {8}", FirstName, MidName, LastName, Balance, BankName, IBAN, CreditCard1,CreditCard2, CreditCard3);
        }
    }