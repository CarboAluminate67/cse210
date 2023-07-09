public class Engine
{
    private string _name;
    private string _fuel;
    private int _ispSea;
    private int _ispVac;
    private int _thrust;

    public Engine (string name, string fuel, int ispSea, int ispVac, int thrust)
    {
        _name = name;
        _fuel = fuel;
        _ispSea = ispSea;
        _ispVac = ispVac;
        _thrust = thrust;
    }

    public new virtual string ToString()
    {
        return $"{_name}; {_fuel}; {_ispSea}; {_ispVac}; {_thrust}";
    }

    public string GetName()
    {
        return _name;
    }
    public string GetFuel()
    {
        return _fuel;
    }
    public string GetEfficiency()
    {
        return $"{_ispSea}; {_ispVac}";
    }
    public int GetThrust()
    {
        return _thrust;
    }

    public virtual void WriteEngine()
    {
        Console.Write($"{_name}: ");
    }

}