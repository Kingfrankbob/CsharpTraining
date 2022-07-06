namespace UserInput
{
  class problemFour
  {

    public static void SpeedCamera()
    {

      Console.WriteLine("\nEnter the speed limit");
      int speedLimit = getInput.getIntNotNeg();
      Console.WriteLine("\nEnter the speed of the car");
      int speed = getInput.getIntNotNeg();
      int speedDifference = (speed - speedLimit) / 5;
      if (speedDifference > 0)
      {
        Console.WriteLine("You are speeding by {0} mph\n", speed - speedLimit);

        if (speedDifference > 11)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\nYou are going to lose your license\n You have {0} points on your license\n", speedDifference);
          Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\nYou are going to have a fine\n You have {0} points on your license\n", speedDifference);
          Console.ForegroundColor = ConsoleColor.Gray;
        }
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nOkay! You are not speeding\n");
        Console.ForegroundColor = ConsoleColor.Gray;
      }
    }
  }
}
