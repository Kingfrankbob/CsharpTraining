namespace yarn
{
  public class program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Gray;
      Console.BackgroundColor = ConsoleColor.Black;
      int choice = getInput.getChoice();
      switch (choice)
      {

        // case 1:
        //   cherryOne.threeDone();
        //   program.Main();
        //   break;

        // case 2:
        //   appleTwo.itOkay();
        //   program.Main();
        //   break;

        case 3:
          yellow.timeToStop();
          program.Main();
          break;

        case 4:
          green.PascalCase();
          program.Main();
          break;

        case 5:
          blue.VowelCounter();
          program.Main();
          break;

        case 6:
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("\nGoodbye\n");
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.Beep();
          Console.Beep();
          break;

        default:
          break;
      }
    }
  }
}
