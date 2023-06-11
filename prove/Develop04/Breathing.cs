public class Breathing : Activity
{
    public Breathing(string act, string des) : base(act, des)
    {
    }

    private void Breath(int length)
    {
        Console.WriteLine("\r\nBreath in...");
        Console.Write("Now breath out...");
        CountDown(length);
        Console.Write("\b \r\n");
    }

    public void PerformBreath()
    {
        StartMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...\r\n");
        Spin(1);
        for (int i = 0; i < _duration; i += 5)
        {
            Breath(5);
        }
        EndMessage();
    }
}