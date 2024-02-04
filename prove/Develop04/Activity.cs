using System;
using System.Collections.Generic;

public class Activity
{
    public string _date = DateTime.Now.Date.ToString("dd/MM/yyyy");

    private string _name;
    //private string _description;
    private int _duration;

    public void DisplayStartingMessage(string name)
    {
        _name = name;
        //_description = description;
        
        Console.WriteLine($"Date: {_date}");
        Thread.Sleep(3000);
        Console.WriteLine("");
        Console.WriteLine($"Welcome {name} to Mindfulness Program");
        Console.WriteLine("This program will help you have a moment of relaxation that will contribute to your emotional and physical well-being.");
        Console.WriteLine("You schedule your time in each of the activities");
        Console.WriteLine("");
        Console.WriteLine("Enjoy it!");
    }
    public void DisplayEndingMessage(string name)
    {
        _name = name;
        Console.WriteLine($"Thank for your time {name}. I hope you had a good time relaxing.");
        Console.WriteLine("Come back soon!");
    }
    public void ShowSpinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        _duration = seconds;
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}