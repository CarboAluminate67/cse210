public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string Book()
    {
        return _book.ToString();
    }
    public string Chapter()
    {
        return _chapter.ToString();
    }
    public string StartVerse()
    {
        return _startVerse.ToString();
    }
    public string EndVerse()
    {
        try
        {
            return _endVerse.ToString();
        }
        catch(NullReferenceException)
        {
            return null;
        }
    }
}