using System;
using System.Collections.Generic;

public class EternaGoal: userEntry
{
    List<userEntry> _entries1 = new List<userEntry>();
    List<userEntry> _newEntries1 = new List<userEntry>();
    private string _shortName1;
    private string _description1;
    private string _goalPoints1;
    
    Goal goalB = new Goal();
    public void userWriteEternal(string shortName, string description, string goalPoints)
    {
        _shortName1 = shortName;
        _description1 = description;
        _goalPoints1 = goalPoints;

        userEntry entry1 = new userEntry();
        var answer4 = goalB.GoalName();
        shortName = Console.ReadLine();
        var answer5 = goalB.GoalDetails();
        description = Console.ReadLine();
        var answer6 = goalB.GoalPoints();
        goalPoints = Console.ReadLine();
        int points1 = int.Parse(goalPoints);
    
        entry1._name = shortName;
        entry1._details = description;
        entry1._points = goalPoints;
        _entries1.Add(entry1);
        
        // foreach (var bentry in _entries1)
        // {
        //     Console.WriteLine($"{bentry._name}");
        // }
    }
    public void Display1()
    {
        foreach (var entryList1 in _entries1)
        {
            Console.WriteLine($" {entryList1._name} ({entryList1._details})");
        }
    }
    public string EternalName()
    {
        string first = "";
        foreach(var date in _entries1)
        {
            first = $"{date._name}";
        }
        return first;
    }
    public string EternalDetails()
    {
        string second = "";
        foreach(var date1 in _entries1)
        {
            second = $"{date1._details}";
        }
        return second;
    }
    public string EternalPoints()
    {
        string third = "";
        foreach (var date2 in _entries1)
        {
            third = $"{date2._points}";
        }
        return third;
    }

    public void RecordEvent2()
    {
        Console.WriteLine("What is the filename? ");
        string fileName2 = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName2))
        {
            foreach (var row2 in _entries1)
            {
                outputFile.WriteLine($"{row2._name}, {row2._details}, {row2._points}");
            }
            outputFile.Close();
            Console.WriteLine("The file was created");
        }
    }
}