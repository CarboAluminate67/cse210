public class Liquid : Engine
{
    private int _chamberPressure;

    public Liquid (string name, string fuel, int ispSea, int ispVac, int thrust, int chamber) : base(name, fuel, ispSea, ispVac, thrust)
    {
        _chamberPressure = chamber;
    }

    public int GetChamber()
    {
        return _chamberPressure;
    }

    public override string ToString()
    {
        return $"{base.ToString()}; {_chamberPressure}";
    }

    public override string LearnEngine(int num)
    {
        num = 5;
        string stat = base.LearnEngine(num);
        if (stat.Length == 1)
        {
            return $"Chamber Pressure: {_chamberPressure}";
        }
        return stat;
    }
}