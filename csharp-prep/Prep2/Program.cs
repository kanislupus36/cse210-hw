using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        double grade = double.Parse(percent);
        char letter = ' ';

        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = 'B';
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = 'C';
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"Your grade is a {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass, you can do it next time!");
        }


    }
}