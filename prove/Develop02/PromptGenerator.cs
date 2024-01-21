using System;
using System.Collections.Generic;

// New class PromptGenerator, it chooses a question ramdomly
public class PromptGenerator
{
    //
    public string GetRandomPrompt()
    {
        string answer = "";
        Random rnd = new Random();
        int question = rnd.Next(0, 5);

        if (question == 0)
        {
            answer = "Who was the most interesting person I interacted with today?";
            Console.WriteLine(answer);
        }
        else if (question == 1)
        {
            answer = "What was the best part of my day?: ";
            Console.WriteLine(answer);
        }
        else if (question == 2)
        {
            answer = "How did I see the hand of the Lord in my life today?: ";
            Console.WriteLine(answer);
        }
        else if (question == 3)
        {
            answer = "What was the strongest emotion I felt today?: ";
            Console.WriteLine(answer);
        }
        else if (question == 4)
        {
            answer = "If I had one thing I could do over today, what would it be?: ";
            Console.WriteLine(answer);
        }
        return answer;
    }
}