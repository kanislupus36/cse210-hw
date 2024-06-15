using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = -1;
        List<int> numList = new List<int>();

        while (num != 0)
        {
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numList.Add(num);
            }
        }

        int sum = 0;
        foreach (int number in numList)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        double avg = ((double)sum) / numList.Count();
        Console.WriteLine($"The average is {avg}");

        int max = 0;
        foreach (int number in numList)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");
    }
}