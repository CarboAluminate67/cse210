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
}