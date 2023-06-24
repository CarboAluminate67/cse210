using System.IO;

public class Menu
{
    private string _fileName;
    private int _points = 0;
    private List<Goal> _goals = new List<Goal>();

    public Menu()
    {
    }

    public void StartMenu()
    {
        Console.Clear();
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine("");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine($" 6. Quit\r\n");
    }
    public int GetPoints()
    {
        return _points;
    }

    public Goal CreateGoal()
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

        if (type == "1")
        {
            return new Simple(points, name, des, false);
        }
        else if (type == "2")
        {
            return new Eternal(points, name, des, 0);
        }
        else
        {
            Console.Write("How many times should this goal be completed in total? ");
            int needed = int.Parse(Console.ReadLine());

            Console.Write($"\r\nWhat is the bonus for completing this goal {needed} times? ");
            int bonus = int.Parse(Console.ReadLine());

            return new Checklist(points, name, des, bonus, 0, needed, false);
        }
        
    }
    public void Save()
    {
        Console.Write("Filename: ");
        _fileName = Console.ReadLine();

        File.WriteAllText($"./{_fileName}", String.Empty);
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(_points);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.ToString());
            }
        }
    }

    private void LoadGoal(string[] parts)
    {
        if (parts[0] == "Simple")
        {
            _goals.Add(new Simple(int.Parse(parts[3]), parts[1], parts[2], bool.Parse(parts[4])));
        }

        else if (parts[0] == "Eternal")
        {
            _goals.Add(new Eternal(int.Parse(parts[3]), parts[1], parts[2], int.Parse(parts[4])));
        }

        else
        {
            _goals.Add(new Checklist(int.Parse(parts[3]), parts[1], parts[2], int.Parse(parts[4]), int.Parse(parts[6]), int.Parse(parts[7]), bool.Parse(parts[5])));
        }
    }
    
    public void Load()
    {
        _goals.Clear();
        Console.Write("Filename: ");
        _fileName = Console.ReadLine();

        List<string> lines = new List<string>(File.ReadAllLines(_fileName));
        _points = int.Parse(lines[0]);
        lines.RemoveAt(0);

        foreach (string line in lines)
        {
            string[] parts = line.Split("; ");
            LoadGoal(parts);
        }
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void ListGoals()
    {
        Console.WriteLine("The Goals Are: ");
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            counter += 1;
            string complete = " ";
            if (goal.IsComplete() == true)
            {
                complete = "X";
            }
            goal.WriteGoal(counter, complete);
        }
    }

    public void AddPoints(int points)
    {
        _points += points;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
}