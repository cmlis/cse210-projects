using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text.Json;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();


    public void AddEntry()
    {
        // Console.Write("<Log> Journal - AddEntry top");

  
        PromptGenerator question = new PromptGenerator();
        string prompt = question.GetRandomPrompt();
     
        Console.WriteLine($"{prompt}");
        string answer = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        //Entry entry = new Entry();
        // entry._date = dateText;
        // entry._question = prompt;
        // entry._answer = answer;

        Entry entry = new Entry
        {
        Date = dateText,
        Advice = "",
        Question = prompt,
        Answer = answer,
        };

        _entries.Add(entry);

    }

    public void DisplayAll()
    {
        //Console.WriteLine("<Log> Journal - DisplayAll");
        foreach (Entry entry in _entries)
        {


            if (entry.Answer == "1" || entry.Answer == "2" || entry.Answer == "3" ||
                entry.Answer == "4" || entry.Answer == "5" || entry.Answer == "6" ||
                entry.Answer == "7" || entry.Answer == "8" || entry.Answer == "9" ||
                 entry.Answer == "10")
            {

                entry.Advice = GetMoodAdvice(int.Parse(entry.Answer));

            }  
            
             entry.Display();
        }

    }
    
    public void SaveToFile(String fileName)
    {

        // I am saving  my journal as json format by convert the list of journal _entries into a JSON String
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        // Here I save the JSON String into the filename specified by the user
        File.WriteAllText(fileName, json);

        //Console.WriteLine(json);
        Console.WriteLine("Journal saved successfully!");

    }

    public void LoadFromFile(String fileName)
    {
        // I first check if the file exists
        if (File.Exists(fileName))
        {
            // Read all the content of the file into a string 
            string json = File.ReadAllText(fileName);

            try
            {

                // Convert the JSON string back into a List of Entry objects
                _entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();
                Console.WriteLine("Journal loaded successfully!");
            }
            catch (Exception ex)
            {
                // If something goes wrong during deserialization, show the error message
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }


    } public string GetMoodAdvice(int level)
    {
        switch (level)
        {
            case 1: return "Feeling rough? Take a hug break and call someone you trust.";
            case 2: return "Down today? Vent a little to a friend or loved one.";
            case 3: return "Not great? Treat yourself kindly, even a small chocolate helps.";
            case 4: return "Meh day? Take a short walk or do something cozy.";
            case 5: return "Okay-ish? A little dance or smile could lift you up.";
            case 6: return "Feeling better? Keep the good vibes going!.";
            case 7: return "Good mood! Share it with someone, they will love it!";
            case 8: return "Great! Maybe reward yourself. You deserve it";
            case 9: return "Awesome! Celebrate a little, you earned it.";
            case 10: return "Amazing! Spread your joy and enjoy the day!";
            default: return "Invalid mood level.";
        }
    
    }    

}