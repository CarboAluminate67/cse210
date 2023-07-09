using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        while (true)
        {
            int response = menu.StartMenu();
            switch(response)
            {
                case 1:
                    menu.AddEngine();
                    break;
                case 2:
                    menu.RemoveEngine();
                    break;
                case 3: 
                    menu.ListEngines();
                    break;
                case 4:
                    menu.Save();
                    break;
                case 5:
                    menu.Load();
                    break;
            }
            if (response == 6)
            {
                break;
            }
        }
    }
}
