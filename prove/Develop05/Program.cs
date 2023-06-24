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
                menu.ListGoals(); //Included counter for number of times Eternal goals have been completed
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

                int points = menu.GetGoals()[int.Parse(choice) - 1].RecordEvent(); //Added code in RecordEvent override methods to prevent extra points received from finishing simple and checklist goals more than allowed
                menu.AddPoints(points); 
            }

            if (option == "6")
            {
                break;
            }
        }
    }
}