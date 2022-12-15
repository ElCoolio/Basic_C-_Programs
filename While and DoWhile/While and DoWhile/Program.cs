using System;

// Pregram to practice braanching statements.  Uses a while loop and a do while loop to make a guessing game

class Program
{
    static void Main()
    {
        // Intro
        Console.WriteLine("While Loop Test");
        Console.WriteLine("Input \'true\' or \'false\' for the next statements, if entered incorrectly it will loop.");
        bool q1 = false;
        bool q2 = false;

        // while loop to get input from user, does not continue until the user inputs "true" and "true"
        while(!q1 || !q2 ) {

            Console.WriteLine("First response");
            q1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Second response");
            q2 = Convert.ToBoolean(Console.ReadLine());

        }


        //Number guessing game, uses a do while loop and a switch statement to give multiple responses
        Console.WriteLine("Do While Loop Test");
        Console.WriteLine("This time, we will play a guessing game.  If you guess incorrectly the game will restart");
        Console.WriteLine("Guess a number");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = number == 12;

        do
        {
            switch (number)
            {
                case (10):
                    Console.WriteLine("You are really close");
                    Console.WriteLine("Guess again");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case (11):
                    Console.WriteLine("You are really close");
                    Console.WriteLine("Guess again");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case (12):
                    Console.WriteLine("You Guessed Correctly!");
                    Console.ReadLine();
                    isGuessed = true;
                    break;
                case (13):
                    Console.WriteLine("You are really close");
                    Console.WriteLine("Guess again");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case (14):
                    Console.WriteLine("You are really close");
                    Console.WriteLine("Guess again");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    if (number < 12)
                    {
                        Console.WriteLine("Your guess is smaller than the number I am thinking of");
                    }
                    else if (number > 12)
                    {
                        Console.WriteLine("Your guess is greater than the number I am thinking of");
                    }
                    Console.WriteLine("Guess again");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        while (!isGuessed);
    }
}
