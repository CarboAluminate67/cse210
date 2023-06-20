public class Checklist : Goal
{
    private int _timesNeeded;
    private int _bonus;

    public Checklist(int pointVal, string name, string des, int bonus, int times) : base(pointVal, name, des)
    {
        _timesNeeded = times;
        _bonus = bonus;
    }
}