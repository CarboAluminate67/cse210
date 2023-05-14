public class Entry
{
    public DateTime _date;
    public string _prompt;
    public string _response;
    public Entry()
    {
    }
    public string getDate()
    {
        DateTime currentDate = DateTime.Now;
        string date = currentDate.ToShortDateString();
        return date;
    }

    public string givePrompt()
    {
        PromptGenerator gen = new PromptGenerator();
        gen._prompts = new List<string>{
            "If you could change one thing about today what would it be?",
            "If you could do one thing differently today what would it be?",
            "What was the highlight of your day",
            "Did you do anything nice for anyone today? Did anyone do anything nice for you?",
            "What are you most looking forward to tommorrow?"
        };

        Random rand = new Random();
        return gen._prompts[rand.Next(5)];
    }

    public string getResponse()
    {
        string response = Console.ReadLine();
        return response;
    }

    public string getEntry()
    {
        string date = this.getDate();
        string prompt = this.givePrompt();
        Console.WriteLine(prompt);
        string response = this.getResponse();
        string entry = $"Date: {date} - Prompt: {prompt} |{response}";
        return entry;
    }
}