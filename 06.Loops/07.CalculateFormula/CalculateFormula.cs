using System;

class CalculateFormula
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorielN = 1;
        int factorielK = 1;


        for (int i = 1; i <= n; i++)
        {
            factorielN = i * factorielN;
        }

        for (int i = 1; i <= k; i++)
        {
            factorielK = i * factorielK;
        }


        int result = factorielN / (factorielK * (n - k));
        Console.WriteLine(result);
    }
}

