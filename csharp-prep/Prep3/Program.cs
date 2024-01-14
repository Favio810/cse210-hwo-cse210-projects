using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int number = 0;
        int attempts = 0;

        while (attempts < 100)
        {
            while (number != magicNumber)
            {
                Console.Write("What is your guess?: ");
                number = int.Parse(Console.ReadLine());

                if (magicNumber > number)
                {
                    Console.WriteLine("Higher");
                    attempts++;
                }
                else if (magicNumber < number)
                {
                    Console.WriteLine("Lower");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You did it in {attempts+1} attempts");
                    break;
                }
            }
        }
    }
}