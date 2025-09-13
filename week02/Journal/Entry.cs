
public class Entry
{
    // public string _date;
    // public string _question;
    // public string _answer;

    // I've learned that for JSON to work, the attributes need to be serializable. I do that by adding the gets and sets
    public string Date { get; set; }
    public string Advice { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }


   public void Display()
    {

        Console.Write($"Date {Date} ");
        Console.WriteLine($"- Prompt: {Question}");
        Console.WriteLine($"{Answer}");
        Console.WriteLine($"{Advice}");
    }


}