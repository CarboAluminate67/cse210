using System;

public class Assignment
{
    private string _name;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string getName()
    {
        return _name;
    }

    public string getTopic()
    {
        return _topic;
    }

    public string getSummary()
    {
        return $"{_name} - {_topic}";
    }
}