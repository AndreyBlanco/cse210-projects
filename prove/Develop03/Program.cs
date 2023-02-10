using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Welcome to Scripture Memorizer Program");
        Console.WriteLine("");

        Reference newScriptureGen = new Reference();
        Scripture newScripture = new Scripture(newScriptureGen.SendReference(), newScriptureGen.SendText());

        newScripture.Display();

        Console.WriteLine("");

        string endProgram = "continue";

        while (endProgram != "quit")
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            endProgram = Console.ReadLine();

            if (endProgram != "quit")
            {
                if (newScripture.RemainWords() >= 4)
                {
                    newScripture.SelectWords();
                    newScripture.SelectWords();
                    newScripture.SelectWords();
                    newScripture.Display();
                    Console.WriteLine("");
                }
                else if (newScripture.RemainWords() == 3)
                {
                    newScripture.SelectWords();
                    newScripture.SelectWords();
                    newScripture.Display();
                    Console.WriteLine("");
                }
                else if (newScripture.RemainWords() == 2)
                {
                    newScripture.SelectWords();
                    newScripture.Display();
                    Console.WriteLine("");
                }
                else
                {
                    Console.Clear();
                    endProgram = "quit";
                }
            }
        }
        Console.Clear();
    }
}