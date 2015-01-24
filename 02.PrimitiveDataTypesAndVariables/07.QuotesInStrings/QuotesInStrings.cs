using System;

class QuotesInStrings
{
    static void Main()
    {
        
        String a = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(a);

            String b = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(b);
    }
}

