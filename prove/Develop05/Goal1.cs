using System;

public class Goal
{
    public string GoalName()
    {
        string answer = "";
        answer = "What is the name of your goal?: ";
        Console.WriteLine(answer);

        return answer;
    }
    public string GoalDetails()
    {
        string answer = "";
        answer = "What is a short description of it?: ";
        Console.WriteLine(answer);

        return answer;
    }
    public string GoalPoints()
    {
        string answer = "";
        
        answer = "What is the amount of points associated with this goal?: ";
        
        Console.WriteLine(answer);
        return answer;
    }
    public string GoalTimes()
    {
        string answer ="";
        answer = "How many times does this goal need to be accomplished for a bonus?: ";
        Console.WriteLine(answer);
        return answer;
    }
    public string GoalBonus()
    {
        string answer ="";
        answer = "What is the bonus for accomplishing it that many times?: ";
        Console.WriteLine(answer);
        return answer;
    }
}