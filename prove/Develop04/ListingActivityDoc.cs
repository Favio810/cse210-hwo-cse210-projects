using System;
using System.Collections.Generic;

public class ListingActivity: Activity
{
    private int _ListingTime;
    Activity listingTime = new Activity();

    public void ListingPrompts()
    {
        var answer = GetRandomPrompt();
    }

    public string GetRandomPrompt()
    {
        string answer = "";
        Random rnd = new Random();
        int prompt = rnd.Next(0, 5);

        if (prompt == 0)
        {
            answer = "Who are people that you appreciate?";
            Console.WriteLine(answer);
        }
        if (prompt == 1)
        {
            answer = "What are personal strengths of yours?";
            Console.WriteLine(answer);
        }
        if (prompt == 2)
        {
            answer = "Who are people that you have helped this week?";
            Console.WriteLine(answer);
        }
        if (prompt == 3)
        {
            answer = "When have you felt the Holy Ghost this month?";
            Console.WriteLine(answer);
        }
        if (prompt == 4)
        {
            answer = "Who are some of your personal heroes?";
            Console.WriteLine(answer);
        }
        return answer;
    }
    public void GetListFromUser(int listingTime)
    {
        _ListingTime = listingTime;
        List<string> _answers = new List<string>();
       
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(listingTime);

        while (DateTime.Now < finishTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _answers.Add(response);
        }
        int numberList = _answers.Count;
        Console.WriteLine($"You listed {numberList} items!");
        // foreach (string v in _answers)
        // {
        //     Console.WriteLine(v);
        // }
    }
}