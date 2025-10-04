using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        // Read JSON file 
        string jsonString = File.ReadAllText("scripture.json");
        JsonDocument doc = JsonDocument.Parse(jsonString);
        var scriptureElements = doc.RootElement.EnumerateArray();

        List<Scripture> scriptures = new List<Scripture>();

        // Here the program read more than one scriputre in the Json file
        foreach (var scp in scriptureElements)
        {
            string book = scp.GetProperty("book").GetString();
            int chapter = scp.GetProperty("chapter").GetInt32();
            int verse = scp.GetProperty("verse").GetInt32();
            string text = scp.GetProperty("text").GetString();

            int? endVerse = null;
            if (scp.TryGetProperty("endVerse", out var endVerseProp) &&
                endVerseProp.ValueKind == JsonValueKind.Number)
                endVerse = endVerseProp.GetInt32();

            Reference reference = new Reference(book, chapter, verse, endVerse);
            scriptures.Add(new Scripture(reference, text));
        }

        // I print all the scriptures to the user 
        Console.WriteLine("Select a scripture to memorize:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetDisplayText()}");
        }

        int choice;
        while (true)
        {   
            // User can choose, I set a "id" for each one
            Console.Write("Enter the number of the scripture: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= scriptures.Count)
                break;
            Console.WriteLine("Invalid choice. Try again.");
        }

        Scripture selectedScripture = scriptures[choice - 1];

        // Start interactive loop
        int enterCount = 0;
        Random random = new Random();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
           // Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            enterCount++;

            // After 4 enters, hide all words
            if (enterCount >= 4)
            {
                selectedScripture.HideAllWords();
                Console.Clear();
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending...");
                break;
            }

            // If already fully hidden, end program
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending...");
                break;
            }

            // Otherwise, hide a random number of words (2–4)
            int wordsToHide = random.Next(2, 5);
            selectedScripture.HideRandomWords(wordsToHide);
        }
    }
}
