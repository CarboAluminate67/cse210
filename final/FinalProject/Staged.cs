public class Staged : Liquid 
{
    private string _type;

public Staged(string name, string fuel, int ispSea, int ispVac, int thrust, int chamber, string type) : base(name, fuel, ispSea, ispVac, thrust, chamber)
    {
        _type = type;
    }

    public override string ToString()
    {
        return $"{_type}; {base.ToString()}";
    }
    public override void WriteEngine()
    {
        base.WriteEngine();
        Console.Write($"{_type} Staged Combustion");
    }

    public override string LearnEngine(int num)
    {
        num = 6;
        string stat = base.LearnEngine(num);
        if (stat.Length == 1)
        {
            return $"Staged Combustion Type: {_type}";
        }
        return stat;
    }
}