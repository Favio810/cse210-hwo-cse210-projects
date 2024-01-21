using System;
using System.Collections.Generic;

//New class, it has most of the code, because it has two objects date and write 

public class Journal
{
    //Actual date
    public string date = DateTime.Now.Date.ToString("dd/MM/yyyy");
    //Two list: entries and new entries (for saving the information in a csv document)
        List<userEntry> _entries = new List<userEntry>();
    List<userEntry> _newEntries = new List<userEntry>();

    public PromptGenerator question = new PromptGenerator();
    public void Write()
    {
        var answer = question.GetRandomPrompt();
        //Console.WriteLine(answer);
        string userInput = Console.ReadLine();
        userEntry entry = new userEntry();
        entry._dateTime = date;
        entry._prompt = answer;
        entry._response = userInput;
        _entries.Add(entry);
        _newEntries.Add(entry);
    }
        //Display the information in terminal
        public void Display()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._dateTime} - Prompt: {entry._prompt}");
            Console.WriteLine($"Answer: {entry._response}");
        }
    }
        //Load a specific document called journal.csv
        public void Load()
    {
        Console.WriteLine("What is the filename?");
        string document = Console.ReadLine();
        if (document == "journal.csv")
        {
            string filename = "journal.csv";
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("This document doesn't exist, try again");
        }
    }
        //Save in a specific document called journal.csv
        public void Save()
    {
        Console.WriteLine("What is the filename?");
        string document = Console.ReadLine();
        if (document == "journal.csv")
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter ("journal.csv", true);
            foreach (var row in _newEntries)
            {
                var rowString = $"{row._dateTime}, {row._prompt}, {row._response}";
                outputFile.WriteLine(rowString);
            }
            outputFile.Close();
            _newEntries = new List<userEntry>();
            Console.WriteLine("Your information was saved");
        }
        else
        {
            Console.WriteLine("This document doesn't exist, try again");
        }
    }

}