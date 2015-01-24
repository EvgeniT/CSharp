using System;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Bank name:");
        string bankName = Console.ReadLine();
        
        Console.WriteLine("Client first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Client middle name:");
        string middleName = Console.ReadLine();

        Console.WriteLine("Client last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Client BALANCE:");
        decimal balance = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Client IBAN:");
        string iban = Console.ReadLine();

        Console.WriteLine("Credit card one:");
        string cardOne = Console.ReadLine();

        Console.WriteLine("Credit card two:");
        string cardTwo = Console.ReadLine();

        Console.WriteLine("Credit card three:");
        string cardThree = Console.ReadLine();


       
        Console.WriteLine("Bank name: "+ bankName);
        Console.WriteLine("Client name: "+ "{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Client Iban: " + iban);
        Console.WriteLine("Credit card one: " + cardOne);
        Console.WriteLine("Credit card two: " + cardTwo);
        Console.WriteLine("Credit card three: " + cardThree);




    }
}

