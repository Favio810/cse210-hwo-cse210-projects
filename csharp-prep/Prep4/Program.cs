using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        Console.WriteLine(" ");
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine ($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        int min = 9999;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine ("");
        Console.WriteLine("The sorted list is:");

        int[] sorting = numbers.ToArray();
        Array.Sort(sorting);
        foreach (int value in sorting)
        {
            Console.Write(value);
            Console.Write("");
        }
        Console.ReadLine();
    }
}