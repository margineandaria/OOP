using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // User input for the first number
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // User input for the second number
            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Display options for operations
            Console.WriteLine("Choose the operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            // Perform the chosen operation
            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine($"The result of addition is: {result}");
                    break;
                case 2:
                    result = number1 - number2;
                    Console.WriteLine($"The result of subtraction is: {result}");
                    break;
                case 3:
                    result = number1 * number2;
                    Console.WriteLine($"The result of multiplication is: {result}");
                    break;
                case 4:
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                        Console.WriteLine($"The result of division is: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    validOperation = false;
                    break;
            }

            // Check if the result is positive, negative, or zero
            if (validOperation)
            {
                if (result > 0)
                {
                    Console.WriteLine("The result is positive.");
                }
                else if (result < 0)
                {
                    Console.WriteLine("The result is negative.");
                }
                else
                {
                    Console.WriteLine("The result is zero.");
                }
            }
        }
    }
}
