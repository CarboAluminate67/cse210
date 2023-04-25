using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != num)
        {
            if (guess < num)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Congrats! You guessed it!");
    }
}
