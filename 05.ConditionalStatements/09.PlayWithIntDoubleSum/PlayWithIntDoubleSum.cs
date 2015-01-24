using System;

class PlayWithIntDoubleSum
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 -->  int");
        Console.WriteLine("2 -->  double");
        Console.WriteLine("3 -->  string");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                double intChoice = int.Parse(Console.ReadLine());
                double intresult = intChoice + 1;
                Console.WriteLine("{0}", intresult);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleChoice = double.Parse(Console.ReadLine());
                double doubleresult = doubleChoice + 1;
                Console.WriteLine("{0}", doubleresult);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string stringchoice = Console.ReadLine();
                Console.WriteLine("{0}*", stringchoice);
                break;
        }
    }
}


