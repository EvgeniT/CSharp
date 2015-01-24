﻿using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());
        string aBin = Convert.ToString(a,2);
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:0.000}|",a,aBin.PadLeft(10,'0'),b,c);
    }
}

