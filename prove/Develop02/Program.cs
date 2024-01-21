using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to your Journal");
        // Creating new object
        Journal journal = new Journal();
        bool loop = true;
        // Creating a loop list with 5 options
        while (loop)
        {
            Console.WriteLine("");
            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("");
            Console.WriteLine("     1. Write an entry");
            Console.WriteLine("     2. Display all entries");
            Console.WriteLine("     3. Load entries from a file");
            Console.WriteLine("     4. Save entries to a file");
            Console.WriteLine("     5. Exit");
            Console.WriteLine("What would you like to do?: ");
            string userInput = Console.ReadLine();
            int choose = int.Parse(userInput);

            if (choose == 1)
            {
                journal.Write();
            }
            else if (choose == 2)
            {
                journal.Display();
            }
            else if (choose == 3)
            {
                journal.Load();
            }
            else if (choose == 4)
            {
                journal.Save();
            }
            else if (choose == 5)
            {
                Console.WriteLine("Thanks for using this program");
            loop = false;
            }
        }
    }
}