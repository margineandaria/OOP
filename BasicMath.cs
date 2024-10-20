using System;

public static class BasicMath
{
    public static void PerformOperations()
    {
        Console.WriteLine("Enter two numbers:");
        Console.Write("First number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition: " + (num1 + num2));
        Console.WriteLine("Subtraction: " + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));
        Console.WriteLine("Division: " + (num1 / (double)num2));
    }
}
