using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "0";
        Journal journal = new Journal();
        PromptGenerator question = new PromptGenerator();

        while (response != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            response = Console.ReadLine();
            Console.Write("\n");

            if (response == "1")
            {
                journal.AddEntry();
            }
            else if (response == "2")
            {
                // I tried something creative by creating an advice feature. If the user is asked to rate their mood, the program will give them advice
                // based on the number they provide.
                journal.DisplayAll();
            }
            else if (response == "3")
            {
                // I am loading data from a JSON file
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (response == "4")
            {
                // I am saving data in JSON format
                Console.Write("Enter filename to save (e.g., journal.json): ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);

            }
            else if (response == "5")
            {
                Console.WriteLine("Take Care!");
            }
            else
            {
                Console.WriteLine("Try Again!");
            }
          
        }

    }
}