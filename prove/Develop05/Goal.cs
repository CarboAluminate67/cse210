public abstract class Goal
{
    protected int _pointValue;
    protected string _name;
    protected string _description;
    public Goal(int pointVal, string name, string des)
    {
        _pointValue = pointVal;
        _name = name;
        _description = des;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual int RecordEvent()
    {
        return _pointValue;
    }

    public int GetPoints()
    {
        return _pointValue;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDes()
    {
        return _description;
    }

    public new abstract string ToString();

    public virtual void WriteGoal(int counter, string complete)
    {
        Console.Write($"{counter}. [{complete}] {_name} ({_description})");
    }
    
}