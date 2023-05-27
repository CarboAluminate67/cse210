using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Reference: ");
        string refer = Console.ReadLine();
        string[] refParts = refer.Split(' ', ':', '-');
        string book;
        string chapter;
        string startVerse;
        string endVerse;
        try
        {
            int bookNum = int.Parse(refParts[0]);
            book = $"{refParts[0].ToString()} {refParts[1]}";
            chapter = refParts[2];
            startVerse = refParts[3];
            if (refParts.Count() > 4)
            {
                endVerse = refParts[4];
            }
            else
            {
                endVerse = null;
            }
        }
        catch (FormatException)
        {
            book = refParts[0];
            chapter = refParts[1];
            startVerse = refParts[2];
            if (refParts.Count() > 3)
            {
                endVerse = refParts[3];
            }
            else
            {
                endVerse = null;
            }
        }

        Reference reference;
        if (endVerse != null)
        {
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            reference = new Reference(book, chapter, startVerse);
        }

        Console.WriteLine("Scripture Text: ");
        string text = Console.ReadLine();
        Scripture script = new Scripture(text, reference);


        do
        {
            script.DisplayScripture();
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            if (input == "back") // entering back restores 3 random words
            {
                script.ShowWords();
            }
            else
            {
            script.HideWords();
            }      
        }
        while (script.AllHidden() == false);
        
        script.DisplayScripture();

    }
}