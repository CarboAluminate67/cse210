using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string user, int result)
    {
        Console.WriteLine($"{user}, the square of your number is {result}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user = PromptUserName();
        int num = PromptUserNumber();
        int result = SquareNumber(num);
        DisplayResult(user, result);
    }
}