namespace frootLoops
{
  public class getInput
  {
    public static int getChoice()
    {
      try
      {
        Console.WriteLine(@"Please select a program to run (1-5):
1. 3 Divisor Check
2. Add 'em up!
3. Factorial Calculator
4. Random Number Guess!?
5. Biggest of them all
6. Exit
");

        int choice = int.Parse(Console.ReadLine() ?? "");
        if (choice < 1 || choice > 6)
        {
          throw new Exception();
        }
        return choice;
      }
      catch (Exception)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPlease enter a valid number");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("--------------------------------");
        return getChoice();
      }
    }

    public static int getIntNotNeg()
    {
      try
      {
        Console.WriteLine("Enter a number larger that 0");
        int inputNumber = int.Parse(Console.ReadLine() ?? "");
        if (inputNumber < 1)
        {
          throw new Exception();
        }
        return inputNumber;
      }
      catch (Exception)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nInvalid Input\n");
        Console.ForegroundColor = ConsoleColor.Gray;
        return getIntNotNeg();
      }
    }

    public static int getAnyInt()
    {
      try
      {
        Console.WriteLine("Enter a number");
        int inputNumber = int.Parse(Console.ReadLine() ?? "");

        return inputNumber;
      }
      catch (Exception)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nInvalid Input\n");
        Console.ForegroundColor = ConsoleColor.Gray;
        return getAnyInt();
      }
    }

    public static int getIntOneToTen()
    {
      try
      {
        Console.WriteLine("Enter a number from 1 - 10");
        int inputNumber = int.Parse(Console.ReadLine() ?? "");
        if (inputNumber < 0 || inputNumber > 10)
        {
          throw new Exception();
        }
        return inputNumber;
      }
      catch (Exception)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nInvalid Input\n");
        Console.ForegroundColor = ConsoleColor.Gray;
        return getIntOneToTen();
      }
    }
  }
}
