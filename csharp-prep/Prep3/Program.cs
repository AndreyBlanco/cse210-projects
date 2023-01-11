using System;

class Program
{
    static void Main(string[] args)
    {
        string playGame = "yes";

        while (playGame == "yes")
        {
            Console.WriteLine("Hello Prep3 World!");
            Console.Write("What is the magic number?: ");
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
            
            string answer = "";
            
            while ((answer != "You guessed it!"))
            {
                Console.Write("What is your guess?: ");
                int guessNum = int.Parse(Console.ReadLine());

                if (magicNum > guessNum)
                {
                    answer = "Higher";
                }
                else if (magicNum < guessNum)
                {
                    answer = "Lower";
                }
                else
                {
                    answer = "You guessed it!";
                }
                Console.WriteLine(answer);
            }
            Console.WriteLine();
            Console.Write("Do you want to play again? (yes/no): ");
            
            playGame = Console.ReadLine();
            playGame = playGame.ToLower();
        }
    }
}