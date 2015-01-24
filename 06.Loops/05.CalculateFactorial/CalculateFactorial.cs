using System;

class CalculateFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        int factN = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;

            sum = sum + (factN / Math.Pow(x,i));

        }

        Console.WriteLine("{0:0.00000}",sum);
         

    }
}

