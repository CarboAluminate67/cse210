using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        Breathing breathing = new Breathing("breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Reflecting reflecting = new Reflecting("reflecting", "This activity will help you reflect on experiences you have had in your life, and how to improve future experiences that you will have.");

        Listing listing = new Listing("listing", "This activity will help you reflect on good things in your life by having you list things in a specific area.");
        while (true)
        {
            menu.StartMenu();
            if (menu.Choice() == "1")
            {
                breathing.PerformBreath();
            }
            
            if (menu.Choice() == "2")
            {
                reflecting.PerformReflection();
            }

            if (menu.Choice() == "3")
            {
                listing.PerformListing();
            }

            if (menu.Choice() == "4")
            {
                break;
            }
        }


    }
}