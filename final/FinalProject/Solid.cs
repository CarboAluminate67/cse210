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
}