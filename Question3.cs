using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Class ID: ");
        string classID = Console.ReadLine() ?? "";

        Console.Write("Enter Registration ID: ");
        string regID = Console.ReadLine() ?? "";

        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter Submission Date: ");
        string date = Console.ReadLine() ?? "";

        Console.WriteLine("\nClass ID: " + classID);
        Console.WriteLine("Registration ID: " + regID);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Submission Date: " + date);

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0)
        {
            Console.WriteLine("Leap Year");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine("Not a Leap Year");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }
    }
}
