public class PromptGenerator{

    public List<string> _prompts = new List<string>{

        "On a scale of 1 to 10, how is your mood today?",
        "What is one thing I am grateful for today, and why?",
        "What challenge did I face today, and how did I respond to it?",
        "What is something I learned about myself today?",
        "What emotions did I feel the most today, and what triggered them?",
        "What is one small step I can take tomorrow to move closer to my goals?"

    };

    public string GetRandomPrompt(){

        Random randonNum = new Random();
        int index = randonNum.Next(_prompts.Count);
        return _prompts[index];
    }
}