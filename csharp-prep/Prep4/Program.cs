using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Please add a number (enter 0 when finished):");
        int new_num = int.Parse(Console.ReadLine());

        while (new_num != 0)
        {
            numbers.Add(new_num);
            Console.WriteLine("Please add a number (enter 0 when finished):");
            new_num = int.Parse(Console.ReadLine());
        }

        float sum = 0;
        int large = 0;

        foreach (int num in numbers)
        {
            sum = sum + num;
            if (num > large)
            {
                large = num;
            }
        }

        float average = sum / numbers.Count;

        Console.WriteLine($"The total is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine(numbers.Count);
        Console.WriteLine($"The largest number is {large}");
    }
}