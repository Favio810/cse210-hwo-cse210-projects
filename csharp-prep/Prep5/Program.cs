using System;

class Program
{
    static void Main(string[] args)
    {
        welcomeMessage();
        Console.WriteLine(" ");
        
        string name = myName();
        int number = myNumber();

        int square = squareNumber(number);

        displayResult(name, square);
    }
    static void welcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string myName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int myNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void displayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}