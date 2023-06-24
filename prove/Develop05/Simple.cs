public class Simple : Goal
{
    private bool _completionStatus;

    public Simple(int pointVal, string name, string des, bool completion) : base(pointVal, name, des)
    {
        _completionStatus = completion;
    }

    public override int RecordEvent()
    {
        if (_completionStatus == false)
        {
            _completionStatus = true;
            return base.RecordEvent();
        }
        else
        {
            return 0;
        }
        
    }

    public override bool IsComplete()
    {
        return _completionStatus;
    }

    public override string ToString()
    {
        return $"Simple; {_name}; {_description};  {_pointValue}; {_completionStatus}";
    }

    public override void WriteGoal(int counter, string complete)
    {
        base.WriteGoal(counter, complete);
        Console.WriteLine("");
    }
}