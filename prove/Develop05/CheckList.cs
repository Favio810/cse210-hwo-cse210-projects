using System;
using System.Collections.Generic;

public class CheckListGoal: userEntry
{
    List<userEntry> _entries2 = new List<userEntry>();
    List<userEntry> _newEntries2 = new List<userEntry>();
    private string _shortName2;
    private string _description2;
    private string _goalPoints2;
    private string _goalTimes;
    private string _goalBonus;
    
    Goal goalC = new Goal();
    public void userWriteChecklist(string shortName, string description, string goalPoints, string goalTimes, string goalBonus)
    {
        _shortName2 = shortName;
        _description2 = description;
        _goalPoints2 = goalPoints;
        _goalTimes = goalTimes;
        _goalBonus = goalBonus;

        userEntry entry2 = new userEntry();
        var answer7 = goalC.GoalName();
        shortName = Console.ReadLine();
        var answer8 = goalC.GoalDetails();
        description = Console.ReadLine();
        var answer9 = goalC.GoalPoints();
        goalPoints = Console.ReadLine();
        int points2 = int.Parse(goalPoints);
        var answer10 = goalC.GoalTimes();
        goalTimes = Console.ReadLine();
        int times2 = int.Parse(goalTimes);
        var answer11 = goalC.GoalBonus();
        goalBonus = Console.ReadLine();
        int bonus2 = int.Parse(goalBonus); 
        
        entry2._name = shortName;
        entry2._details = description;
        entry2._points = goalPoints;
        entry2._times = goalTimes;
        entry2._bonus = goalBonus;
        _entries2.Add(entry2);
        
        // foreach (var centry in _entries2)
        // {
        //     Console.WriteLine($"{centry._name} {centry._points} {centry._bonus}");
        // }
    }
    public void Display2()
    {
        foreach (var entryList2 in _entries2)
        {
            Console.WriteLine($" {entryList2._name} ({entryList2._details}) {entryList2._points} {entryList2._times} {entryList2._bonus}");
        }
    }
    public string ChecklistName()
    {
        string first = "";
        foreach(var data1 in _entries2)
        {
            first = $"{data1._name}";
        }
        return first;
    }
    public string ChecklistDetails()
    {
        string second = "";
        foreach(var data2 in _entries2)
        {
            second = $"{data2._details}";
        }
        return second;
    }
    public string ChecklistPoints()
    {
        string third = "";
        foreach (var data3 in _entries2)
        {
            third = $"{data3._points}";
        }
        return third;
    }
    public string ChecklistTimes()
    {
        string fourth = "";
        foreach (var data4 in _entries2)
        {
            fourth = $"{data4._times}";
        }
        return fourth;
    }
    public string ChecklistBonus()
    {
        string fifth = "";
        foreach (var data5 in _entries2)
        {
            fifth = $"{data5._bonus}";
        }
        return fifth;
    }

    public void RecordEvent3()
    {
        Console.WriteLine("What is the filename? ");
        string fileName3 = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName3))
        {
            foreach (var row3 in _entries2)
            {
                outputFile.WriteLine($"{row3._name}, {row3._details}, {row3._points}");
            }
            outputFile.Close();
            Console.WriteLine("The file was created");
        }
    }
}