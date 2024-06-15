using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int numSquare = SquareNumber(num);
        DisplayResult(name, numSquare);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int num)
    {
        int numSquare = num * num;
        return numSquare;
    }

    static void DisplayResult(string name, int num)
    {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
}