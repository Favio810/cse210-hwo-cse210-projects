using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        Console.WriteLine("What is your name?: ");
        string userName = Console.ReadLine();
        activity.DisplayStartingMessage(userName);
        activity.ShowSpinner();

        bool loop = true;
        while (loop)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("");
            Console.WriteLine("     1. Start Breathing Activity");
            Console.WriteLine("     2. Start Reflecting Activity");
            Console.WriteLine("     3. Start Listing Activity");
            Console.WriteLine("     4. Quit");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.WriteLine("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            int choose = int.Parse(userInput);

            if (choose == 1)
            {
                Console.WriteLine($"Welcome {userName} to Breathing Activity");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Thread.Sleep(2000);
                Console.WriteLine("How long, in seconds, would you like for your session?: ");

                string userInput2 = Console.ReadLine();
                int choose2 = int.Parse(userInput2);

                Console.WriteLine("Get ready...");
                activity.ShowSpinner();

                BreathingActivity breathingProgram = new BreathingActivity();
                breathingProgram.Run(choose2);

                Console.WriteLine($"Well Done {userName}! :D");
                activity.ShowSpinner();
                Console.WriteLine("");
                Console.WriteLine($"You have completed another {choose2} seconds of the Breathing Activity");
                activity.ShowSpinner();
            }
            else if (choose == 2)
            {
                Console.WriteLine($"Welcome {userName} to Reflecting Activity.");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Thread.Sleep(2000);
                Console.WriteLine("How long, in seconds, would you like for your session?: ");

                string userInput3 = Console.ReadLine();
                int choose3 = int.Parse(userInput3);

                Console.WriteLine("Get ready...");
                activity.ShowSpinner();
                Console.WriteLine("Consider the following prompt: ");
                // activity.ShowCountDown(6);
                ReflectingActivity reflectAct1 = new ReflectingActivity();
                reflectAct1.ReflectingPrompts();

                Console.WriteLine("When you have something in mind, press enter tu continue.");

                string userInput5 = Console.ReadLine();
                string enterKey = "";
                if (userInput5 == enterKey)
                {
                    Console.WriteLine("You may begin in: ");
                    activity.ShowCountDown(5);
                    reflectAct1.GetQuestion(choose3);
                }
                Console.WriteLine("");
                Console.WriteLine($"Well Done {userName} :D");
                activity.ShowSpinner();
                Console.WriteLine("");
                Console.WriteLine($"You have completed another {choose3} seconds on Reflecting Activity.");
                activity.ShowSpinner();
            }
            else if (choose == 3)
            {
                Console.WriteLine($"Welcome {userName} to Listing Activity.");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Thread.Sleep(2000);
                Console.WriteLine("How long, in seconds, would you like for your session?: ");

                string userInput4 = Console.ReadLine();
                int choose4 = int.Parse(userInput4);

                Console.WriteLine("Get ready...");
                activity.ShowSpinner();

                Console.WriteLine("List as many responses you can to the following prompt: ");
                //activity.ShowCountDown(6);
                ListingActivity listingActiv = new ListingActivity();
                listingActiv.ListingPrompts();
                Console.WriteLine("");
                Console.WriteLine("You may begin in: ");
                activity.ShowCountDown(8);
                listingActiv.GetListFromUser(choose4);

                Console.WriteLine("");
                Console.WriteLine($"Well Done {userName} :D");
                activity.ShowSpinner();
                Console.WriteLine("");
                Console.WriteLine($"You have completed another {choose4} seconds on Listing Activity.");
                activity.ShowSpinner();
            }
            else if (choose == 4)
            {
                activity.DisplayEndingMessage(userName);
                loop = false;
            }
        }
    }
}