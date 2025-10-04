using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Activities Menu ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathing.Run();
                    break;
                case "2":
                // I tried to get the 100 points by creating another list of prompts to check if it had already been asked.  
                // So, I made sure to use the RemoveAt() method to remove the question from the list.
                    reflection.Run();
                    break;
                case "3":
                    listing.Run();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
