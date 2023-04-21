using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letter;

        Console.Write("What grade did you receive? ");
        grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else 
        {
            Console.WriteLine("You did not pass the class.");
        }
    }
}