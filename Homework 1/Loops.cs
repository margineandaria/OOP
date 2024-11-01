using System;

public static class Loops
{
    public static void DemonstrateLoops()
    {
        // For loop
        Console.WriteLine("For loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        // While loop
        Console.WriteLine("\nWhile loop:");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("j = " + j);
            j++;
        }

        // Do-while loop
        Console.WriteLine("\nDo-while loop:");
        int k = 0;
        do
        {
            Console.WriteLine("k = " + k);
            k++;
        }
        while (k < 5);
    }
}
