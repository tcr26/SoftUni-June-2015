using System;
class GravitationontheMoon
{
    static void Main()
    {
        Console.Write("Въведи Килограми: ");
        double kg = double.Parse(Console.ReadLine());
        Console.WriteLine("Ако на Земята Тежиш {0}, то на Луната ще тежиш {1}", kg, ((kg * 17) / 100));
        Main();

        //double EarthKg = double.Parse(Console.ReadLine());
        //double Kg = EarthKg * 0.17;
        //Console.WriteLine(Kg);
    }
}

