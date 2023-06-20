public class Goal
{
    private int _pointValue;
    private string _name;
    private string _description;
    private bool _completionStatus;
    private int _timesCompleted;
    public Goal(int pointVal, string name, string des)
    {
        _pointValue = pointVal;
        _name = name;
        _description = des;
        _completionStatus = false;
        _timesCompleted = 0;
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

    public virtual void CreateGoal()
    {
        Console.WriteLine("The Types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");

        Console.Write("Which type of Goal would you like to create? ");
        string type = Console.ReadLine();
        
        Console.Write($"\r\nWhat is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write($"\r\nWrite a short description: ");
        string des = Console.ReadLine();

        Console.Write($"\r\nHow many points is this goal worth? ");
        int points  = int.Parse(Console.ReadLine());

    }
    
}