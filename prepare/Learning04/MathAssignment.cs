using System;

public class Math : Assignment
{
    private string _bookSection;
    private string _problems;

    public Math(string name, string topic, string section, string problems) : base(name, topic)
    {
        _bookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_bookSection} Problems {_problems}";
    }
}