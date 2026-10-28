using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Class ID: YOUR CLASS ID | Registration ID: YOUR REG ID | Name: YOUR NAME | Submission Date: 27-10-2026");

        Console.Write("Enter purchase amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double discount = 0;
        double percentage = 0;

        if (amount >= 5000)
        {
            percentage = 20;
        }
        else if (amount >= 2000)
        {
            percentage = 10;
        }

        discount = amount * percentage / 100;
        double payable = amount - discount;

        Console.WriteLine("Discount Percentage: " + percentage + "%");
        Console.WriteLine("Discount Amount: Rs. " + discount);
        Console.WriteLine("Final Payable Amount: Rs. " + payable);
    }
}
