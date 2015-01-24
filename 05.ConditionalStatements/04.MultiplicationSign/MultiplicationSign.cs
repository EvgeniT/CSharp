using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if (Math.Sign(a) * Math.Sign(b) * Math.Sign(c) > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

