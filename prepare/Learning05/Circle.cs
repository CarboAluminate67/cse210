public class Circle : Shape
{
    private double _radius;

    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * (_radius * _radius);
    }

}