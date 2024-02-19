using System;

class Program
{
    static void Main()
    {
        int resultQ1 = FindLargestNumber();
        Console.WriteLine($"The largest number is: {resultQ1}");

        int resultQ2 = FindLargestNumberFromFour();
        Console.WriteLine($"The largest number is: {resultQ2}");

        createAccount();
    }

    static int FindLargestNumber()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        return num1 > num2 ? num1 : num2;
    }

    static int FindLargestNumberFromFour()
    {
        int max1 = FindLargestNumber();
        int max2 = FindLargestNumber();

        return max1 > max2 ? max1 : max2;
    }

    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password1 = Console.ReadLine();

        Console.Write("Enter password again: ");
        string password2 = Console.ReadLine();

        Console.Write("Enter birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account created.");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Unable to create an account");
        }
    }
}
