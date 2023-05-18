using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Console.WriteLine(one.getDecimal());
        Console.WriteLine(one.getString());

        Fraction five = new Fraction(5);
        Console.WriteLine(five.getDecimal());
        Console.WriteLine(five.getString());

        Fraction fiveOverThree = new Fraction(5, 3);
        Console.WriteLine(fiveOverThree.getDecimal());
        Console.WriteLine(fiveOverThree.getString());
        fiveOverThree.setDen(7);
        Console.WriteLine(fiveOverThree.getString());
    }
}