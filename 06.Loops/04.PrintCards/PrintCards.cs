using System;

class Program
{
    static void Main()
    {

        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
        }

        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", 'J');
        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", 'D');
        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", 'K');
        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", 'A');

    }
}

