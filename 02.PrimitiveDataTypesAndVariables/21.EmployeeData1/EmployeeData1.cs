using System;

class EmployeeData1
{
    static void Main()
    {
        Console.WriteLine("Enter Employer First Name:");
        String firstName = Console.ReadLine();

        Console.WriteLine("Enter Employer Last Name:");
        String lastName = Console.ReadLine();
       
        Console.WriteLine("Enter Employer Age:");
        byte age = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter Employer Gender:");
        string gender = Console.ReadLine();

        Console.WriteLine("Enter Employer Personal ID:");
        string personalID = Console.ReadLine();

        Console.WriteLine("Enter Employer Unique ID:");
        string uniqueID = Console.ReadLine();

        Console.WriteLine("First Name:" + firstName);
        Console.WriteLine("Last Name:" + lastName);
        Console.WriteLine("Age:" + age);
        Console.WriteLine("Gender:" + gender);
        Console.WriteLine("PersonalID:" + personalID);
        Console.WriteLine("Unique Employ Number:" + uniqueID);
    }
}

