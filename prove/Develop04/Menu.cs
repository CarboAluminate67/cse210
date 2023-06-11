public class Menu
{
    private string _choice;

    public Menu()
    {
        _choice = "";
    }

    public void StartMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the menu: ");
        _choice = Console.ReadLine();
    }

    public string Choice()
    {
        return _choice;
    }
}