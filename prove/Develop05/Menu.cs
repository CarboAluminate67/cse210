public class Menu
{
    private string _fileName;
    private int _points = 0;
    private List<Goal> _goals = new List<Goal>();

    public Menu()
    {
    }

    public string File()
    {
        return _fileName;
    }

    public void StartMenu()
    {
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine("");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
    }
        public int GetPoints()
    {
        return _points;
    }
}