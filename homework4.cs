using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Q1:");
        Console.WriteLine("Enter your first number: ");
        int num1 = int(Console.ReadLine());
        Console.WriteLine("Enter your second number: ");
        int num2 = int(Console.ReadLine());
        int largestNumber = FindLargestNumber(num1, num2);
        Console.WriteLine($"The largest number between {num1} and {num2} is: {largestNumber}");

       
        Console.WriteLine("\nQ2:");
        PrintTriangle(5, "left");
        PrintTriangle(5, "right");
    }


    static int FindLargestNumber(int a, int b)
    {
        return (a > b) ? a : b;
    }
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N = {N}, Shape = {shape}");
        
        if (shape.ToLower() == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape.ToLower() == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = N; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid shape input. Please provide 'left' or 'right'.");
        }
    }
}
