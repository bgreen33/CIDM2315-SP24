using System;

class Program
{
    static void Main()
    {
        Console.Write("Assign an int value to N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
