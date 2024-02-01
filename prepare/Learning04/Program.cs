using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment aa = new Assignment("Favio Callejas", "Multiplication");
        Console.WriteLine(aa.GetSummary());

        MathAssignment bb = new MathAssignment("Faviola Callejas", "Fractions", "9.1", "9-21");
        Console.WriteLine(bb.GetSummary());
        Console.WriteLine(bb.GetHomeworkList());

        WritingAssignment cc = new WritingAssignment("Cibela Callejas", "Bolivian History", "Pacific War");
        Console.WriteLine(cc.GetSummary());
        Console.WriteLine(cc.GetWritingInformation());
    }
}