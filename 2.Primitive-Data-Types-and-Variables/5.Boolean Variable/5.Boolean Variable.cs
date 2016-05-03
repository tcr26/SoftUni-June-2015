using System;
    class BooleanVariable
    {
        static void Main()
        {
            bool isFemale = false;
            Console.WriteLine("Are you a Female? (Yes/No): ");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                isFemale = true;
                Console.WriteLine(isFemale);
            }
            else if (answer == "No")
            {
                isFemale = false;
                Console.WriteLine(isFemale);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

