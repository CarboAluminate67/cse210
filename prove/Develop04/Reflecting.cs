public class Reflecting : Activity
{
    private string[] _prompts = { "Think of a time you did something difficult.", "Think of something you wish you hadn't done.", "Think of a fun experience you had with family or friends." };
    private string[] _questions = { "How did you feel when it was complete?", "What was your favorite part of the experience?", "Is there anything you wish you would have done differently?", "Do you want to go through the experience again in the future?" };
    public Reflecting(string act, string des) : base(act, des)
    {
    }

    private string GetPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)].ToString();
        return prompt;
    }
    private string GetQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Length)].ToString();
    }

    public void PerformReflection()
    {
        StartMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...\r\n");
        Spin(1);
        Console.WriteLine("Consider the following prompt: \r\n");
        Console.WriteLine($" --- {GetPrompt().ToString()} ---\r\n");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        Console.WriteLine("\r\nNow ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine($"Begin in: ");
        CountDown(5);

        Console.Clear();
        for (int i = 0; i < _duration; i += 15)
        {
            Console.Write($" > {GetQuestion().ToString()}");
            Spin(3);
            Console.WriteLine("\r\n");
            if (i > 60)
            {
                Console.WriteLine("You have pondered all questions!");
                _duration = 60;
                break;
            }
        }

        EndMessage();
    }
}