using System;

class PrintLongSequence
{
    static void Main()
    {
        int i = 0;
        for (i = 2; i < 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ",");
            }
            else
            {
                Console.Write(-i + ",");
            }
        }
        Console.WriteLine();
    }
}