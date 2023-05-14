using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal._entries = new List<string>();
        string menuChoice;
        do {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Clear");
            Console.WriteLine("6: Quit");
            menuChoice = Console.ReadLine();

            if (menuChoice == "1"){
                Entry entry = new Entry();
                string newEntry = entry.getEntry();
                journal._entries.Add(newEntry);
            }

            if (menuChoice == "2"){
                journal.Display();
            }

            if (menuChoice == "3"){
                journal.Load();
            }

            if (menuChoice == "4"){
                journal.Save();
            }

            if (menuChoice == "5"){ //Here I exceeded requirements by adding a method to clear the contents of a journ txt file to start fresh.
                journal.Clear();
            }

        } while (menuChoice != "6");

    }
}