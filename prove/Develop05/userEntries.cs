using System;

public class userEntry
{
    public int _numb;
    public string _brakets;
    public string _title;
    public string _name;
    public string _details;
    public string _points;
    public string _times;
    public string _bonus;

    
    public void Display()
    {
        Console.WriteLine(_numb);
        Console.WriteLine(_brakets);
        Console.WriteLine(_title);
        Console.WriteLine(_name);
        Console.WriteLine(_details);
        Console.WriteLine(_points);
        Console.WriteLine(_times);
        Console.WriteLine(_bonus);
    }
}