public class Word
{
    private bool _hidden;
    private string _word;
    private string _rememberWord;

    public Word(string word)
    {
        _hidden = false;
        _word = word;
        _rememberWord = word;
    }

    public void Hide()
    {
        _hidden = true;
        int length = _word.Length;
        _word = "";
        for (int i = 0; i < length; i++)
        {
            _word += "_";
        }
    }

    public void Show() // Returns original word
    {
        _word = _rememberWord;
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string ShowWord()
    {
        return _word;
    }

}
