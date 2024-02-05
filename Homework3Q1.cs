using System;

class Program
{
    static void Main()
    {
        Console.Write("Input an interger: ");
        int N = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i <= N / 2; i++)
        {
            if (N % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine($"{N} is prime.");
        else
            Console.WriteLine($"{N} is non-prime.");
    }
}
