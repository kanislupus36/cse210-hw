//For exceeding the requirements I added in a gratitude feature to be saved in each entry.

using System;

class Program
{
    public static Journal theJournal = new Journal();
    public static PromptGenerator promptGenerator = new PromptGenerator();

    static void Main(string[] args)
    {
        bool quit = false;

        //loop with menu to choose
        while (!quit)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? (1-5): ");

            string choice = Console.ReadLine();
            Console.WriteLine();
            string fileName;

            switch (choice)
            {
                case "1":
                    string randomPrompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(randomPrompt);
                    Console.Write("Your response: ");
                    string userResponse = Console.ReadLine();
                    Console.WriteLine("What are you grateful for today? ");
                    string gratitude = Console.ReadLine();

                    Entry newEntry = new Entry(DateTime.Now.ToString(), randomPrompt, userResponse, gratitude);
                    theJournal.AddEntry(newEntry);
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter a file name to load the journal from: ");
                    fileName = Console.ReadLine();

                    theJournal.LoadFromFile(fileName);
                    break;
                case "4":
                    Console.Write("Enter a file name to save the journal (e.g., journal.txt): ");
                    fileName = Console.ReadLine();

                    theJournal.SaveToFile(fileName);
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }


}
