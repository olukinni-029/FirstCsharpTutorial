using System;

namespace FirstCsharpTutorial
{
     class Program
    {
        static void Main(string[] args)
        {
          // app variable
          string appName = "Number Gusser";
            string appVersion = "1.0.0";
            string appAuthor = "Olukinni Feranmi";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}:Version {1} by {2}",appName,appVersion,appAuthor);
            Console.ResetColor();
            //Ask Users name
            Console.WriteLine("Hello,what is your name?"); 

            //Get the name input
            string NameInput = Console.ReadLine();
            Console.WriteLine("{0},let's play a game...",NameInput);

            while (true)
            {
                //Set the coorect number to guess
                //int correctNumber = 5;

                //generating a random number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //guess number
                int guessedNumber = 0;

                //Ask user for the number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guessedNumber != correctNumber)
                {
                    //Get the user input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guessedNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter an actual number");
                        Console.ResetColor();
                        continue;
                    }

                    // Cast to int and put in guess
                    guessedNumber = Int32.Parse(input);

                    //check if the guessed number is equal to the correct number
                    if (guessedNumber != correctNumber)
                    {
                        //error message
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You guessed wrong,please try again");
                        Console.ResetColor();
                    }
                }
                //output success message
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Correct,You guessed right!!!");
                Console.ResetColor();

                //Ask if the user wants to play again
                Console.WriteLine("Play again?[Y or N]");

                //Get their answer
                string answer = Console.ReadLine().ToUpper();
                Console.ReadLine();
                if(answer == "Y")
                {
                 continue;

                }else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

    }
}
