using System;

class Program
{
    static void Main(string[] args)
    {
        List<userEntry> _goals = new List<userEntry>();
        userEntry _goalsUser = new userEntry();
        int points = 0;
        Console.WriteLine($"You have {points} points");
        GoalManager userGoal = new GoalManager();
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.WriteLine("");
            Console.WriteLine("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            int choose = int.Parse(userInput);

            if (choose == 1)
            {
                userGoal.CreateGoal();
            }
            else if (choose == 2)
            {
                userGoal.Displaying();
            }
            else if (choose == 3)
            {
                userGoal.SaveGoals();
            }
            else if (choose == 4)
            {
                userGoal.LoadGoals();
            }
            else if (choose == 5)
            {
                userGoal.RecordEvent();
            }
            else if (choose == 6)
            {
                loop = false;
            }
        }
    }
}