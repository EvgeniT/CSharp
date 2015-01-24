using System;

class StringsAndObjects
{
    static void Main()
    {
        String a = "Hello";
        String b = "World";
        Object c = a + " " + b;
        String d = (String)c ;
        Console.WriteLine(c);
    }
}

