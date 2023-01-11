using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int insertion = 1;
        int sum = 0;
        int count = 0;
        float average = 0;
        int largest = 0;
        int smallest = 1000000;

        while (insertion != 0)
        {
            Console.Write("Enter number: ");
            insertion = int.Parse(Console.ReadLine());

            if (insertion != 0)
            {
                numbers.Add(insertion);
            }

        }

        numbers.Sort();

        foreach (int number in numbers)
        {
            sum = sum + number;
            count = count +1;
            if (number > largest)
            {
                largest = number;
            }
            if (number < smallest & number > 0)
            {
                smallest = number;
            }
        }

        average = (float)sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }



    }
}