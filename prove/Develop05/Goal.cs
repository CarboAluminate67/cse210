public abstract class Goal
{
    private bool _completeStatus = false;
    private int _pointValue;
    private string _name;
    private string _description;

    public Goal(int pointVal, string name, string des)
    {
        _pointValue = pointVal;
        _name = name;
        _description = des;
    }

    
}