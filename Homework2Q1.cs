using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please input a letter grade:");

        char grade = Console.ReadLine()[0];
        int GPA;

        if(grade == 'A')
            GPA = 4;
        else if (grade == 'B')
            GPA = 3;
        else if (grade == 'C')
            GPA = 2;
        else if (grade == 'D')
            GPA = 1;
        else if (grade == 'F')
            GPA = 0;
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
            return;
        }

        Console.WriteLine($"GPA point: {GPA}");
    }
}