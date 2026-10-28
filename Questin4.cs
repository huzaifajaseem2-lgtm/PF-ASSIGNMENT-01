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

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine("Result: " + (num1 / num2));
                else
                    Console.WriteLine("Error: Cannot divide by zero.");
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
