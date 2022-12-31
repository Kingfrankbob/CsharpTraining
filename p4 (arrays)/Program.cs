namespace Vacashon
{
  class program
  {
    public static void MainVacashon()
    {
      Console.ForegroundColor = ConsoleColor.Gray;
      Console.BackgroundColor = ConsoleColor.Black;
      int choice = getInput.getChoice();
      switch (choice)
      {

        case 1:
          NYC_ONE.noFriends();
          program.MainVacashon();
          break;

        case 2:
          madagascarTwo.Reversi();
          program.MainVacashon();
          break;

        case 3:
          MexicoThree.numberAsk();
          program.MainVacashon();
          break;

        case 4:
          tahitiFour.uniquity();
          program.MainVacashon();
          break;

        case 5:
          moscowFive.Smallestofall();
          program.MainVacashon();
          break;

        case 6:
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("\nGoodbye\n");
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.Beep();
          Console.Beep();
          break;

        default:
          Console.WriteLine("Invalid Input");
          program.MainVacashon();
          break;

      }
    }
  }
}


