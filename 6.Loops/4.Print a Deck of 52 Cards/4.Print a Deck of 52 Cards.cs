using System;
class PrintDeckCards
{
    static void Main()
    {

        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int numberSuits = 4;
        int numberCards = 13;
        for (int i = 0; i < numberCards; i++)
        {
            string card = cards[i];
            for (int j = 1; j <= numberSuits; j++)
            {
                switch (j)
                {
                    case 1: Console.Write("{0,2}\u2663", card); break;
                    case 2: Console.Write("{0,2}\u2666", card); break;
                    case 3: Console.Write("{0,2}\u2665", card); break;
                    case 4: Console.WriteLine("{0,2}\u2660", card); break;
                }
            }
        }
    }
}


//deck solution

//using System;
//using System.Text;

//class PrintDeckOf52Cards
//{
//    static void Main()
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        char clubs = '\u2663';
//        char diamonds = '\u2666';
//        char hearts = '\u2665';
//        char spades = '\u2660';

//        for (int i = 2; i <= 14; i++)
//        {
//            for (int j = 1; j <= 4; j++)
//            {
//                switch (i)
//                {
//                    case 2: Console.Write("2"); break;
//                    case 3: Console.Write("3"); break;
//                    case 4: Console.Write("4"); break;
//                    case 5: Console.Write("5"); break;
//                    case 6: Console.Write("6"); break;
//                    case 7: Console.Write("7"); break;
//                    case 8: Console.Write("8"); break;
//                    case 9: Console.Write("9"); break;
//                    case 10: Console.Write("10"); break;
//                    case 11: Console.Write("J"); break;
//                    case 12: Console.Write("Q"); break;
//                    case 13: Console.Write("K"); break;
//                    case 14: Console.Write("A"); break;
//                    default: break;
//                }
//                switch (j)
//                {
//                    case 1: Console.Write(clubs + " "); break;
//                    case 2: Console.Write(diamonds + " "); break;
//                    case 3: Console.Write(hearts + " "); break;
//                    case 4: Console.Write(spades + " "); break;
//                    default: break;
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}