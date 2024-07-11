using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        bool exitRequested = false;
        while (!exitRequested)
        {
            Console.WriteLine("\n--- Goal Tracker Menu ---");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine().Trim();

            switch (input)
            {
                case "1":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "2":
                    goalManager.ListGoalDetails();
                    break;
                case "3":
                    goalManager.CreateGoal();
                    break;
                case "4":
                    goalManager.RecordEvent();
                    break;
                case "5":
                    goalManager.SaveGoals();
                    break;
                case "6":
                    goalManager.LoadGoals();
                    break;
                case "7":
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select again.");
                    break;
            }
        }

        Console.WriteLine("Exiting...");
    }
}