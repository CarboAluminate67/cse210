using System;
public class Writing : Assignment
{
    private string _title;

    public Writing(string name, string topic, string title) :base(name, title)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{_title} by {getName()}";
    }
}