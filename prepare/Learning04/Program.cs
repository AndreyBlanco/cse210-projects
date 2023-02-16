using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment student = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(student.GetSummary());

        MathAssignment homework = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");

        Console.WriteLine(homework.GetSummary());
        Console.WriteLine(homework.GetHomeworkList());

        WritingAssignment text = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(text.GetSummary());
        Console.WriteLine(text.GetWritingInformation());
    }
}