public class Checklist : Goal
{
    private int _timesNeeded;
    private int _bonus;
    private int _timesCompleted;
    private bool _completionStatus;

    public Checklist(int pointVal, string name, string des, int bonus, int completed, int need, bool completion) : base(pointVal, name, des)
    {
        _timesNeeded = need;
        _timesCompleted = completed;
        _bonus = bonus;
        _timesCompleted = 0;
        _completionStatus = completion;
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;
        if (_timesCompleted >= _timesNeeded)
        {
            if (_timesCompleted == _timesNeeded)
            {
                _completionStatus = true;
                return _bonus;
            }
            return 0;
        }
        return base.RecordEvent();
    }

    public override string ToString()
    {
        return $"Checklist; {_name}; {_description}; {_pointValue}; {_bonus}; {_completionStatus}; {_timesCompleted}; {_timesNeeded}";
    }

    public override bool IsComplete()
    {
        {
            return _completionStatus;
        }
    }

    public override void WriteGoal(int counter, string complete)
    {
        base.WriteGoal(counter, complete);
        Console.Write($" -- Currently Completed {_timesCompleted}/{_timesNeeded}\r\n");
    }
}