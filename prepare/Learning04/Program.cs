using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Assignment m = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(m.GetSummary());

        MathAssignment n = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "8-19");
        Console.WriteLine(n.GetSummary());
        Console.WriteLine(n.GetHomeworkList());

        WritingAssignment l = new WritingAssignment("Mary Waters", "European History", "The Causes of World War 2 ");
        Console.WriteLine(l.GetSummary());
        Console.WriteLine(l.GetWritingInformation());
    }
}