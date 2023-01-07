using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();
        Console.Write("What is your grade percentage?: ");
        string gradePercentaje = Console.ReadLine();
        Console.WriteLine();
        
        int numGrade = int.Parse(gradePercentaje);
        string letterGrade = "A";
        string sign = "";
        int endNum = numGrade % 10;
        
        if (numGrade >= 90)
        {
            letterGrade = "A";
            if (endNum < 3)
            {
                sign = "-";
            };
        }
        else if (numGrade >= 80)
        {
            letterGrade = "B";
            sign = searchSign(endNum);
        }
         else if (numGrade >= 70)
        {
            letterGrade = "C";
            sign = searchSign(endNum);
        }
         else if (numGrade >= 60)
        {
            letterGrade = "D";
            sign = searchSign(endNum);
        }
         else
        {
            letterGrade = "F";
        };

        if (!(letterGrade == "D" || letterGrade == "F"))
        {
            Console.WriteLine($"Your grade is {letterGrade}{sign}");
            Console.WriteLine("Congratulations!!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Your grade is {letterGrade}{sign}");
            Console.WriteLine("Keep trying!!");
            Console.WriteLine();
        };

    }

    static string searchSign(int endNum)
    {
        string mySign = "";

        if (endNum > 7)
        {
            mySign = "+";
        }
        else if (endNum < 3)
        {
            mySign = "-";
        }

        return mySign;
    }
}