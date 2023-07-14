public class Hypergolic : Liquid
{
    private int _burnTime;

    public Hypergolic(string name, string fuel, int ispSea, int ispVac, int thrust, int chamber, int burnTime) : base(name, fuel, ispSea, ispVac, thrust, chamber)
    {
        _burnTime = burnTime;
    }

    public override string ToString()
    {
        return $"Hypergolic; {base.ToString()}; {_burnTime}";
    }
    public override void WriteEngine()
    {
        base.WriteEngine();
        Console.Write("Hypergolic");
    }

    public override string LearnEngine(int num)
    {
        num = 6;
        string stat = base.LearnEngine(num);
        if (stat.Length == 1)
        {
            return $"Burn Time: {_burnTime}";
        }
        return stat;
    }
}