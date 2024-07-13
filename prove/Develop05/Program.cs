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
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("\n--- Goal Tracker Menu ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine().Trim();

            switch (input)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalDetails();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select again.");
                    break;
            }
        }

    }
}