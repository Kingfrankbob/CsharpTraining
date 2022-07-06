namespace frootLoops
{
  public static class blueberryFour
  {
    public static void randomNumberGuess()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Random rnd = new Random();
      int randomNumber = rnd.Next(1, 10);
      int guess = 0;
      int guessCount = 0;
      while (guess != randomNumber)
      {
        guessCount++;
        Console.WriteLine("Guess a number between 1 and 10:");
        guess = getInput.getIntOneToTen();
        if (guess < randomNumber)
        {
          Console.WriteLine("Too low");
        }
        else if (guess > randomNumber)
        {
          Console.WriteLine("Too high");
        }
        else
        {
          if (guessCount <= 4)
          {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You got it in {0} guesses!\nYou WIN!", guessCount);
            Console.ForegroundColor = ConsoleColor.Gray;
          }
          else
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You got it in {0} tries!\nYou Lose Idiot", guessCount);
            Console.ForegroundColor = ConsoleColor.Gray;
          }
        }
      }
    }
  }

}
