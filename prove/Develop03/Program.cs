using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorize");
        Console.ReadLine();
        //Console.Clear();

        Scripture a = new Scripture();
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(a.GetScriptureString());
        Console.ReadLine();
        Console.Clear();

        string myNumbers = a.threeNumbers();

        string allNumbers = a.continueNumbers();

        Console.WriteLine(a.wordSort());
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(a.wordSort2());
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(a.wordSort3());
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(a.wordSort4());
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(a.wordSort5());
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(a.wordSort6());
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine(a.wordClear());
        Console.ReadLine();
    }
}