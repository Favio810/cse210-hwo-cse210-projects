using System;
using System.Collections.Generic;

public class SimpleGoal: userEntry
{
    List<userEntry> _entries = new List<userEntry>();
    List<userEntry> _newEntries = new List<userEntry>();
    private string _shortName;
    private string _description;
    private string _goalPoints;
    
    Goal goalA = new Goal();
    public void userWrite(string shortName, string description, string goalPoints)
    {
        _shortName = shortName;
        _description = description;
        _goalPoints = goalPoints;
        
        userEntry entry = new userEntry();
        var answer1 = goalA.GoalName();
        shortName = Console.ReadLine();
        var answer2 = goalA.GoalDetails();
        description = Console.ReadLine();
        var answer3 = goalA.GoalPoints();
        goalPoints = Console.ReadLine();
        int points = int.Parse(goalPoints);
       
        entry._name = shortName;
        entry._details = description;
        entry._points = goalPoints;
        _entries.Add(entry);
        _newEntries.Add(entry);
    }
    public void Display()
    {
        foreach (var entryList in _entries)
        {
            Console.WriteLine($" {entryList._name} ({entryList._details})");
        }
    }
    public string SimpleName()
    {
        string first = "";
        foreach(var date in _entries)
        {
            first = $"{date._name}";
        }
        return first;
    }
    public string SimpleDetails()
    {
        string second = "";
        foreach(var date1 in _entries)
        {
            second = $"{date1._details}";
        }
        return second;
    }
    public string SimplePoints()
    {
        string third = "";
        foreach(var date2 in _entries)
        {
            third = $"{date2._points}";
        }
        return third;
    }
    public void RecordEvent1()
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var row in _entries)
            {
                outputFile.WriteLine($"{row._name}, {row._details}, {row._points}");
            }
            outputFile.Close();
            Console.WriteLine("The file was created");
        }
    }
}