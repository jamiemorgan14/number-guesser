using System;

namespace random_number
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Welcome to the Number Guesser");

      bool playing = true;
      Random rnd = new Random();

      //keep track of moves
      int moves = 0;

      //Generate random number
      int compNum = rnd.Next(1, 101);
      //start game
      while (playing)
      {
        //Allow player to enter number
        System.Console.WriteLine(@"Pick a number: 
        ");
        string input = Console.ReadLine();

        //determine if good input and compare user num to compNum
        moves++;
        int playerMove;
        if (!Int32.TryParse(input, out playerMove) || playerMove < 0 || playerMove > 101)
        {

          System.Console.WriteLine(@"
          **Please provide a valid number from 1-100**");
        }
        else
        {
          if (playerMove == compNum)
          {
            System.Console.WriteLine("That's correct!");
            System.Console.WriteLine($"It took you {moves} moves to best the computer!");
            // ask if they want to play again
            System.Console.WriteLine(@"
            Would you like to play again? Press 'y' to continue.");
            string playAgain = Console.ReadLine();
            if (playAgain != "y")
            {
              System.Console.WriteLine("Thanks for playing!");
              return;
            }
            else if (playAgain == "y")
            {
              moves = 0;
              compNum = rnd.Next(1, 101);
            }
          }
          else if (playerMove < compNum)
          {
            System.Console.WriteLine("Higher!");
          }
          else
          {
            System.Console.WriteLine("Lower!");
          }
        }

      }
    }

  }
}
