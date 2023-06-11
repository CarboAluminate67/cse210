public class Listing : Activity
{
    private int _answers = 0;
    private string[] _prompts = { "When have you felt the Holy Ghosy recently?", "What are you grateful for?", "Who are your favorite people?", "What are you looking forward to in the future?"};

    private DateTime _startTime = new DateTime();
    private DateTime _endTime = new DateTime();
    public Listing(string act, string des) : base(act, des)
    {
    }

    private string GetPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Length)].ToString();
    }

    private void DisplayAnswer()
    {
        Console.WriteLine($"You listed {_answers} items!");
    }

    public void PerformListing()
    {
        StartMessage();
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {GetPrompt().ToString()} ---");
        Console.Write("Begin in: ");
        CountDown(5);
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
        while (true)
        {
            Console.WriteLine("");
            Console.Write(" > ");
            Console.ReadLine();
            _answers += 1;
            DateTime currentTime = DateTime.Now;
            if (currentTime > _endTime)
            {
                break;
            }
        }

        DisplayAnswer();

        EndMessage();
    }
}