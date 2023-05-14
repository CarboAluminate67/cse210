public class PromptGenerator
{
    public List<string> _prompts; 
    public PromptGenerator()
    {
    }

    public string generate()
    {
        Random rand = new Random();
        return _prompts[rand.Next(5)];
    }
}