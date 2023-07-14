public class Solid : Engine
{
    private int _burnTime;
    public Solid(string name, string fuel, int ispSea, int ispVac, int thrust, int burnTime) : base(name, fuel, ispSea, ispVac, thrust)
    {
        _burnTime = burnTime;
    }

    public override string ToString()
    {
        return $"SRB; {base.ToString()}; {_burnTime}";
    }
    public override void WriteEngine()
    {
        base.WriteEngine();
        Console.Write("SRB");
    }
    
    public override string LearnEngine(int num)
    {
        num = 5;
        string stat = base.LearnEngine(num);
        if (stat.Length == 1)
        {
            return $"Burn Time: {_burnTime}";
        }
        return stat;
    }
}