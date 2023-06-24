using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        while (true)
        {
            menu.StartMenu();
            string option = Console.ReadLine();
            if (option == "1")
            {
                Goal goal = menu.CreateGoal();
                menu.AddGoal(goal);
            }

            if (option == "2")
            {
                menu.ListGoals();
                Console.ReadLine();
            }

            if (option == "3")
            {
                menu.Save();
            }

            if (option == "4")
            {
                menu.Load();
            }

            if (option == "5")
            {
                menu.ListGoals();
                Console.Write($"\r\nWhich goal did you accomplish? ");
                string choice = Console.ReadLine();

                int points = menu.GetGoals()[int.Parse(choice) - 1].RecordEvent();
                menu.AddPoints(points);
            }

            if (option == "6")
            {
                break;
            }
        }
    }
}