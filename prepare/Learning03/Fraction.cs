public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int wholeNum)
    {
        _numerator = wholeNum;
        _denominator = 1;
    }
    public Fraction(int num, int den)
    {
        _numerator = num;
        _denominator = den;
    }

    public int getNum()
    {
        return _numerator;
    }
    public void setNum(int newNum)
    {
        _numerator = newNum;
    }
    public int getDen()
    {
        return _denominator;
    }
    public void setDen(int newDen)
    {
        _denominator = newDen;
    }

    public double getDecimal()
    {
        return Convert.ToDouble(_numerator) / Convert.ToDouble(_denominator);
    }
    public string getString()
    {
        return $"{_numerator}/{_denominator}";
    }
}