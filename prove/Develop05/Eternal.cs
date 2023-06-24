public class Eternal : Goal
{

    private int _timesCompleted;
    public Eternal(int pointVal, string name, string des, int completed) : base(pointVal, name, des)
    {
        _timesCompleted = completed;
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;
        return base.RecordEvent();
    }

    public int TimesCompleted()
    {
        return _timesCompleted;
    }

    public override string ToString()
    {
        return $"Eternal; {_name}; {_description}; {_pointValue}; {_timesCompleted}";
    }

    public override void WriteGoal(int counter, string complete)
    {
        base.WriteGoal(counter, complete);
        Console.Write($" -- Completed {_timesCompleted} times\r\n");
    }
}