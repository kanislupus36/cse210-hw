// I added in a library of scriptures for it to randomly choose and display

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        AddScripturesToLibrary(library);

        Random random = new Random();

        while (!library.AllScripturesHidden())
        {
            Scripture currentScripture = library.GetRandomScripture();

            while (currentScripture != null && !currentScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("Scripture:");
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    return;
                }
                else if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "enter")
                {
                    int wordsToHide = random.Next(1, 3);
                    currentScripture.HideRandomWords(wordsToHide);
                }
                else
                {
                    Console.WriteLine("Invalid input. Press Enter to hide words or type 'quit' to exit.");
                }
            }
        }

        Console.WriteLine("\nAll scriptures are completely hidden. Program ended.");
    }

    static void AddScripturesToLibrary(ScriptureLibrary library)
    {
        Reference ref1 = new Reference("John", 3, 16);
        string text1 = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture1 = new Scripture(ref1, text1);
        library.AddScripture(scripture1);

        Reference ref2 = new Reference("Psalm", 23, 1);
        string text2 = "The Lord is my shepherd; I shall not want.";
        Scripture scripture2 = new Scripture(ref2, text2);
        library.AddScripture(scripture2);

        Reference ref3 = new Reference("Proverbs", 3, 5, 6);
        string text3 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowldege him, and he shall direct thy paths.";
        Scripture scripture3 = new Scripture(ref3, text3);
        library.AddScripture(scripture3);
    }
}
