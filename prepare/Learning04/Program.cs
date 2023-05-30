using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Alex Nielsen", "Programming with Classes");
        Console.WriteLine(assign1.getSummary());

        Math assign2 = new Math("Cece Champagne", "Fractions", "7.3", "10-13, 17-21");
        Console.WriteLine(assign2.getSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        Writing assign3 = new Writing("Ephraim Malasky", "U.S. History", "Growth of Agriculture");
        Console.WriteLine(assign3.getSummary());
        Console.WriteLine(assign3.GetWritingInfo());
    }
}