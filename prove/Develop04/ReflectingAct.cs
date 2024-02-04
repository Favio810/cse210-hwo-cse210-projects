using System;
using System.Collections.Generic;

public class ReflectingActivity: Activity
{
    private int _activityTime;
    Activity reflectingTime = new Activity();

    public void ReflectingPrompts()
    {
        var answer = GetRandomPrompt();

        reflectingTime.ShowCountDown(3);
    }

    public string GetRandomPrompt()
    {
        string answer = "";
        Random rnd = new Random();
        int prompt = rnd.Next(0, 4);

        if (prompt == 0)
        {
            answer = "---Think of a time when you stood up for someone else---";
            Console.WriteLine(answer);
        }
        if (prompt == 1)
        {
            answer = "---Think of a time when you did something really difficult---";
            Console.WriteLine(answer);
        }
        if (prompt == 2)
        {
            answer = "---Think of a time when you helped someone in need---";
            Console.WriteLine(answer);
        }
        if (prompt == 3)
        {
            answer = "---Think of a time when you did something truly selfless---";
            Console.WriteLine(answer);
        }
        return answer;
    }

    public void GetQuestion(int activityTime)
    {
        _activityTime = activityTime;
        List<string> _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        DateTime reflecting11 = DateTime.Now;
        DateTime endReflecting = reflecting11.AddSeconds(activityTime);
        foreach (string w in _questions)
        {
            while (DateTime.Now < endReflecting) 
            {
                Console.WriteLine("");
                Console.WriteLine(w);
                reflectingTime.ShowSpinner();
                break;
            }
        }   
    }
}