using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Number:");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (n > 0 && n != 1)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        else if (n == 1)
        {
            isPrime = false;
        }
        else if (n == 0)
        {
            isPrime = false;
        }
        if (isPrime)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

