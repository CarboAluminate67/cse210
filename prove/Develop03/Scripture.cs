public class Scripture
{
    private List<Word> _scriptureText = new List<Word>();
    private Reference _reference;

    public Scripture(string text, Reference refer)
    {
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Console.WriteLine(word);
            Word wrd = new Word(word);
            this._scriptureText.Add(wrd);
        }

        _reference = refer;
    }

    public void DisplayScripture()
    {
        Console.Clear();
        if (_reference.EndVerse() != null)
        {
            Console.WriteLine($"{_reference.Book()} {_reference.Chapter()}:{_reference.StartVerse()}-{_reference.EndVerse()}");
        }
        else
        {
            Console.WriteLine($"{_reference.Book()} {_reference.Chapter()}:{_reference.StartVerse()}");
        }
        foreach (Word word in _scriptureText)
        {
            Console.Write($"{word.ShowWord()} ");
        }
    }
    public void HideWords()
    {
        int length = _scriptureText.Count;
        Random rand = new Random();
        int count = 0;
        while (count < 4)
        {
            int index = rand.Next(length);
            if (count >= 3)
            {
                break;
            }
            if (_scriptureText[index].IsHidden() == false)
            {
                _scriptureText[index].Hide();
                count += 1;
            }
            if (AllHidden() == true)
            {
                break;
            }
        }
        
    }

    public void ShowWords() // Added stretch method to allow backtracking in memorization (Restores 3 random words)
    {
        int length = _scriptureText.Count;
        Random rand = new Random();
        int count = 0;
        while (count < 4)
        {
            int index = rand.Next(length);
            if (count >= 3)
            {
                break;
            }
            if (_scriptureText[index].IsHidden() == true)
            {
                _scriptureText[index].Show();
                count += 1;
            }
        }
    }

    public bool AllHidden()
    {
        foreach (Word word in _scriptureText)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

}   