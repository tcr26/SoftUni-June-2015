using System;
using System.Text;
class FormattingNumbers
{
    static void Main()
    {
        //Console.OutputEncoding = Encoding.Unicode;
        
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.Write("Hex {0} is: {0:X}|", a);
        Console.Write("\t|Binary {1} is: |", a, (Convert.ToString(a, 2)));
        Console.Write("\t|{0,10:0.##}|", b);
        Console.Write("|{0,-10:0.###}|", c);
        Main();
    }
}

