﻿using System;

class SortThreeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else //(b<c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
        }
        if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else //(a<c)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        if (c > a && c > b)
        {
            if (a > b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else//(b>a)
            {
                Console.WriteLine("{0} {1} {2}",c,b,a);
            }
        }
        if (a == b && b == c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}

