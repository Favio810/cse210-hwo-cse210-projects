using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float percent = float.Parse(grade);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
            if (percent <= 93)
            {
                sign = "-";
            }
        }
        else if (percent >= 80)
        {
            letter = "B";
            if (percent >= 87)
            {
                sign = "+";
            }
            else if (percent <= 83)
            {
                sign = "-";
            }
        }
        else if (percent >= 70)
        {
            letter = "C";
            if (percent >= 77)
            {
                sign = "+";
            }
            else if (percent <= 73)
            {
                sign = "-";
            }
        }
        else if (percent >= 60)
        {
            letter ="D";
            if (percent >= 67)
            {
                sign = "+";
            }
            else if (percent <= 63)
            {
                sign = "-";
            }
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Try it again, good luck next time!");
        }
    }
}