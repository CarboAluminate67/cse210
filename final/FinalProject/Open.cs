public class Open : Liquid
{
    public Open(string name, string fuel, int ispSea, int ispVac, int thrust, int chamber) : base(name, fuel, ispSea, ispVac, thrust, chamber)
    {}

    public override string ToString()
    {
        return $"Open; {base.ToString()}";
    }
    public override void WriteEngine()
    {
        base.WriteEngine();
        Console.Write("Open Cycle");
    }
}