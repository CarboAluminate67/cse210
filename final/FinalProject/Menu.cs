using System.IO;
using System;

public class Menu
{
    private List<Engine> _engines = new List<Engine>();
    public Menu()
    {
    }

    public List<Engine> GetEngines()
    {
        return _engines;
    }

    public int StartMenu()
    {
        Console.Clear();
        Console.WriteLine($"\r\nWelcome to the interactive Rocket Engine Catalogue!");
        Console.WriteLine($"What action would you like to perform? \r\n");
        Console.WriteLine("  1. Add Engine");
        Console.WriteLine("  2. Remove Engine");
        Console.WriteLine("  3. List Engines");
        Console.WriteLine("  4. Save");
        Console.WriteLine("  5. Load");
        Console.WriteLine($"  6. Quit \r\n");

        return int.Parse(Console.ReadLine());
    }

    public void AddEngine()
    {
        Console.Write($"\r\nWhat type of engine would you like to add? SRB(S), Cold Gas(C), Open Cycle(O), Oxygen-Rich(OR), Fuel-Rich(FR), Full Flow(F), or Hypergolic(H)? ");
        string type = Console.ReadLine().ToUpper();

        Console.Write($"\r\nWhat is the name of the engine? ");
        string name = Console.ReadLine();

        Console.Write($"\r\nWhat fuel does the engine use? ");
        string fuel = Console.ReadLine();

        Console.Write($"\r\nWhat is the engine's sea level efficiency? ");
        int ispSea = int.Parse(Console.ReadLine());

        Console.Write($"\r\nWhat is the engine's vacuum efficiency? ");
        int ispVac = int.Parse(Console.ReadLine());

        Console.Write($"\r\nWhat is the engine's thrust (sea level, in N)? ");
        int thrust = int.Parse(Console.ReadLine());

        int burnTime;

        switch(type)
        {
            case "C":
                Console.Write($"\r\nWhat is this Cold Gas thruster used in? ");
                string use = Console.ReadLine();
                _engines.Add(new Cold(name, fuel, ispSea, ispVac, thrust, use));
                break;
            case "S":
                Console.Write($"\r\nWhat is the burn time of this SRB (s)? ");
                burnTime = int.Parse(Console.ReadLine());
                _engines.Add(new Solid(name, fuel, ispSea, ispVac, thrust, burnTime));
                break;
            case "O": case "OR": case "FR": case "F": case "H":
                Console.Write($"\r\nWhat is the engine's chamber pressure (bar)? ");
                int pressure = int.Parse(Console.ReadLine());
                if (type == "O")
                {
                    _engines.Add(new Open(name, fuel, ispSea, ispVac, thrust, pressure));
                }
                else if (type == "OR")
                {
                    _engines.Add(new Staged(name, fuel, ispSea, ispVac, thrust, pressure, "Oxygen-Rich"));
                }
                else if (type == "FR")
                {
                    _engines.Add(new Staged(name, fuel, ispSea, ispVac, thrust, pressure, "Fuel-Rich"));
                }
                else if (type == "F")
                {
                    _engines.Add(new Staged(name, fuel, ispSea, ispVac, thrust, pressure, "Full-Flow"));
                }
                else
                {
                    Console.Write($"\r\nWhat is the burn time this engine is capable of (s)? ");
                    burnTime = int.Parse(Console.ReadLine());
                    _engines.Add(new Hypergolic(name, fuel, ispSea, ispVac, thrust, pressure, burnTime));
                }
                break;
            default:
                Console.WriteLine("Invalid engine type entered");
                Thread.Sleep(3000);
                StartMenu();
                break;
        }
    }
    public void RemoveEngine()
    {
        Console.Write($"\r\nName of the engine you would like to remove: ");
        string rmName = Console.ReadLine();
        int rmIndex = _engines.FindIndex(engine => engine.GetName().ToLower() == rmName.ToLower());
        try
        {
            _engines.RemoveAt(rmIndex);
            Console.WriteLine("Engine Removed!");
            Thread.Sleep(3000);
        } 
        catch
        {
            Console.WriteLine("Engine does not exist :/");
        }
    }
    public void ListEngines()
    {
        foreach (Engine engine in _engines)
        {
            engine.WriteEngine();
            Console.WriteLine("");
        }
        Console.Write("Press enter to continue.");
        Console.ReadLine();
    }

    public void Save()
    {
        Console.Write("Filename: ");
        string _fileName = Console.ReadLine();
        File.WriteAllText($"./{_fileName}", String.Empty);
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Engine engine in _engines)
            {
                outputFile.WriteLine(engine.ToString());
            }
        }

    }

    public void Load()
    {
        _engines.Clear();
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();
        List<string> engineLines = new List<string>(File.ReadAllLines(fileName));
        foreach (string line in engineLines)
        {
            string[] parts = line.Split("; ");
            switch (parts[0])
            {
                case "SRB":
                    _engines.Add(new Solid(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    break;
                case "Cold":
                    _engines.Add(new Cold(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), parts[6]));
                    break;
                case "Open":
                    _engines.Add(new Open(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    break;
                case "Fuel-Rich": case "Oxygen-Rich": case "Full-Flow":
                    _engines.Add(new Staged(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), parts[0]));
                    break;
                case "Hypergolic":
                    _engines.Add(new Hypergolic(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                    break;
            }
        }
    }
}