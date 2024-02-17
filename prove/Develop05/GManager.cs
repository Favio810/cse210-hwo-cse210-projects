using System;
using System.Collections.Generic;

public class GoalManager: userEntry
{
    public int _actualGoal = 0;
    public int _actualTimes = 0;
    public int _actualPoints = 0;
   
    List<userEntry> _goals = new List<userEntry>();
    List<int> _pointsAdding = new List<int>();
    List<int> _pointsEarned = new List<int>();
    List<string> _bonusPoints = new List<string>();
    List<string> _titleGoals = new List<string>();
    List<string> _timesGoals = new List<string>();
    List<string> _brakets1 = new List<string>();
    
    
    SimpleGoal newSimpleGoal = new SimpleGoal();
    EternaGoal newEternalGoal = new EternaGoal();
    CheckListGoal newChecklistGoal = new CheckListGoal();
    

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?: ");
        string userAnswer = Console.ReadLine();
        int userChoose = int.Parse(userAnswer);

        if (userChoose == 1)
        {
            int listNumber = _goals.Count;
            userEntry _goalsUser = new userEntry();
            newSimpleGoal.userWrite(_goalsUser._name, _goalsUser._details, _goalsUser._points);

            _goalsUser._numb = listNumber + 1;
            _goalsUser._brakets = "[ ]";
            _brakets1.Add(_goalsUser._brakets);
            _goalsUser._title = "Simple goal";
            _titleGoals.Add(_goalsUser._title);
            _goalsUser._name = newSimpleGoal.SimpleName();
            _goalsUser._details = newSimpleGoal.SimpleDetails();
            _goalsUser._points = newSimpleGoal.SimplePoints();
            _goalsUser._times = "-";
            _timesGoals.Add(_goalsUser._times);
            _goalsUser._bonus = "-";
            int gainedPoints  = int.Parse(_goalsUser._points);
            _bonusPoints.Add(_goalsUser._bonus);

            _pointsAdding.Add(gainedPoints);
            
            _goals.Add(_goalsUser);
            Console.WriteLine("You created a new Goal");
            //Console.WriteLine(String.Join(", ", _pointsAdding));
        }
        else if (userChoose == 2)
        {
            
            int listNumber2 = _goals.Count;
            userEntry _goalsUser1 = new userEntry();
            newEternalGoal.userWriteEternal(_goalsUser1._name, _goalsUser1._details, _goalsUser1._points);
            _goalsUser1._numb = listNumber2 + 1;
            _goalsUser1._brakets = "[ ]";
            _brakets1.Add(_goalsUser1._brakets);
            _goalsUser1._title = "Eternal goal";
            _titleGoals.Add(_goalsUser1._title);
            _goalsUser1._name = newEternalGoal.EternalName();
            _goalsUser1._details = newEternalGoal.EternalDetails();
            _goalsUser1._points = newEternalGoal.EternalPoints();
            _goalsUser1._times = "-";
            _timesGoals.Add(_goalsUser1._times);
            _goalsUser1._bonus = "-";
            int gainedPoints1  = int.Parse(_goalsUser1._points);
            _bonusPoints.Add(_goalsUser1._bonus);
            _pointsAdding.Add(gainedPoints1);
            _goals.Add(_goalsUser1);
            Console.WriteLine("You created a new Goal");
            //Console.WriteLine(String.Join(", ", _pointsAdding));
        }
        else if (userChoose == 3)
        {
            int listNumber3 = _goals.Count;
            userEntry _goalsUser2 = new userEntry();
            newChecklistGoal.userWriteChecklist(_goalsUser2._name, _goalsUser2._details, _goalsUser2._points, _goalsUser2._times, _goalsUser2._bonus);
            _goalsUser2._numb = listNumber3 + 1;
            _goalsUser2._brakets = "[ ]";
            _brakets1.Add(_goalsUser2._brakets);
            _goalsUser2._title = "Checklist goal";
            _titleGoals.Add(_goalsUser2._title);
            _goalsUser2._name = newChecklistGoal.ChecklistName();
            _goalsUser2._details = newChecklistGoal.ChecklistDetails();
            _goalsUser2._points = newChecklistGoal.ChecklistPoints();
            _goalsUser2._times = newChecklistGoal.ChecklistTimes();
            _timesGoals.Add(_goalsUser2._times);
            _goalsUser2._bonus = newChecklistGoal.ChecklistBonus();

            int gainedPoints2  = int.Parse(_goalsUser2._points);
            //int gainedBonus = int.Parse(_goalsUser2._bonus);
            _pointsAdding.Add(gainedPoints2);
            _bonusPoints.Add(_goalsUser2._bonus);
            _goals.Add(_goalsUser2);
            //Console.WriteLine(String.Join(", ", _pointsAdding));
            Console.WriteLine("You created a new Goal");
        }
    }
    public void Displaying()
    {
        Console.WriteLine("The Goals are: ");
    
        foreach(var t in _goals)
        {
            Console.WriteLine($"{t._numb}.{t._brakets}  {t._title}: {t._name},({t._details}),{t._points},{t._times},{t._bonus}");
        }
     
        int pointsSum = _pointsEarned.Sum();
        _actualPoints = pointsSum;
        Console.WriteLine($"Your actual score is {_actualPoints} points");
        
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var row in _goals)
            {
                outputFile.WriteLine($"{row._numb},{row._brakets},{row._title},{row._name},{row._details},{row._points},{row._times},{row._bonus}");
            }
            // outputFile.WriteLine($"{_actualPoints}");
            outputFile.Close();
            Console.WriteLine("The file was created");
        }
    }
    public void LoadGoals()
    {   
        Console.WriteLine("What is the filename?");
        _goals.Clear();
        _pointsAdding.Clear();
        _titleGoals.Clear();
        _timesGoals.Clear();
        _bonusPoints.Clear();
        _brakets1.Clear();
        string document = Console.ReadLine();
        if (document == "goals.txt")
        {
            
            string filename = "goals.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {   
                userEntry _goalsUser3 = new userEntry();
                string[] parts = line.Split(",");

                string loadNumb = parts[0];
                int loadNumb1 = int.Parse(loadNumb);
                string loadBrakets = parts[1];
                string loadTitle = parts[2];
                string loadName = parts[3];
                string loadDetails = parts[4];
                string loadPoints = parts[5];
                string loadTimes = parts[6];
                string loadBonus = parts[7];
            
                _goalsUser3._numb = loadNumb1;
                _goalsUser3._brakets = loadBrakets;

                _goalsUser3._title = loadTitle;
                _titleGoals.Add(_goalsUser3._title);
                _goalsUser3._name = loadName;
                _goalsUser3._details = loadDetails;
                _goalsUser3._points = loadPoints;
                int pointsLoaded = int.Parse(_goalsUser3._points);
                _goalsUser3._times = loadTimes;
                _brakets1.Add(_goalsUser3._brakets);
                _timesGoals.Add(_goalsUser3._times);
                _goalsUser3._bonus = loadBonus;
                _bonusPoints.Add(_goalsUser3._bonus);
                _goals.Add(_goalsUser3);
                _pointsAdding.Add(pointsLoaded);
            }

            Console.WriteLine("Your file is downloaded");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        foreach(var t in _goals)
        {
            Console.WriteLine($"{t._numb}. {t._name}");
        }
        Console.WriteLine("Which goal did you accomplish?: ");
        string goalAnswer = Console.ReadLine();
        int goalNumber = int.Parse(goalAnswer);
        string titleGoal = _titleGoals[goalNumber-1];
        // string totalTimes = _timesGoals[goalNumber-1];
        // Console.WriteLine($"{totalTimes}");
        //int _totalTimes1 = int.Parse(totalTimes);
        if (titleGoal == "Simple goal")
        {
            _brakets1[goalNumber-1] = "[x]";

            int a = _pointsAdding[goalNumber-1];
            _pointsEarned.Add(a);
            Console.WriteLine($"You earned {a} points");
            
        }
        else if (titleGoal == "Eternal goal")
        {
            _brakets1[goalNumber-1] = "[x]";

            int b = _pointsAdding[goalNumber-1];
            _pointsEarned.Add(b);
            Console.WriteLine($"You earned {b} points");
        }
        else if (titleGoal == "Checklist goal")
        {
            _actualTimes++;
            string totalTimes = _timesGoals[goalNumber-1];
            int totalTimes1 = int.Parse(totalTimes);
            Console.WriteLine($"{totalTimes1}");
        //     Console.WriteLine(_actualTimes);
            if (_actualTimes < totalTimes1)
            {
                int p = _pointsAdding[goalNumber-1];
                _pointsEarned.Add(p);
                Console.WriteLine($"You earned {p} points");
            }
            else if (_actualTimes == totalTimes1)
            {
                _brakets1[goalNumber-1] = "[x]";
                string bonusForEarn = _bonusPoints[goalNumber-1];
                int bonusEarned = int.Parse(bonusForEarn);
                _pointsEarned.Add(bonusEarned);
                Console.WriteLine($"Congratulations, you earned {bonusEarned} points");
            }
        }
       
        Console.WriteLine("");
        int pointsSum = _pointsEarned.Sum();
        Console.WriteLine($"You have {pointsSum} points");
    }
   
}