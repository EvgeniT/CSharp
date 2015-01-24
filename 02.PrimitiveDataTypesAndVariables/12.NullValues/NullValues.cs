using System;

class NullValues
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);

        a = a + 5;
        b = b + 6;
        Console.WriteLine(a);
        Console.WriteLine(b);

    }
}

