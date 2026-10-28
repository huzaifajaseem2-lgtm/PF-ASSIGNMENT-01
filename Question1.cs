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

        Console.Write("Enter day number (1-7): ");
        if (int.TryParse(Console.ReadLine(), out int day))
        {
            if (day == 1)
                Console.WriteLine("Monday");
            else if (day == 2)
                Console.WriteLine("Tuesday");
            else if (day == 3)
                Console.WriteLine("Wednesday");
            else if (day == 4)
                Console.WriteLine("Thursday");
            else if (day == 5)
                Console.WriteLine("Friday");
            else if (day == 6)
                Console.WriteLine("Saturday");
            else if (day == 7)
                Console.WriteLine("Sunday");
            else
                Console.WriteLine("Invalid number");
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}
