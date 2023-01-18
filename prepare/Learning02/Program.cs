using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "McDonald´s";
        job1._jobTitle = "Salesperson";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Toyota";
        job2._jobTitle = "Sales Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Andrey Blanco";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

        
    }
}

