using System;
class JorotheFootballPlayer
{
    static void Main(string[] args)
    {
        string leap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double totalPlays = 0;

        totalPlays += h;
        totalPlays += (52 - h) * 2 / 3;
        totalPlays += p / 2;

        if (leap == "t")
        {
            totalPlays += 3;
        }
        int total = (int)Math.Round(totalPlays);
        Console.WriteLine(totalPlays);
    }
}

