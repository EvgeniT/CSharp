using System;

class CalculateKdividedByNFactoriels
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorialN = 1;
        int factorialK = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN = factorialN * i;
        }
        for (int i = 1; i <= k; i++)
        {
            factorialK = factorialK * i;
        }
        double result = factorialN / factorialK;
        Console.WriteLine(result);
    }
}

