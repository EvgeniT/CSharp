using System;

class CatalanNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int factN = 1;
        int factNmultiBy2 = 1;
        int factNplus1 = 1;
        int resultCn = 1;

            // loop for N!
            for (int i = 1; i <= N; i++)
            {
                factN *= i;
            }

            // loop for (2*N)!
            for (int i = 1; i <= 2 * N; i++)
            {
                factNmultiBy2 *= i;
            }

            // loop for (N + 1)!
            for (int i = 1; i <= N + 1; i++)
            {
                factNplus1 *= i;
            }

            resultCn = factNmultiBy2 / (factNplus1 * factN);
            Console.WriteLine(resultCn);

    }
}

