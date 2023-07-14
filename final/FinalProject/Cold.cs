public class Cold : Engine
{
    private string _use;

    public Cold(string name, string fuel, int ispSea, int ispVac, int thrust, string usage) : base(name, fuel, ispSea, ispVac, thrust)
    {
        _use = usage;
    }

    public override string ToString()
    {
        return $"Cold; {base.ToString()}; {_use}";
    }
    public override void WriteEngine()
    {
        base.WriteEngine();
        Console.Write("Cold Gas Thruster");
    }

    public override string LearnEngine(int num)
    {
        num = 5;
        string stat = base.LearnEngine(num);
        if (stat.Length == 1)
        {
            return $"Used On: {_use}";
        }
        return stat;
    }
}