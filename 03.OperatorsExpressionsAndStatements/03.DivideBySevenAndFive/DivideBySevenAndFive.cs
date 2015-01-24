using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Number: ");
        int n = int.Parse(Console.ReadLine());
        bool isDivideByFive = (n % 5 == 0);
        bool isDivideBySeven = (n % 7 == 0);

        if (isDivideByFive && isDivideBySeven && n != 0)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

