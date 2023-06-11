public class Activity
{
    private string _activity;
    private string _description;
    protected int _duration;

    public Activity(string act, string des)
    {
        _activity = act;
        _description = des;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity} activity.\r\n");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done!\r\n");
        Spin(1);
        Console.WriteLine($"You have completed another {_duration} seconds of {_activity} activity");
        Spin(2);
    }

    public void Spin(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b/");
            Thread.Sleep(500);
            Console.Write("\b-");
            Thread.Sleep(500);
            Console.Write("\b\\");
            Thread.Sleep(500);
            Console.Write("\b|");
            Thread.Sleep(500);
            Console.Write("\b-");
            Thread.Sleep(500);
            Console.Write("\b\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        
    }

    public void CountDown(int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write($"\b{length - i}");
            Thread.Sleep(1000);
        }
    }
}